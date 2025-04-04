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
        public Form1()
        {
            InitializeComponent();
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
            //seleciona a primeira posição da lista
            cbSelectCOM.SelectedIndex = 0;
        }
    }
}
