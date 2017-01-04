using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArmControllerV1
{
    class Arduino
    {
        public SerialPort _SerialPort { get; set; }
        public Arduino()
        {

        }
        public string[] getPotData()
        {
            string dataReceived;
            if (_SerialPort.IsOpen)
            {
                dataReceived = _SerialPort.ReadTo("h");
                string pot1pos = dataReceived.Substring(dataReceived.IndexOf('a') + 1, dataReceived.IndexOf('b') - dataReceived.IndexOf('a') - 1);
                string pot2pos = dataReceived.Substring(dataReceived.IndexOf('b') + 1, dataReceived.IndexOf('c') - dataReceived.IndexOf('b') - 1);
                string pot3pos = dataReceived.Substring(dataReceived.IndexOf('c') + 1, dataReceived.IndexOf('d') - dataReceived.IndexOf('c') - 1);
                string pot4pos = dataReceived.Substring(dataReceived.IndexOf('d') + 1, dataReceived.IndexOf('e') - dataReceived.IndexOf('d') - 1);
                string pot5pos = dataReceived.Substring(dataReceived.IndexOf('e') + 1, dataReceived.IndexOf('f') - dataReceived.IndexOf('e') - 1);
                string pot6pos = dataReceived.Substring(dataReceived.IndexOf('f') + 1, dataReceived.IndexOf('g') - dataReceived.IndexOf('f') - 1);
                return new string[] { pot1pos, pot2pos, pot3pos, pot4pos, pot5pos, pot6pos };
            }
            else
            {
                Console.WriteLine("Serial Port Closed");
                return new string[] { "0", "0", "0", "0", "0", "0" };
            }

        }
        public void sendData(bool[] dataToBeSent)
        {                      
            char[] dataOut = {'y', '0', '0', '0', 'z' };//plow, masterslave, laser
             for(int i = 0; i < dataOut.Length-2; i++)
            {
                if (dataToBeSent[i])
                {
                    dataOut[i + 1] = '1';
                }else
                {
                    dataOut[i + 1] = '0';
                }
            }
            String dataOutString = new string(dataOut);
            Console.WriteLine(dataOutString);
            if (_SerialPort.IsOpen)
            {
                _SerialPort.WriteLine(dataOutString);
            }else
            {
                Console.WriteLine("Serial Port Closed");
            }
        }
    }
}
