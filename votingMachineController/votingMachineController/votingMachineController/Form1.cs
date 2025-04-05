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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace votingMachineController
{
    public partial class Form1 : Form
    {
        string RxString;
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
            btnSendMessage.Enabled = false;
        }

        private void UpdateCOMList()
        {
            int i = 0;
            bool changed = false;

            if (cbSelectCOM.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbSelectCOM.Items[i++].Equals(s) == false)
                    {
                        changed = true;
                    }
                }
            }
            else
            {
                changed = true;
            }

            if (!changed)
            {
                return;
            }

            cbSelectCOM.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cbSelectCOM.Items.Add(s);
            }
            cbSelectCOM.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            UpdateCOMList();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = cbSelectCOM.Items[cbSelectCOM.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    btnSendMessage.Enabled = true;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    btnSendMessage.Enabled = false;
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Write(tbSendMessage.Text);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(trataDadoRecebido));
        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            tbConsole.AppendText(RxString);
        }
    }
}
