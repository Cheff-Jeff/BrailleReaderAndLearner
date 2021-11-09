using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace BrailleReader
{
    public partial class Form3 : Form
    {
        private string port;
        private SpeechHelper speechHelper;


        public Form3(String port)
        {
            InitializeComponent();
            this.port = port;
            speechHelper = new SpeechHelper();
        }


        private void alfabet_Click(object sender, EventArgs e)
        {
            if (!Mak.Checked && !Gem.Checked && !Moe.Checked)
            {
                MessageBox.Show("Selecteer een moeilijkheidsgraad");
                return;
            }

            this.Hide();
            if (Mak.Checked) new Form4(port, 26).Show();

            else if (Gem.Checked) new Form4(port, 36).Show();

            else if (Moe.Checked) new Form4(port, 64).Show();

            else
            {
                MessageBox.Show("Not yet implemented");
            }

        }

        private void Mak_CheckedChanged(object sender, EventArgs e)
        {
            speechHelper.say("Makkelijke modus");    
        }

        private void Gem_CheckedChanged(object sender, EventArgs e)
        {
            speechHelper.say("Gemiddelde modus");
        }

        private void Moe_CheckedChanged(object sender, EventArgs e)
        {
            speechHelper.say("Moeilijke modus");
        }
    }
}

