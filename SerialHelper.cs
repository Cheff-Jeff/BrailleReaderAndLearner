using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace BrailleReader {
    public class SerialHelper {

        private SerialPort serialPort;

        public SerialHelper(String port) {
            serialPort = new SerialPort(port, 115200, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(portReceived);
        }

        public SerialHelper open() {
            serialPort.Open();
            return this;
        }

        void portReceived(object sender, SerialDataReceivedEventArgs e) {
            string data = serialPort.ReadLine();
            //TODO: Support for cool new commands.
        }

        public SerialPort getPort() {
            return serialPort;
        }

        public void resetPosition() {
            serialPort.WriteLine("000000");
        }
    }
}
