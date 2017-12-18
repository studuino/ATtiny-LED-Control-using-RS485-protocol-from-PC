#include <avr/io.h>

//+------------------------------------------------------------------------------------------------+
//|Circuit Connections                                                                             |
//|------------------------------------------------------------------------------------------------|
//|                                                                                                |
//| 		                 ATtiny2313           MAX485                                           |
//| 		              +---------------+     +--------+                                         |
//|		     +-(LED D4)---|PB3     PD0/RXD|<----|RO      |                                         |
//|          |-(LED D10)--|PB5     PD1/TXD|---->|DI     A|-----[+] A                               |   
//|          |-(LED D11)--|PB6         PD4|---->|DE     B|-----[+] B                               |
//|          +-(LED D5)---|PB4         PD3|---->|~RE     |  +--[+] GND                             |
//|          |            +--------+------+     +---+----+  |                                      |
//|          |                     |                |       |                                      |
//|          +---------------------+----------------+-------+                                      |
//|                               GND                                                              |
//|                                                                                                |
//|          <----ATtiny2313 RS485 Quad Motor Control Board----->                                  |
//|                                                                                                |
//+------------------------------------------------------------------------------------------------+
//| Hardware used - ATtiny2313 RS485 Quad Motor Control Board V1.0                                 |
//+------------------------------------------------------------------------------------------------+
//RS485 Transmit
//RS485 Receive
//RS485 Init

void RS485_init(char Baud)
{
	// Configure the Ports for Controlling MAX485 chip
	
	DDRD |= (1<<PD4) | (1<<PD3);         // PD4 and PD3 Output  
	                           // PD4 -->  DE (Driver Enable ) MAX485
                               // PD3 --> ~RE (Receive Enable) MAX485			
	
	// Configure the USART of ATtiny2313
	
	UBRRH = (uint8_t)(Baud>>8); // Set Baudrate for USART0
	UBRRL = (uint8_t)(Baud);
	
	//UCSRB |= (1<<TXEN);         // Enable the Transmitter
	UCSRC |= (3<<UCSZ0);        // data = 8 bits ,1 stop bit ,No parity 8N1				   
	
}
void RS485_Transmit_Byte(char Byte)
{
		// Put MAX485 in Transmit Mode 
		DDRD  |=  (1<<PD4) | (1<<PD3);   // PD4 and PD3 Output  
		PORTD |=  (1<<PD4);              // PD4 -->  DE,Logic High 
		PORTD |=  (1<<PD3);              // PD3 --> ~RE,Logic High 
		
		UCSRB |= (1<<TXEN);         // Enable the Transmitter
		
		//Send the byte ++
		while ( !( UCSRA & (1<<UDRE)) ); // Is TX buffer Empty
	    UDR = Byte;                      // Then send data
}

char RS485_Receive_Byte()
{

	char Rxed_Data = '0';
	
	// Put MAX485 in Receive Mode 
	DDRD  |=   (1<<PD4) | (1<<PD3);  // PD4 and PD3 Output  
	PORTD &=  ~(1<<PD4);           // PD4 -->  DE,Logic Low
	PORTD &=  ~(1<<PD3);           // PD3 --> ~RE,Logic Low
	
    
	UCSRB |= (1<<RXEN);           // Enable the Receiver
	
	while ( !( UCSRA & (1<<RXC)) ); // Is RX buffer Empty
	Rxed_Data   = UDR ;             // Read RXed data
	
	return Rxed_Data;
}

