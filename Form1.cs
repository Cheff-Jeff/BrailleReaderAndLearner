using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace BrailleReader {
    public partial class SelectComForm : Form {

        private SpeechHelper speechHelper;
        public SelectComForm() {
            InitializeComponent();

            getAndSetPorts();

            speechHelper = new SpeechHelper();
        }

        public void getAndSetPorts() {
            ports.Items.Clear();
            foreach(string port in SerialPort.GetPortNames()) {
                ports.Items.Add(port);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e) {
            getAndSetPorts();
        }

        private void selectBtn_Click(object sender, EventArgs e) {
            if (!learnerBtn.Checked && !readerBtn.Checked) {
                MessageBox.Show("Selecteer een modus");
                return;
            }
            if (ports.SelectedItems.Count == 0) {
                MessageBox.Show("Selecteer een Braille Reader");
                return;
            }
            if (readerBtn.Checked) {
                string selectedPort = ports.SelectedItems[0].Text;
                this.Hide();
                new Form2(selectedPort).Show();
            } else {
                MessageBox.Show("Not yet implemented");
            }
            
       
            // TODO: Constructor with the port
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) {
            learnerBtn.Checked = !readerBtn.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            readerBtn.Checked = !learnerBtn.Checked;
        }

        private void refreshBtn_MouseEnter(object sender, EventArgs e) {
            speechHelper.say("Ververs");
        }

        private void selectBtn_MouseEnter(object sender, EventArgs e) {
            speechHelper.say("Selecteren");
        }

        private void learnerBtn_MouseEnter(object sender, EventArgs e) {
            speechHelper.say("Leer modus");
        }

        private void readerBtn_MouseEnter(object sender, EventArgs e) {
            speechHelper.say("Reader modus");
        }

        private void ports_MouseEnter(object sender, EventArgs e) {
            speechHelper.say("Selecteer hier een poort");
        }

        private void ports_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e) {
            speechHelper.say(e.Item.Text);
        }

        private void ports_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            speechHelper.say(e.Item.Text + " geselecteerd");
        }
    }
}
