
// FrSky DJT "D8" Tx Telemetry Module
// by ceptimus on 2015-09-10

// cleaned up by gke for UAVX and OLED display 2020

// CANNOT KEEP UP #define NO_INVERTER // uncomment for direct connection of DJT using ~100K resistor

#include "SSD1X06.h"

SSD1X06 oled;

enum {
  // Data IDs  (BP = before decimal point; AP = after decimal point)

  ID_D4R = 0xfe,
  ID_USER_DATA = 0xfd,

  ID_GPS_ALT_BP = 0x01,
  ID_GPS_ALT_AP = 0x09,
  ID_TEMP1 = 0x02,
  ID_RPM = 0x03,
  ID_FUEL = 0x04,
  ID_TEMP2 = 0x05,
  ID_VOLTS = 0x06,

  ID_WHERE_DIST = 0x07, // used by LUA - metres the aircraft is way

  ID_PITCH = 0x08,

  ID_ALT_BP = 0x10,
  ID_ALT_AP = 0x21,
  ID_GPS_SPEED_BP = 0x11,
  ID_GPS_SPEED_AP = 0x19,
  ID_GPS_LONG_BP = 0x12,
  ID_GPS_LONG_AP = 0x1A,
  ID_E_W = 0x22,
  ID_GPS_LAT_BP = 0x13,
  ID_GPS_LAT_AP = 0x1B,

  ID_COURSE_BP = 0x14,
  ID_COURSE_AP = 0x1C,
  ID_DATE_MONTH = 0x15,
  ID_YEAR = 0x16,
  ID_HOUR_MINUTE = 0x17,
  ID_SECOND = 0x18,

  ID_ROLL = 0x20,

  ID_N_S = 0x23,
  ID_ACC_X = 0x24,
  ID_ACC_Y = 0x25,
  ID_ACC_Z = 0x26,
  ID_CURRENT = 0x28,

  //ID_WHERE_DIST = 0x29,
  ID_WHERE_BEAR = 0x2a, // bearing (deg) to aircraft
  ID_WHERE_ELEV = 0x2b, // elevation (deg) of the aircraft above the horizon
  ID_WHERE_HINT = 0x2c, // which to turn to come home intended for voice guidance

  ID_COMPASS = 0x2d, // deg

  ID_VERT_SPEED = 0x30,

  ID_MAH = 0x36, // mAH battery consumption

  ID_VFAS = 0x39,
  ID_VOLTS_BP = 0x3A,
  ID_VOLTS_AP = 0x3B,

  ID_BEEPER = 0x3C,

  ID_FRSKY_LAST = 0x3D
                  //opentx vario
};

enum {WaitRxSentinel, WaitRxID, WaitRxBody};

bool BeeperOn = false;
uint8_t rssi;
uint8_t a1;
uint8_t a2;
int16_t timeout;

bool GPSValid, OriginValid, Armed;

void writeOled(uint8_t row, uint8_t col, uint8_t a, uint8_t b, uint8_t c, uint8_t d, uint16_t frac, uint8_t dp) {
  oled.displayString6x8(row, col, "         ", false);
  oled.displayReal32(row, col, (((int32_t)b << 8) + a) * frac + (((int16_t)d << 8) + c), dp, ' ');
}

