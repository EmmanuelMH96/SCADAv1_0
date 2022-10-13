
namespace SCADAv1_0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnSCADA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subMenuPROCESS = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnMotors = new System.Windows.Forms.Button();
            this.btnLigths = new System.Windows.Forms.Button();
            this.subPanelMaintenance = new System.Windows.Forms.Panel();
            this.btnSpareParts = new System.Windows.Forms.Button();
            this.btnCorrective = new System.Windows.Forms.Button();
            this.btnPreventive = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.subPanelSettings = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.btnConnectivity = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu.SuspendLayout();
            this.subMenuPROCESS.SuspendLayout();
            this.subPanelMaintenance.SuspendLayout();
            this.subPanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.subPanelSettings);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.subPanelMaintenance);
            this.panelMenu.Controls.Add(this.btnMaintenance);
            this.panelMenu.Controls.Add(this.subMenuPROCESS);
            this.panelMenu.Controls.Add(this.btnSCADA);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(150, 63);
            this.panelHome.TabIndex = 0;
            // 
            // btnSCADA
            // 
            this.btnSCADA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnSCADA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSCADA.FlatAppearance.BorderSize = 0;
            this.btnSCADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCADA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSCADA.Location = new System.Drawing.Point(0, 63);
            this.btnSCADA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSCADA.Name = "btnSCADA";
            this.btnSCADA.Size = new System.Drawing.Size(150, 30);
            this.btnSCADA.TabIndex = 0;
            this.btnSCADA.Text = "SCADA";
            this.btnSCADA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSCADA.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(150, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 20);
            this.panel1.TabIndex = 1;
            // 
            // subMenuPROCESS
            // 
            this.subMenuPROCESS.Controls.Add(this.btnLigths);
            this.subMenuPROCESS.Controls.Add(this.btnMotors);
            this.subMenuPROCESS.Controls.Add(this.btnProcess);
            this.subMenuPROCESS.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuPROCESS.Location = new System.Drawing.Point(0, 93);
            this.subMenuPROCESS.Name = "subMenuPROCESS";
            this.subMenuPROCESS.Size = new System.Drawing.Size(150, 95);
            this.subMenuPROCESS.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProcess.Location = new System.Drawing.Point(0, 0);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcess.Size = new System.Drawing.Size(150, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // btnMotors
            // 
            this.btnMotors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMotors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotors.FlatAppearance.BorderSize = 0;
            this.btnMotors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotors.Location = new System.Drawing.Point(0, 30);
            this.btnMotors.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotors.Name = "btnMotors";
            this.btnMotors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMotors.Size = new System.Drawing.Size(150, 30);
            this.btnMotors.TabIndex = 2;
            this.btnMotors.Text = "Motors";
            this.btnMotors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotors.UseVisualStyleBackColor = false;
            // 
            // btnLigths
            // 
            this.btnLigths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLigths.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLigths.FlatAppearance.BorderSize = 0;
            this.btnLigths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigths.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLigths.Location = new System.Drawing.Point(0, 60);
            this.btnLigths.Margin = new System.Windows.Forms.Padding(4);
            this.btnLigths.Name = "btnLigths";
            this.btnLigths.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLigths.Size = new System.Drawing.Size(150, 30);
            this.btnLigths.TabIndex = 3;
            this.btnLigths.Text = "Lights";
            this.btnLigths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLigths.UseVisualStyleBackColor = false;
            // 
            // subPanelMaintenance
            // 
            this.subPanelMaintenance.Controls.Add(this.btnSpareParts);
            this.subPanelMaintenance.Controls.Add(this.btnCorrective);
            this.subPanelMaintenance.Controls.Add(this.btnPreventive);
            this.subPanelMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelMaintenance.Location = new System.Drawing.Point(0, 218);
            this.subPanelMaintenance.Name = "subPanelMaintenance";
            this.subPanelMaintenance.Size = new System.Drawing.Size(150, 95);
            this.subPanelMaintenance.TabIndex = 3;
            // 
            // btnSpareParts
            // 
            this.btnSpareParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSpareParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpareParts.FlatAppearance.BorderSize = 0;
            this.btnSpareParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpareParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpareParts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSpareParts.Location = new System.Drawing.Point(0, 60);
            this.btnSpareParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpareParts.Name = "btnSpareParts";
            this.btnSpareParts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSpareParts.Size = new System.Drawing.Size(150, 30);
            this.btnSpareParts.TabIndex = 3;
            this.btnSpareParts.Text = "Spare Parts";
            this.btnSpareParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareParts.UseVisualStyleBackColor = false;
            // 
            // btnCorrective
            // 
            this.btnCorrective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCorrective.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCorrective.FlatAppearance.BorderSize = 0;
            this.btnCorrective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrective.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrective.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCorrective.Location = new System.Drawing.Point(0, 30);
            this.btnCorrective.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorrective.Name = "btnCorrective";
            this.btnCorrective.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCorrective.Size = new System.Drawing.Size(150, 30);
            this.btnCorrective.TabIndex = 2;
            this.btnCorrective.Text = "Corrective";
            this.btnCorrective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrective.UseVisualStyleBackColor = false;
            // 
            // btnPreventive
            // 
            this.btnPreventive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPreventive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreventive.FlatAppearance.BorderSize = 0;
            this.btnPreventive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreventive.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreventive.Location = new System.Drawing.Point(0, 0);
            this.btnPreventive.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreventive.Name = "btnPreventive";
            this.btnPreventive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreventive.Size = new System.Drawing.Size(150, 30);
            this.btnPreventive.TabIndex = 1;
            this.btnPreventive.Text = "Preventive";
            this.btnPreventive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreventive.UseVisualStyleBackColor = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 188);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(150, 30);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // subPanelSettings
            // 
            this.subPanelSettings.Controls.Add(this.button2);
            this.subPanelSettings.Controls.Add(this.button1);
            this.subPanelSettings.Controls.Add(this.btnControlPanel);
            this.subPanelSettings.Controls.Add(this.btnConnectivity);
            this.subPanelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelSettings.Location = new System.Drawing.Point(0, 343);
            this.subPanelSettings.Name = "subPanelSettings";
            this.subPanelSettings.Size = new System.Drawing.Size(150, 125);
            this.subPanelSettings.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Spare Parts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlPanel.FlatAppearance.BorderSize = 0;
            this.btnControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnControlPanel.Location = new System.Drawing.Point(0, 30);
            this.btnControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnControlPanel.Size = new System.Drawing.Size(150, 30);
            this.btnControlPanel.TabIndex = 2;
            this.btnControlPanel.Text = "Control Panel";
            this.btnControlPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControlPanel.UseVisualStyleBackColor = false;
            // 
            // btnConnectivity
            // 
            this.btnConnectivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConnectivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnectivity.FlatAppearance.BorderSize = 0;
            this.btnConnectivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectivity.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConnectivity.Location = new System.Drawing.Point(0, 0);
            this.btnConnectivity.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectivity.Name = "btnConnectivity";
            this.btnConnectivity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConnectivity.Size = new System.Drawing.Size(150, 30);
            this.btnConnectivity.TabIndex = 1;
            this.btnConnectivity.Text = "Connectivity";
            this.btnConnectivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectivity.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Location = new System.Drawing.Point(0, 313);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Spare Parts";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.subMenuPROCESS.ResumeLayout(false);
            this.subPanelMaintenance.ResumeLayout(false);
            this.subPanelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSCADA;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel subMenuPROCESS;
        private System.Windows.Forms.Button btnLigths;
        private System.Windows.Forms.Button btnMotors;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel subPanelSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.Button btnConnectivity;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel subPanelMaintenance;
        private System.Windows.Forms.Button btnSpareParts;
        private System.Windows.Forms.Button btnCorrective;
        private System.Windows.Forms.Button btnPreventive;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

