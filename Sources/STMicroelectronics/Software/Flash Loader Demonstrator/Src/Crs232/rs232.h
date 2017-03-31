/******************** (C) COPYRIGHT 2011 STMicroelectronics ********************
* File Name          : rs232.h
* Author             : MCD Application Team
* Version            : v2.4.0
* Date               : 07/18/2011
* Description        : Defines the RS232 class for COM communication
********************************************************************************
* THE PRESENT SOFTWARE WHICH IS FOR GUIDANCE ONLY AIMS AT PROVIDING CUSTOMERS
* WITH CODING INFORMATION REGARDING THEIR PRODUCTS IN ORDER FOR THEM TO SAVE TIME.
* AS A RESULT, STMICROELECTRONICS SHALL NOT BE HELD LIABLE FOR ANY DIRECT,
* INDIRECT OR CONSEQUENTIAL DAMAGES WITH RESPECT TO ANY CLAIMS ARISING FROM THE
* CONTENT OF SUCH SOFTWARE AND/OR THE USE MADE BY CUSTOMERS OF THE CODING
* INFORMATION CONTAINED HEREIN IN CONNECTION WITH THEIR PRODUCTS.
*******************************************************************************/

#ifndef LSERIE_H
#define LSERIE_H

#include <string>
using namespace std;


class CRS232  
{
public:
	void SetParity(int _parity);
	BOOL isConnected;

	int numPort;
	long speedInBaud;
	int nbBit;
	int parity;
	float nbStopBit;
	int  bEcho ;             /* Echo back for LIN emulation */
	                         /* 0 : Disabled , 1 : Echo Back , 2 : Listen back */
    bool FlowControl;

	//------ CONSTRUCTOR ------
	CRS232();									
	virtual ~CRS232();

	//------ OPEN AND CONFIGURE ------
	void SetComSettings(int _numPort, long _speedInBaud, int _nbBit, int _parity, float _nbStopBit);


	bool open();	// Open the serial port COM "numPort" at the speed "speedInBaud".
			        // bauds with and this adjustement : "nbBit" bit / "nbStopBit" stop bit / "parity").
														// Return: true if success.
	void closeCom();			                //Close the serial port.
	bool setTimeOut(DWORD ms);					//Set the time-out for receive data. Return: true if success.
	bool setSpeed(DWORD baudrate);				//Set the speed in bauds. Return: true if success.

	//------ SEND AND RECEIVE DATA ------
	int sendData(DWORD lg, LPBYTE data);		//Send table "data" of "lg" bytes.  Return: number of bytes really sent.
	int sendData(string* data);					//Send string "data".  Return: number of bytes really sent.
	int receiveData(DWORD lg, LPBYTE data);		//Receive table "data" who is limit at "lg" bytes.  Return: number of bytes received.
	int receiveData(string* data);				//Receive string "data". Return: number of bytes received.

	//------ READ AND WRITE THE STATE OF THE CONTROL LINE ------

	bool setRts(bool val);			// Set the state of RTS. Return: true if success.
	bool setDtr(bool val);			// Set the state of DTR. Return: true if success.
	bool setTxd(bool val);			// Set the state of TXD. Return: true if success.
	bool getCts();					// Return: The state of CTS.			
	bool getDtr();					// Return: The state of DTR.	
	bool getRi();					// Return: The state of RI.	
	bool getCd();					// Return: The state of CD.	
	
	string getErrorMsg();			// Return: The error message generated by the last function.

private:
	HANDLE			hcom;				//Otput file to the COM port    		| The file stream use for acces to the serial port.
	_COMMTIMEOUTS	ct;                 //={0,0,0,0,0}; //Config du Time Out	| This variable contain the delay of the time-out. 
	DCB				dcb;				//Port configuration struct				| This object is use in order to configure the serial port.
	int				bufferSize;
};

#endif 

/******************* (C) COPYRIGHT 2011 STMicroelectronics *****END OF FILE******/
