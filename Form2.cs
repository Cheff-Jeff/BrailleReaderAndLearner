using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrailleReader {
    public partial class Form2 : Form {

        private SerialHelper serialHelper;

        public Form2(String port) {
            InitializeComponent();

            serialHelper = new SerialHelper(port).open();
        }

        private void readerBtn_Click(object sender, EventArgs e) {
            string text = input.Text.ToUpper();
            char[] textSplit = text.ToCharArray();
            foreach (char letter in textSplit) {
                string binary = BrailleHelper.letterToBinary.GetValueOrDefault(letter, "poep");
                Console.WriteLine(binary);
                serialHelper.getPort().WriteLine(binary);
                Thread.Sleep(1000);
            }
            serialHelper.resetPosition();
        }
    }
}