void handlechByte(uint16_t ch) {
  static uint8_t chPacket[4];
  static uint8_t FrSkyPacketRxState = 0;
  static uint8_t FrSkyUserchLow;
  static uint8_t FrSkyPacketID;
  static bool FrSkyUserchStuffing;
  static bool FrSkyUserchLowFlag; // flag for low byte of ch, which is the first of the following two
  int16_t i, Temp, Temp2;
  uint16_t high, low;
  uint8_t NoOfSats, HDOP;


  switch (FrSkyPacketRxState) {
    case WaitRxSentinel: // idle
      if (ch == 0x5E) // telemetry hub frames begin with ^ (0x5E)
        FrSkyPacketRxState = 1; // expect telemetry hub chID next
      break;
    case WaitRxID: // expecting telemetry hub chID
      if (ch < 0x3C) { // store chID (address)
        FrSkyUserchStuffing = false;
        FrSkyPacketID = ch;
        FrSkyPacketRxState = WaitRxBody; // expect two bytes of ch next
        FrSkyUserchLowFlag = true; // flag for low byte of ch, which is the first of the following two
      }
      else if (ch != 0x5E) // the header byte 0x5E may occur twice running as it is also used as an 'end of frame' so remain in mode 1. Otherwise chID was > 0x3B, so invalid
        FrSkyPacketRxState = WaitRxSentinel;

      break;
    case WaitRxBody: // expecting two bytes of ch
      if (FrSkyUserchStuffing) {
        FrSkyUserchStuffing = false;
        if ((ch != 0x3D) && (ch != 0x3E)) { // byte stuffing is only valid for (unstuffed) bytes 0x5D or or 0x5E
          FrSkyPacketRxState = WaitRxSentinel; // back to idle mode
          break;
        }
        else
          ch ^= 0x20; // unstuff byte
      }
      else if (ch == 0x5D) { // following byte is stuffed
        FrSkyUserchStuffing = true;
        break;
      } // switch

      if (FrSkyUserchLowFlag) { // expecting low byte of ch
        FrSkyUserchLow = ch; // remember low byte
        FrSkyUserchLowFlag = false; // expect high byte next
      }
      else { // expecting high byte of ch


        switch ( FrSkyPacketID ) {
          case ID_COURSE_BP:
          case ID_ALT_BP:
          case ID_GPS_ALT_BP:
          case ID_GPS_SPEED_BP:
          case ID_VOLTS_BP:
          case ID_GPS_LAT_BP:
          case ID_GPS_LONG_BP:
            chPacket[0] = FrSkyUserchLow;
            chPacket[1] = ch;
            break;

          case ID_GPS_LAT_AP:
          case ID_GPS_LONG_AP:
            chPacket[2] = FrSkyUserchLow;
            chPacket[3] = ch;
            break;

          //________________________________


          case ID_BEEPER:
            // BeeperOn = (((uint16_t)ch << 8 | FrSkyUserchLow) & 1 != 0) ;
            // if (BeeperOn)
            //    oled.displayChar6x8(1, 14, '*');
            //   else
            //    oled.displayChar6x8(1, 14, ' ');
            break;
          case ID_TEMP1: // flight mode
            oled.displayString6x8(1, 15, "    ", false);
            Temp = (uint16_t)ch << 8 | FrSkyUserchLow;
            if (((Temp / 10) % 10) >= 4)
              oled.displayString6x8(1, 15, "MAN ", false);

            Temp2 = (Temp / 100) % 10;
            if (Temp2 == 2)
              oled.displayString6x8(1, 15, "AH  ", false);
            else if ((Temp2 == 4) || (Temp2 == 6))
              oled.displayString6x8(1, 15, "HOLD", false);

            Temp2 = (Temp / 1000) % 10;
            if (Temp2 == 1)
              oled.displayString6x8(1, 15, "RTH ", false);
            else if (Temp2 == 2)
              oled.displayString6x8(1, 15, "NAV ", false);

            break;
          case ID_TEMP2: // gps flags
            Temp = (uint16_t)ch << 8 | FrSkyUserchLow;
            GPSValid = ((Temp / 1000) % 10) >= 1;
            OriginValid = ((Temp / 1000) % 10) >= 3;
            Armed =  ((Temp / 1000) % 10) >= 7;
            if (GPSValid)// && OriginValid)
              oled.displayString6x8(5, 0, "gpsOK", false);
            else
              oled.displayString6x8(5, 0, "     ", false);
            oled.displayString6x8(5, 6, "hdop  ", false);
            oled.displayInt32(5, 11, (Temp / 1000) % 10);
            NoOfSats = Temp % 100;
            oled.displayString6x8(5, 13, "sats   ", false);
            oled.displayInt32(5, 18, NoOfSats);
            break;
          case ID_GPS_ALT_AP:
            oled.displayString6x8(6, 0, "    ", false);
            oled.displayReal32(6, 0, ((int16_t)chPacket[1] << 8) | chPacket[0], 0, 'm');
            break;
          case ID_COURSE_AP:
            oled.displayString6x8(6, 8, "    ", false);
            oled.displayReal32(6, 8, ((int16_t)chPacket[1] << 8) | chPacket[0], 0, 'd');
            break;
          case ID_COMPASS :
            oled.displayString6x8(3, 15, "     ", false);
            oled.displayReal32(3, 15, ((int16_t)chPacket[1] << 8) | chPacket[0], 0, 'd');
            break;
          case ID_VERT_SPEED:
            oled.displayString6x8(0, 8, "      ", false);
            oled.displayReal32(0, 8, ((int16_t)ch << 8) | FrSkyUserchLow, 1, 0);
            break;
          case ID_RPM:
            //Temp = ((int16_t)ch << 8) | FrSkyUserchLow;
            //oled.displayString6x8(0, 15, "     ", false);
            // oled.displayInt32(0, 15, Temp * 5);
            break;
          case ID_FUEL:
            // oled.displayString6x8(1, 15, "    ", false);
            // oled.displayReal32(1, 15, ((int16_t)ch << 8) | FrSkyUserchLow, 0, '%');
            break;
          case ID_VOLTS_AP:
            break;
          case ID_VOLTS:
            break;
          case ID_VFAS:
            oled.displayString6x8(1, 0, "    ", false);
            oled.displayReal32(1, 0, ((int16_t)ch << 8) | FrSkyUserchLow, 1, 'v');
            // ? estimate #cells and do beeper alarm
            break;
          case ID_CURRENT:
            oled.displayString6x8(1, 8, "     ", false);
            oled.displayReal32(1, 8, ((int16_t)ch << 8) | FrSkyUserchLow, 1, 'a');
            break;
          case ID_MAH:
            //  ??
            break;
          case ID_PITCH:
            oled.displayString6x8(3, 0, "p    ", false);
            oled.displayInt32(3, 1, ((int16_t)ch << 8) | FrSkyUserchLow);
            break;
          case ID_ROLL:
            oled.displayString6x8(3, 8, "r    ", false);
            oled.displayInt32(3, 9, ((int16_t)ch << 8) | FrSkyUserchLow);
            break;
          case ID_ALT_AP:
            oled.displayString6x8(0, 0, "   ", false);
            //writeOled(0, 0, chPacket[0], chPacket[1], FrSkyUserchLow, ch, 10, 1);
            oled.displayReal32(0, 0, ((int16_t)chPacket[1] << 8) | chPacket[0], 0, 'm');
            break;
          case ID_GPS_SPEED_AP:
            oled.displayString6x8(6, 15, "    ", false);
            writeOled(6, 15, chPacket[0], chPacket[1], FrSkyUserchLow, ch, 10, 1);
            break;
          case ID_N_S:
            i = (uint16_t)chPacket[1];
            i = (i << 8) | chPacket[0]; // degrees * 100 + minutes
            high = (i / 100) >> 8;
            low = (i / 100) & 0x00ff;
            writeOled(7, 0, low, high, chPacket[2], chPacket[3], 10000, 4);
            oled.displayChar6x8(7, 8, FrSkyUserchLow);
            break;
          case ID_E_W:
            i = (uint16_t)chPacket[1];
            i = (i << 8) | chPacket[0]; // degrees * 100 + minutes
            high = (i / 100) >> 8;
            low = (i / 100) & 0x00ff;
            writeOled(7, 11, low, high, chPacket[2], chPacket[3], 10000, 4);
            oled.displayChar6x8(7, 19, FrSkyUserchLow);
            break;
          case ID_DATE_MONTH:
            break;
          case ID_YEAR:
            break;
          case ID_HOUR_MINUTE:
            break;
          case ID_SECOND:
            break;
          case ID_WHERE_BEAR: // bearing (deg) to aircraft
            oled.displayString6x8(4, 0, "     ", false);
            oled.displayReal32(4, 0, ((int16_t)ch << 8) | FrSkyUserchLow, 0, 'd');
            break;
          case ID_WHERE_DIST:
            oled.displayString6x8(4, 6, "     ", false);
            oled.displayReal32(4, 6, ((int16_t)ch << 8) | FrSkyUserchLow, 0, 'm');
            break;
          case ID_WHERE_HINT: // which to turn to come home intended for voice guidance
            oled.displayString6x8(4, 12, "hint      ", false);
            oled.displayReal32(4, 16, ((int16_t)ch << 8) | FrSkyUserchLow, 0, 'd');
            break;
          case ID_WHERE_ELEV: // elevation (deg) of the aircraft above the horizon
            //oled.displayString6x8(4, 15, "     ", false);
            //oled.displayReal32(4, 15, ((int16_t)ch << 8) | FrSkyUserchLow, 0, 'd');
            break;

          default:
            break;
        }
        FrSkyPacketRxState = WaitRxSentinel;
      } // else
      break;
    default: // should never happen
      FrSkyPacketRxState = WaitRxSentinel;
      break;
  }
}

