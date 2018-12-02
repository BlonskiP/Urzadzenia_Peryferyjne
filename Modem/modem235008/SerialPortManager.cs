using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace modem235008
{
    class SerialPortManager
    {
        SerialPort _serialPort;
        Thread reader; 
        public SerialPortManager()
        {
        }
        public void Connect(string COM) //example : COM1
        {
            Console.WriteLine(COM);
            if(_serialPort!=null)
            if (_serialPort.IsOpen) _serialPort.Close();
            _serialPort = new SerialPort(COM);
            if (_serialPort != null)
                _serialPort.Open();
            if(_serialPort.IsOpen)
            {
                _serialPort.DtrEnable = true;
                _serialPort.Handshake = Handshake.RequestToSend;
                Console.WriteLine(_serialPort.PortName);
                Console.WriteLine(_serialPort.BaudRate);
                Console.WriteLine(_serialPort.Parity);
                Console.WriteLine(_serialPort.DataBits);
                Console.WriteLine(_serialPort.StopBits);
                Console.WriteLine(_serialPort.Handshake);
               
                Console.WriteLine(_serialPort.DtrEnable);
                reader = new Thread(Read);
                reader.Start();
            }
        }
        public List<String> GetCOM()
        {
            List<String>ComList = new List<String>();
            foreach(string s in SerialPort.GetPortNames())
            {
                ComList.Add(s);
            }
            ComList.Sort();
            return ComList;
        }

        public void SendMessage(string message)
        {
            if (_serialPort != null)
                _serialPort.Write(message);
            else
                Console.WriteLine("ERROR !! CONNECT TO SERIAL PORT");
        }
        private void Read()
        {
            while(_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    Console.Write(message);
                }
                catch(TimeoutException){}
            }
        }

       public void SendFile(string filePath)
        {
            Console.WriteLine("PATH: " + filePath);
           if(_serialPort.IsOpen)
           {
               using (FileStream fs = File.OpenRead(filePath))
               {
                   _serialPort.Write((new BinaryReader(fs)).ReadBytes
                       ((int)fs.Length), 0, (int)fs.Length);
               }

           }
        }
    }
}
