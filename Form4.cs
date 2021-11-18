using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BrailleReader
{
    public partial class Form4 : Form
    {
        
        private SerialHelper serialHelper;
        private SpeechHelper speechHelper;
        private String port;
        private int maxIndex;

        public Form4(string port, int maxIndex)
        { 
            InitializeComponent();

            this.port = port;
            this.maxIndex = maxIndex;
            speechHelper = new SpeechHelper();
            serialHelper = new SerialHelper(port).open();
        }

        private void Alfabet_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialHelper.getPort().Close();
            this.Hide();
            Form3 f3 = new Form3(port); 
            f3.ShowDialog();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            while (true)
            {
                DateTime start = DateTime.Now;
                DateTime finish = start.AddSeconds(3);
                do { } while (DateTime.Now < finish);
                var keys = new List<char>(BrailleHelper.letterToBinary.Keys);
                Random random = new Random();
                char randomChar = keys[random.Next(0, maxIndex)];
                Console.WriteLine("Random char: " + randomChar);
                Console.WriteLine("Sending: " + BrailleHelper.letterToBinary.GetValueOrDefault(randomChar, "poep"));
                serialHelper.getPort().WriteLine(BrailleHelper.letterToBinary.GetValueOrDefault(randomChar, "poep"));
                Alfabet.Text = Convert.ToString(randomChar);
                speechHelper.say(Alfabet.Text);

            }
        }
      
    }
}