void handlePacket(uint16_t *packet) {
  switch (packet[0]) {
    case 0xFD:
      if (packet[1] > 0 && packet[1] <= 6)
        for (int i = 0; i < packet[1]; i++)
          handlechByte(packet[3 + i]);

      cli(); timeout = 1000; sei();
      break;
    case 0xFE:
      a1 = packet[1]; // A1:
      a2 = packet[2]; // A2:
      rssi = packet[3]; // main (Rx) link quality 100+ is full signal  40 is no signal
      // packet[4] secondary (Tx) link quality.
      cli(); timeout = 1000; sei();

      oled.displayString6x8(0, 14, "rssi    ", false);
      oled.displayInt32(0, 19, rssi);
      BeeperOn = rssi < 45;
      break;
  }

}

void handleRxChar(uint16_t b) { // decode FrSky basic telemetry ch
  static uint8_t packetPosition = 0;
  static uint16_t packet[9];
  static bool byteStuffing = false;

  if (b == 0x7E) { // framing character
    if (packetPosition > 8)
      handlePacket(packet);
    packetPosition = 0;
  } else {
    if (b == 0x7D)
      byteStuffing = true;
    else {
      if (byteStuffing) {
        byteStuffing = false;
        if (b != 0x5E && b != 0x5D) {
          packetPosition = 0;
          return;
        }
        else
          b ^= 0x20;
      }
      if (packetPosition > 8)
        packetPosition = 0;
      else
        packet[packetPosition++] = b;
    }
  }
}

