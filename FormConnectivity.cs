using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADAv1_0
{
    public partial class FormConnectivity : Form
    {
        public static FormConnectivity instance;
        private string[] serialConfig = new string[5];
        public FormConnectivity()
        {
            InitializeComponent();
            instance = this;
        }

        private void FormConnectivity_Load(object sender, EventArgs e)
        {

            cboxPORTCOM.Items.AddRange(Form1.instance.getPortNames());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serialConfig[0] = cboxPORTCOM.Text;
            serialConfig[1] = cboxBAUD.Text;
            serialConfig[2] = cboxDataBits.Text;
            serialConfig[3] = cboxParity.Text;
            if (rbtnSB1.Checked)
                serialConfig[4] = "One";
            else if (rbtnSB2.Checked)
                serialConfig[4] = "Two";

            Form1.instance.openSerialCOM(serialConfig); // Open SerialCommunication
        }

        public String getSerialConfig()
        {
            String spc = "";
            foreach (String i in serialConfig)
            {
                spc = spc + i + ",";
            }
            spc = spc.Remove(spc.Length - 1);
            return spc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Mbtn = MessageBox.Show("Changes will be discarded","Alert",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Warning);

            if (Mbtn == DialogResult.OK)
                this.Close();
                Form1.instance.closeSERIALCOM(); //Close serial communication
            //this.Close();
        }
    }
}