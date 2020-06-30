/*  TWI (I2C)  code to drive 128x64 monochrome oled display module
    ceptimus.  September 2016
    Edited by Benik3 January 2019
    Edited by gke July 2019
*/
#include "SSD1X06.h"
#include <Wire.h>

void cmd(uint8_t c) {
  Wire.beginTransmission(SSD1X06_I2C_ADDRESS);
  Wire.write(0);
  Wire.write(c);
  Wire.endTransmission();
}

void SSD1X06::drawLine(uint8_t row, uint8_t x, uint8_t nrow, uint8_t *b) {  // draw line from array of bytes

#if defined(SSD1306)

  cmd(SSD1X06_PAGEADDR);
  cmd(row);

  cmd(row + nrow);
  cmd(SSD1X06_COLUMNADDR);

  cmd(x + SSD1X06_COLUMNOFFSET);
  cmd(x + SSD1X06_COLUMNOFFSET);

  for (int i = 0; i <= nrow; i++) {
    Wire.beginTransmission(SSD1X06_I2C_ADDRESS);
    Wire.write(0x40);
    Wire.write(*(b + i));
    Wire.endTransmission();
  }

#elif defined(SSD1106)

  for (uint8_t i = 0; i<= nrow; i++)
    displayByte(i+row, x, *(b + i));

#endif

}

void SSD1X06::fillDisplay(uint8_t c) { // fill whole display using character c
  for (uint8_t row = 0; row < SSD1X06_CHARHEIGHT; row++)
    for (uint8_t x = 0; x <= SSD1X06_CHARWIDTH; x++)
      displayChar6x8(row, x, c);
}

void SSD1X06::start(void) {
  Wire.begin();
  Wire.setClock(I2CSPEED);

  // initial setup commands for the display
#if defined(SSD1306)

  cmd(SSD1X06_DISPLAYOFF);      // 0xAE
  cmd(SSD1X06_SETMULTIPLEX);
  cmd(SSD1X06_LCDHEIGHT - 1);     //COMs (Px - 1)
  cmd(SSD1X06_SETDISPLAYOFFSET); cmd(0x00);
  cmd(SSD1X06_SETSTARTLINE | 0x00);
  #if defined(FLIP_OLED)
  cmd(SSD1X06_SEGREMAP);
    cmd(SSD1X06_COMSCANINC); 
  #else
  cmd(SSD1X06_SEGREMAP | 0x01);
   cmd(SSD1X06_COMSCANDEC);
  #endif
  cmd(SSD1X06_SETCOMPINS); cmd(0x12);         //selection of connection of SSD1306 chip to OLED. Available values: 0x02, 0x12, 0x22, 0x32. Check this if you have each second row empty.
  cmd(SSD1X06_SETCONTRAST); cmd(0xFF);
  cmd(SSD1X06_DISPLAYALLON_RESUME);
  cmd(SSD1X06_NORMALDISPLAY);
  cmd(SSD1X06_SETDISPLAYCLOCKDIV); cmd(0xF0); // 0xF0 for max frequency
  cmd(SSD1X06_CHARGEPUMP); cmd(0x14);         // enable charge pump
  cmd(SSD1X06_SETPRECHARGE); cmd(0xF1);       // 0xF1 for max brightness, 0x11 for max refresh rate
  cmd(SSD1X06_MEMORYMODE); cmd(0x01);         // vertical addressing mode
  cmd(SSD1X06_SETVCOMDETECT); cmd(0x70);      // higher number, higher brightness, max 0x70
  cmd(SSD1X06_DISPLAYON);

#elif defined(SSD1106)

  cmd(SSD1X06_DISPLAYOFF);

  cmd(0x02);    /*set lower column address*/
  cmd(0x10);    /*set higher column address*/

  cmd(0x40);    /*set display start line*/

  cmd(0xB0);    /*set page address*/

  cmd(SSD1X06_SETCONTRAST);    /*contrast control*/
  cmd(0x80);    /*128*/

#if defined(FLIP_OLED)
  cmd(0xA0);    // set segment remap*/
  #else
 cmd(0xA1);    // set segment remap*/
  #endif

  cmd(SSD1X06_NORMALDISPLAY);

  cmd(SSD1X06_SETMULTIPLEX);
  cmd(0x3F);    /*duty = 1/32*/

  cmd(0xad);    /*set charge pump enable*/
  cmd(0x8b);     /*external VCC   */

  cmd(0x30);    /*0X30---0X33  set VPP   9V liangdu!!!!*/

#if defined(FLIP_OLED)
  cmd(SSD1X06_COMSCANINC); 
  #else
  cmd(SSD1X06_COMSCANDEC);
  #endif

  cmd(0xD3);    /*set display offset*/
  cmd(0x00);   /*   0x20  */

  cmd(0xD5);    /*set osc division*/
  cmd(0x80);

  cmd(0xD9);    /*set pre-charge period*/
  cmd(0x1f);    /*0x22*/

  cmd(0xDA);    /*set COM pins*/
  cmd(0x12);

  cmd(0xdb);    /*set vcomh*/
  cmd(0x40);

  cmd(0xAF);    /*display ON*/

#endif

}