#if defined(NO_INVERTER)

// this interrupt handler decodes incoming FrSky serial telemetry ch on digital 11
// FrSky module gives out RS232 levels (like +/- 6V) so use 100K inline resistor and rely on ATMega input diode clamps to convert to TTL
// See Atmel application note AVR182 explaining how this is an approved way to do it (they even run mains voltage into a pin via a 1M resistor!)
// Signal is also inverted but this code flips the bits back the right way
// only works at 9600N81 with TCNT0 incrementing every 4 uS (e.g. ATmega328 @ 16 MHz)
// works without delay for character values < 128 so fine for normal ASCII
// when receiving character values > 127, the character isn't processed till the start bit of the following character is received
// so if frame ends with such a character, the frame won't be processed till the beginning of the next frame

ISR(PCINT0_vect) { // Port B pinchange interrupt
  static uint8_t prev = 0;
  static uint8_t currChar = 0;
  static uint8_t currBits = 0;
  uint8_t now = TCNT0;
  sei(); // allow other interrupts once time has been captured
  uint8_t bits = (((uint8_t)(now - prev)) + 13) / 26; // at 9600 baud with 4 uS TCNT, one bit is 1E6 / (4 * 9600) = 26.04 counts, so half a bit is ~13 counts
  if (!bits || bits > 9) { // detect 0 bits when gap between characters and TCNT0 wrapped exactly, also limit bits to 9 to prevent overflow of (currBits + bits)
    bits = 9;
  }
  prev = now;
  if (!(PINB & 0x08)) { // -ve edge, but inverted RS232 so preceding ch bits were low
    if (!currBits) { // start of char so bits includes the start bit (start bit is low)
      currBits = 1; // currBits count does includes the start bit
      bits--; // but don't include start bit in character decode
    }
    currChar >>= bits; // received low bits represent '0' in character.  LSB arrives first, MSB last
    currBits += bits;
  }
  else if (currBits) { // preceding ch bits were high
    if (currBits + bits > 9)  // trim stop bit if receiving character values >= 128 (MSB will be high and stop bit is also high)
      bits = 9 - currBits;

    currChar = (0xFF00 | currChar) >> bits; // received high bits represent '1' in character.  LSB arrives first, MSB last
    currBits += bits;
  }
  if (currBits > 8) { // start bit plus character received
    uint8_t rxChar = currChar; // don't know if interrupt is re-entrant - if not then this won't help but if it is then allows next bit(s) to be received while handling char
    currChar = currBits = 0;
    handleRxChar(rxChar);
  }
}

#endif


void initDisplay(void) {
  uint8_t c;

  oled.start();
  delay(300);
  oled.fillDisplay(' ');
  delay(2000);

  //oled.displayString6x8(0, 0, F("FRSKY TELEMETRY"), 0);

  delay(2000); // start up message

}

uint32_t oldMillis;
int16_t millisTillNextPrint = 500; // send ch to serial port twice per second

void setup(void) {

#if defined(NO_INVERTER)
  pinMode(11, INPUT); // serial input (Digital 11 is Port B, bit 3)
  PCMSK0 = 0x08; // set mask to allow (only) digital pin 9 pinchange interrupts on Port B
  PCICR |= 0x01; // allow pinchange interrupts for Port B
#endif

  delay(500);

  initDisplay();

  rssi = a1 = a2 = 0;
  timeout = 1000; // ms
  Serial.begin(9600);
  oldMillis = millis();
}

void loop(void) {

  uint32_t now = millis();
  int32_t ms = now - oldMillis; // milliseconds elapsed since last loop
  oldMillis = now;

  if (timeout <= (int16_t)ms)
    timeout = a1 = a2 = rssi = 0;
  else
    timeout -= ms;

#if defined(NO_INVERTER)
  // interrupt routine calls handleRxChar
#else
  if (Serial.available())
    handleRxChar(Serial.read());
#endif

  if (ms >= millisTillNextPrint) { // time to print
    if (!rssi) {
      // Beeper alarm
    } else {

    }
    millisTillNextPrint += 500 - ms;
  } else
    millisTillNextPrint -= ms;

}
