//+----------------------------------------------------------------------------------------------------+
//| ATtiny2313A RS485 Communication (Receives Characters from PC and turn on LED's)                    |
//|                                                                                                    |
//| Hardware used - ATtiny2313 RS485 Quad Motor Control Board V1.0                                     |
//+----------------------------------------------------------------------------------------------------+
//| Program to communicate with PC using ATtiny2313A USART using RS485 Protocol.                       |
//|                                                                                                    |
//|                                                                                                    |
//| BaudRate = 4800bps                                                                                 |
//| Parity   = None                                                                                    |
//| StopBits = 1                                                                                       |
//+----------------------------------------------------------------------------------------------------+
//| ATtiny2313A Clocked using Internal RC oscillator,Default Value,1MHz (8MHz/8 = 1MHz)                |
//| Uses Polling for serial communication                                                              |
//+----------------------------------------------------------------------------------------------------+
//|Circuit Connections                                                                                 |
//|----------------------------------------------------------------------------------------------------|
//|                                                                                         PC         |
//|                     ATtiny2313           MAX485                                     +-----------+  |
//|                  +---------------+     +--------+       USB to RS485 Converter      | Windows   |  |
//| +--(D4)--[2.2K]--|PB3     PD0/RXD|<----|RO      |            +----------+           | Linux     |  |
//| |--(D5)--[2.2K]--|PB4     PD1/TXD|---->|DI     A|<~~~~~~~~~~>| A        |           | Mac       |  |
//| |--(D2)--[2.2K]--|PB2         PD4|---->|DE     B|<~~~~~~~~~~>| B     USB|<========> +-----------+  |     
//| |--(D3)--[2.2K]--|PD5         PD3|---->|~RE     |   RS485    +----------+          / [][][][][] /  |
//| |                +---------------+     +--------+   Twisted                       /[][][[][][] /   |
//|GND                                                  Cable                        +------------+    |
//|                                                                                                    |
//|                                                                                                    |
//| <--ATtiny2313 RS485 Quad Motor Control Board--->           <-USB2SERIAL->                          |
//|                                                                                                    |
//+----------------------------------------------------------------------------------------------------+
//| Hardware used - ATtiny2313 RS485 Quad Motor Control Board V1.0                                     |
//|               - USB2SERIAL (USB to RS485 converter)                                                |
//+----------------------------------------------------------------------------------------------------+
//| Compiler           : AVR GCC (WinAVR)                                                              |
//| Microcontroller    : ATtiny2313A                                                                   |
//| Programmer         : Rahul.Sreedharan                                                              |
//| Date               : 31-May-2016                                                                   |
//+----------------------------------------------------------------------------------------------------+

//(C) www.xanthium.in 
// Visit to Learn More 


#include <stdint.h>
#include <avr/io.h>
#include <util/delay.h>
#include "RS485.h"
int main()
{
	char data = ' ';
	uint16_t Baud = 12;             // from datasheet for Clock = 1Mhz,4800bps
	
	DDRB |= (1<<PB2) | (1<<PB3) |(1<<PB4); // PB2,PB3,PB4 all output
	DDRD |= (1<<PD5);                      // PD5 all output
	
	PORTB = 0x00;
	PORTD = 0x00;
	
	RS485_init(12);                 // intialize RS485 Port @4800bps
	while(1)
	{
		data  = RS485_Receive_Byte();   // Wait for PC to send data via  RS485 port 
	
		// use a switch to select appropriate action receiving commands from PC 
		switch (data)
			{
				case 'A':	PORTB |= (1<<PB3); // Switch ON LED D4
							break;
					
				case 'B':   PORTB |= (1<<PB4); // Switch ON LED D5
							break;
					
				case 'C':   PORTB |= (1<<PB2); // Switch ON LED D2
							break;
					
				case 'D':   PORTD |= (1<<PD5); // Switch ON LED D3
							break;
					
				default: 	PORTB &= ~(1<<PB3); // Switch OFF LED D4
							PORTB &= ~(1<<PB4); // Switch OFF LED D5
							PORTB &= ~(1<<PB2); // Switch OFF LED D2
							PORTD &= ~(1<<PD5); // Switch OFF LED D3
							break;
			}//end of switch
	}
	return 0;
	
	
}






//used for indicating where the code is at a given time ,Debugging purpose only
void LED_Debug_Blink(void)
{
    char i = 0;
	
    DDRB  |=  (1<<PB3); // PB3 Output
	
	for(i=0;i<2;i++)
	{
		PORTB |=  (1<<PB3); // PB3 = High,Lights up D4
		_delay_ms(500);
		PORTB &=  ~(1<<PB3); //PB3 = Low,Switch OFF D4
		_delay_ms(500);
	}
	
}





















