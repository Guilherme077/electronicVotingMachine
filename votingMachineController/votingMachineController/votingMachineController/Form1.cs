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
                    tbConsole.AppendText("[Controller] Error: The " + cbSelectCOM.Items[cbSelectCOM.SelectedIndex].ToString() + " port is not availble \n");
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btnConnect.Text = "Disconnect";
                    btnSendMessage.Enabled = true;
                    Form1.ActiveForm.Text = "Voting Machine Controller - Conected";
                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    btnSendMessage.Enabled = false;
                    Form1.ActiveForm.Text = "Voting Machine Controller - Disconected";
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

        private void tbConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmVoter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Voting Machine will show the vote options. The voter will not be able to vote again in this voting process! Once started, this action cannot be canceled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnStartVoting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Voting Process is being started. If the voting process stop for any reason, the results will be erased from the voting machine unless other Voting Process start with the same Voting Process Code (VPC). Store the VPC in a safe place, no one can continue the Voting Process without the VPC! The VPC will be showed after this message. (function not implemented yet)", "VPC Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           

        }
    }
}
