//=======================================================================================================================//
// Class File for creating a RS485 Port  (V1.1)                                                                                //
//=======================================================================================================================//
// Compiler/IDE  :	Microsoft Visual Studio Express 2013 for Windows Desktop(Version 12.0)                               //
//               :  SharpDevelop                                                                                         //
//                                                                                                                       //
// Library       :  .NET Framework                                                                                       //
// Commands      :                                                                                                       //
// OS            :	Windows(Windows 7)/Linux                                                                             //
// Programmer    :	Rahul.S                                                                                              //
// Date	         :	14-October-2017                                                                                          //
//=======================================================================================================================//
// www.xanthium.in										                                                                 //
// Copyright (C) 2017 Rahul.S                                                                                            //
//=======================================================================================================================//

using System;
using System.IO.Ports;

/// <summary>
///  RS485 PortClass can be used for genearting an RS485Port object which can then be used for communicating with RS485 enabled devices.
///  A Hardware USB to RS485 converter like USB2SERIAL v2.0 is required.
/// </summary>

namespace RS485Communication
{
    public class RS485Port
    {
        #region Private_Variables

        private int    baudrate; // used for storing baudrate,only standard values are allowed
        private int    databits; // used for storing databits,only 8,9 bits allowed
        private int    stopbits; // used for storing  stopbits,only 1,2 bits allowed
        private string parity;   // used for storing Parity information in text,not used for setting port,
        private int    _parity;  // used for storing Parity int format,used for setting the port

        #endregion


        #region Public_Variables_Properties

        public string PortName; // used for storing Port name ,COMxx or USBttyx

        public int BaudRate
        {
            get
            {
                return baudrate;
            }
            set  
            {
                switch(value)   // only standard values are allowed ,default 9600
                {
                    case 1200:  baudrate = 1200;
                                break;
                    case 2400:  baudrate = 2400;
                                break;
                    case 4800:  baudrate = 4800;
                                break;
                    case 9600:  baudrate = 9600;
                                break;
                    case 19200: baudrate = 19200;
                                break;
                    case 38400: baudrate = 38400;
                                break;
                    default:    baudrate = 9600;
                                break;
                }
            }
        }

        public int DataBits
        {
            get
            {
                return databits;
            }
            set
            {
                switch (value)
                {
                    case 8:  databits = 8;
                             break;
                    case 9:  databits = 8;
                             break;
                    default: databits = 8;
                             break;
                }
            }
        }

        public int StopBits
        {
            get
            {
                return stopbits;
            }
            set
            {
                switch (value)
                {
                    case 1:  stopbits = 1;
                             break;

                    case 2:  stopbits = 2;
                             break;
                  
                    default: stopbits = 1;
                             break;
                        
                }
            }
        }

        public string Parity
        {
            get
            {
                return parity;
            }

            set
            {
                switch(value)
                {
                    case "ODD": parity  = "ODD"; // used for information to user 
                                _parity = 1;     // used to set the ports
                                 break;

                    case "EVEN": parity = "EVEN";
                                 _parity = 2;
                                 break;

                    case "NONE": parity = "NONE";
                                 _parity = 0;
                                 break;

                    default:    parity = "NONE";
                                _parity = 0;
                                break;
                }
            }
        }

        #endregion


        #region  Constructors

        public RS485Port()
        {
            BaudRate = 9600;
            DataBits = 8;
            Parity   = "NONE";
            StopBits = 1;
        }

        public RS485Port(string portname,int baudrate)
        {
            PortName = portname;
            BaudRate = baudrate;

            DataBits = 8;
            Parity   = "NONE";
            StopBits = 1;
        }

        public RS485Port(string portname, int baudrate,int databits,string parity,int stopbits)
        {
            PortName = portname;
            BaudRate = baudrate;

            DataBits = databits;
            Parity   = parity;
            StopBits = stopbits;
        }

        #endregion

        #region Methods

        public bool Write(string data)
        {
            #region Setting_up_SerialPort
            SerialPort _SerialPort = new SerialPort();
            _SerialPort.PortName = PortName;
            _SerialPort.BaudRate = baudrate;
            _SerialPort.DataBits = databits;
            _SerialPort.Parity   = (System.IO.Ports.Parity)_parity;
            #endregion

            #region Opening_Serial_Port
            try
            {
                _SerialPort.Open();
                
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            #endregion

            #region Putting_USB2SERIAL_WriteMode
            // Here Hardware used is USB2SERIAL (USB to RS485 Converter)
            _SerialPort.DtrEnable = false;            // Since DTR = 0.~DTR = 1 So  DE = 1 Transmit Mode enabled
            _SerialPort.RtsEnable = false;            // Since RTS = 0,~RTS = 1 So ~RE = 1
            #endregion

            _SerialPort.Write(data);                  // Write  data to opened serial port

            _SerialPort.Close();                      // Close the Serial port
            

            return true;
        }

        public string Read()
        {
            string ReceivedData = "-Empty-";

            #region Setting_up_SerialPort
            SerialPort _SerialPort = new SerialPort();
            _SerialPort.PortName = PortName;
            _SerialPort.BaudRate = baudrate;
            _SerialPort.DataBits = databits;
            _SerialPort.Parity = (System.IO.Ports.Parity)_parity;
            #endregion

            #region Opening_Serial_Port
            try
            {
                _SerialPort.Open();

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.ToString());
                
            }
            #endregion

            #region Putting_USB2SERIAL_ReadMode
            // Here Hardware used is USB2SERIAL (USB to RS485 Converter)
            _SerialPort.RtsEnable = true;            // Since RTS = 1, ~RTS = 0 So ~RE = 0 Receive  Mode enabled
            _SerialPort.DtrEnable = true;            // Since DTR = 1. ~DTR = 0 So  DE = 0 
                                                     //~RE and DE LED's on USB2SERIAL board will be off
            #endregion

            #region SettingTimeouts

            _SerialPort.ReadTimeout = 3500; //Setting ReadTimeout =3500 ms or 3.5 seconds
            
            #endregion

            ReceivedData = _SerialPort.ReadLine();   // Wait for data reception.
                                                     // Requires "\n" at the end of transmitted string

            //ReceivedData = _SerialPort.Read();     // Wait for data reception

            _SerialPort.Close();                      // Close the Serial port

            return ReceivedData;
        }

        #endregion



    }
}