void SSD1X06::displayString6x8(uint8_t row, uint8_t x, const char *s, uint8_t rvsField) {
  if (row > SSD1X06_CHARHEIGHT - 1) {
    row = SSD1X06_CHARHEIGHT - 1;
  }
  if (rvsField)
    rvsField = 0x80;

  while (uint8_t c = *s++)
    displayChar6x8(row, x++, c ^ rvsField);
}

void SSD1X06::displayString6x8(uint8_t row, uint8_t x, const __FlashStringHelper *s, uint8_t rvsField) {
  if (rvsField)
    rvsField = 0x80;

  uint8_t *p = (uint8_t *)s;
  while (uint8_t c = pgm_read_byte_near(p++))
    displayChar6x8(row, x++, c ^ rvsField);
}

void SSD1X06::displayByte(uint8_t row, uint8_t x, uint8_t b) {

  SetColmnPage(row, x);

  Wire.beginTransmission(SSD1X06_I2C_ADDRESS);
  Wire.write(0x40);
  Wire.write(b);
  Wire.endTransmission();
}

void SSD1X06::displayChar6x8(uint8_t row, uint8_t x, uint8_t c) {
  uint8_t xorMask = c & 0x80 ? 0xFF : 0x00;  // if MSB set display character reverse field

  SetColmnPage(row, x * 6);
  Wire.beginTransmission(SSD1X06_I2C_ADDRESS);
  Wire.write(0x40);
  Wire.write(xorMask);

  uint16_t p = ((c & 0x7F) - 32) * 5;
  for (uint16_t i = 2; i < 7; i++ )
    Wire.write(pgm_read_byte_near(font + p++) ^ xorMask);
  Wire.endTransmission();
}

void SSD1X06::displayInt32(uint8_t line, uint8_t x, int32_t V) {
  uint8_t S[16];
  uint8_t c;
  int32_t Rem, NewV;


  if (V < 0) {
    SSD1X06::displayChar6x8(line, x++, '-');
    V = -V;
  }

  c = 0;
  do {
    NewV = V / 10;
    Rem = V - (NewV * 10);
    S[c++] = Rem + '0';
    V = NewV;
  } while (V > 0);

  do {
    SSD1X06::displayChar6x8(line, x++, S[--c]);
  } while (c > 0);

}

void SSD1X06::displayReal32(uint8_t line, uint8_t x, int32_t V, int8_t dp, uint8_t Separator) {
  uint8_t S[16];
  int8_t c, Rem, zeros, i;
  int32_t NewV;

  if (V < 0) {
    SSD1X06::displayChar6x8(line, x++, '-');
    V = -V;
  }
  //  else
  //    TxChar(s, ' ');

  c = 0;
  do {
    NewV = V / 10;
    Rem = V - (NewV * 10);
    S[c++] = Rem + '0';
    V = NewV;
  } while (V > 0);

  if ((c < (dp + 1)) && (dp > 0)) {
    SSD1X06::displayChar6x8(line, x++, '0');
    SSD1X06::displayChar6x8(line, x++, '.');
  }

  zeros = (int8_t) dp - c - 1;
  if (zeros >= 0)
    for (i = zeros; i >= 0; i--)
      SSD1X06::displayChar6x8(line, x++, '0');

  do {
    c--;
    SSD1X06::displayChar6x8(line, x++, S[c]);

    if ((c == dp) && (c > 0))
      SSD1X06::displayChar6x8(line, x++, '.');

  } while (c > 0);

  if (Separator != 0)
    SSD1X06::displayChar6x8(line, x++, Separator);

}

void SSD1X06::SetColmnPage(uint8_t row, uint8_t x) {
#if defined(SSD1306)

  cmd(SSD1X06_PAGEADDR);
  cmd(row);
  cmd(row);
  cmd(SSD1X06_COLUMNADDR);
  cmd(x + SSD1X06_COLUMNOFFSET);
  cmd(x < SSD1X06_LCDWIDTH + SSD1X06_COLUMNOFFSET - 6 ? 
    x + 5 + SSD1X06_COLUMNOFFSET : SSD1X06_LCDWIDTH + SSD1X06_COLUMNOFFSET - 1);

#elif defined(SSD1106)

  cmd(SSD1X06_SETSTARTPAGE + row);
  x += 2 + SSD1X06_COLUMNOFFSET;
  cmd((x & 0x0F) | SSD1X06_SETLOWCOLUMN); 
  cmd(((x >> 4) & 0x0F) | SSD1X06_SETHIGHCOLUMN); 

#endif
}
