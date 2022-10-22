using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SCADAv1_0
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        private Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            instance = this;
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void customizeDesign()
        {
            panelSubProcess.Visible = false;
            panelSubMaintenance.Visible = false;
            panelSubSettings.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubProcess.Visible == true)
                panelSubProcess.Visible = false;
            if (panelSubMaintenance.Visible == true)
                panelSubMaintenance.Visible = false;
            if (panelSubSettings.Visible == true)
                panelSubSettings.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region SCADA
        private void btnSCADA_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProcess);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMotors_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLigths_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region Maintenance
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMaintenance);
        }
        private void btnPreventive_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnCorrective_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnSpareParts_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSettings);
        }
        private void btnConnectivity_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConnectivity());
            hideSubMenu();
        }
        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        #region SERIALPORTSETTINGS
        public string[] getPortNames()
        {
            string [] damepuertos = SerialPort.GetPortNames();
            return SerialPort.GetPortNames();
        }

        public void openSerialCOM(string[] str)
        {
            try
            {
                serialPort1.PortName = str[0];
                serialPort1.BaudRate = Convert.ToInt32(str[1]);
                serialPort1.DataBits = Convert.ToInt32(str[2]);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), str[3]);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), str[4]);
                serialPort1.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void closeSERIALCOM()
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
        #endregion
    }
}
