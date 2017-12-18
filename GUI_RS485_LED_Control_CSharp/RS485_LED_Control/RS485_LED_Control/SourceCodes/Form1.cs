//=======================================================================================================================//
// C# GUI Program For Controlling LED's on ATTiny RS485 Quad Motor control Board                                         //
//=======================================================================================================================//
// Description                                                                                                           //
//=======================================================================================================================//
// C# runs on the PC side and communicates with the "ATtiny RS485 Quad Motor Control Board" using RS485 Protocol.        // 
// Transmits characters to ATtiny Board to control the LED's.                                                            //        
//=======================================================================================================================//
// RS485 Communication Parameters                                                                                        //
//=======================================================================================================================//
// Baudrate  = 4800bps                                                                                                   //
// Data bits = 8                                                                                                         //
// Stopbits  = 1                                                                                                         //
//=======================================================================================================================//
// Connection Diagram                                                                                                    //
//=======================================================================================================================//
//                                                                ATtiny RS485 Quad Motor Control Board V1.0             //
//                                                                +-----------------------------------+                  //               
//  |-------------|                                               |              +-------+   +-----+  |                  //
//  | RS485 Motor |                                               |              |       |==>|L293D|  |P6]==>(Motor1)    //
//  | Control.exe |             USB2SERIAL V2.0                   |    +------+  | ATtiny|   +-----+  |                  //
//  |-------------|            +--------------+                   |    |MAX485|->| 2313  |            |P7]==>(Motor2)    //
//   \ [][][][][] \============| USB -> RS485 |~~~~~~~~~~~~~~~~~~~|A,B |      |<-|       |   +-----+  |                  //
//    \------------\     USB   +--------------+      Twisted      |    +------+  |       |==>|L293D|  |P4]==>(Motor3)    //
//        Laptop                                      Pair        |              |       |   +-----+  |                  //
//                                                                |              +-------+            |P5]==>(Motor4)    //
//                              			                      +-----------------------------------+                  //
//                                                                                                                       //
//      [Transmitter]--------------------------------------------> [<-----------Receiver-------------->]                 //
//                                                                                                                       //
//=======================================================================================================================//
// Software                                                                                                              //
//=======================================================================================================================//
// Compiler/IDE  :	Microsoft Visual Studio Express 2013 for Windows Desktop(Version 12.0)                               //
//               :  SharpDevelop                                                                                         //
//                                                                                                                       //
// Library       :  .NET Framework                                                                                       //
// Commands      :                                                                                                       //
// OS            :	Windows(Windows 7)/Linux                                                                             //
// Programmer    :	Rahul.S                                                                                              //
// Date	         :	26-Oct-2017                                                                                          //
//=======================================================================================================================//
// www.xanthium.in										                                                                 //
// Copyright (C) 2017 Rahul.S                                                                                            //
//=======================================================================================================================//



using System;
using System.Windows.Forms;

using System.IO.Ports;
using RS485Communication; //Used for Accessing RS485Port Class

namespace RS485_LED_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Populate the Combobox with SerialPorts on the System
            ComboBox_ComPort_Selection.Items.AddRange(SerialPort.GetPortNames());

            // Disable Baudrate Selection also
            ComboBox_BaudRate_Sellection.Enabled = false;

            // Disable LED Control Group box 
            GroupBox_LED_Control.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Will run, when user selects a serialport using Drop Down Menu
        private void ComboBox_ComPort_Selection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Enable Baudrate Selection also
            ComboBox_BaudRate_Sellection.Enabled = true;
        }

        private void ComboBox_BaudRate_Sellection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Enable LED Control Group box 
            GroupBox_LED_Control.Enabled = true;
        }

        private void Button_LED_Control_D4_Click(object sender, EventArgs e)
        {
            RS485Port_TransmitChar("A");

        }

        // Method for intializing the RS485 Port and sending a Custom Character

        private void RS485Port_TransmitChar(String data)
        {
            String RS485PortNumber;
            int RS485_Baudrate;

            RS485PortNumber = ComboBox_ComPort_Selection.SelectedItem.ToString();

            RS485_Baudrate = Convert.ToInt32(ComboBox_BaudRate_Sellection.SelectedItem);

            RS485Port RP1 = new RS485Port(RS485PortNumber, RS485_Baudrate);

            RP1.Write(data);
        }

        //LED D5 Control
        private void Button_LED_Control_D5_Click(object sender, EventArgs e)
        {
            RS485Port_TransmitChar("B");
        }

        //LED D2 Control
        private void Button_LED_Control_D2_Click(object sender, EventArgs e)
        {
            RS485Port_TransmitChar("C");
        }

        //LED D3 Control
        private void Button_LED_Control_D3_Click(object sender, EventArgs e)
        {
            RS485Port_TransmitChar("D");
        }

        //All LED's OFF
        private void Button_LED_OFF_Click(object sender, EventArgs e)
        {
            RS485Port_TransmitChar("X");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xanthium.in/");
        }

        //Help
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Message;
            Message = "Program to Control the LED's on ATtiny RS485 Quad Motor Control Development Board";
            MessageBox.Show(Message);
        }
    }
}
