
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubSettings = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.btnConnectivity = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelSubMaintenance = new System.Windows.Forms.Panel();
            this.btnSpareParts = new System.Windows.Forms.Button();
            this.btnCorrective = new System.Windows.Forms.Button();
            this.btnPreventive = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.panelSubProcess = new System.Windows.Forms.Panel();
            this.btnLigths = new System.Windows.Forms.Button();
            this.btnMotors = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSCADA = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubSettings.SuspendLayout();
            this.panelSubMaintenance.SuspendLayout();
            this.panelSubProcess.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.panelSubSettings);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.panelSubMaintenance);
            this.panelMenu.Controls.Add(this.btnMaintenance);
            this.panelMenu.Controls.Add(this.panelSubProcess);
            this.panelMenu.Controls.Add(this.btnSCADA);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(130, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubSettings
            // 
            this.panelSubSettings.Controls.Add(this.button2);
            this.panelSubSettings.Controls.Add(this.button1);
            this.panelSubSettings.Controls.Add(this.btnControlPanel);
            this.panelSubSettings.Controls.Add(this.btnConnectivity);
            this.panelSubSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSettings.Location = new System.Drawing.Point(0, 343);
            this.panelSubSettings.Name = "panelSubSettings";
            this.panelSubSettings.Size = new System.Drawing.Size(130, 125);
            this.panelSubSettings.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(130, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Spare Parts";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Spare Parts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlPanel.FlatAppearance.BorderSize = 0;
            this.btnControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnControlPanel.Location = new System.Drawing.Point(0, 30);
            this.btnControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnControlPanel.Size = new System.Drawing.Size(130, 30);
            this.btnControlPanel.TabIndex = 2;
            this.btnControlPanel.Text = "Control Panel";
            this.btnControlPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControlPanel.UseVisualStyleBackColor = false;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            // 
            // btnConnectivity
            // 
            this.btnConnectivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnConnectivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnectivity.FlatAppearance.BorderSize = 0;
            this.btnConnectivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectivity.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConnectivity.Location = new System.Drawing.Point(0, 0);
            this.btnConnectivity.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectivity.Name = "btnConnectivity";
            this.btnConnectivity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConnectivity.Size = new System.Drawing.Size(130, 30);
            this.btnConnectivity.TabIndex = 1;
            this.btnConnectivity.Text = "Connectivity";
            this.btnConnectivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectivity.UseVisualStyleBackColor = false;
            this.btnConnectivity.Click += new System.EventHandler(this.btnConnectivity_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Location = new System.Drawing.Point(0, 313);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(130, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelSubMaintenance
            // 
            this.panelSubMaintenance.Controls.Add(this.btnSpareParts);
            this.panelSubMaintenance.Controls.Add(this.btnCorrective);
            this.panelSubMaintenance.Controls.Add(this.btnPreventive);
            this.panelSubMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMaintenance.Location = new System.Drawing.Point(0, 218);
            this.panelSubMaintenance.Name = "panelSubMaintenance";
            this.panelSubMaintenance.Size = new System.Drawing.Size(130, 95);
            this.panelSubMaintenance.TabIndex = 3;
            // 
            // btnSpareParts
            // 
            this.btnSpareParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnSpareParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpareParts.FlatAppearance.BorderSize = 0;
            this.btnSpareParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpareParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpareParts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSpareParts.Location = new System.Drawing.Point(0, 60);
            this.btnSpareParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpareParts.Name = "btnSpareParts";
            this.btnSpareParts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSpareParts.Size = new System.Drawing.Size(130, 30);
            this.btnSpareParts.TabIndex = 3;
            this.btnSpareParts.Text = "Spare Parts";
            this.btnSpareParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpareParts.UseVisualStyleBackColor = false;
            this.btnSpareParts.Click += new System.EventHandler(this.btnSpareParts_Click);
            // 
            // btnCorrective
            // 
            this.btnCorrective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnCorrective.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCorrective.FlatAppearance.BorderSize = 0;
            this.btnCorrective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrective.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrective.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCorrective.Location = new System.Drawing.Point(0, 30);
            this.btnCorrective.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorrective.Name = "btnCorrective";
            this.btnCorrective.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCorrective.Size = new System.Drawing.Size(130, 30);
            this.btnCorrective.TabIndex = 2;
            this.btnCorrective.Text = "Corrective";
            this.btnCorrective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrective.UseVisualStyleBackColor = false;
            this.btnCorrective.Click += new System.EventHandler(this.btnCorrective_Click);
            // 
            // btnPreventive
            // 
            this.btnPreventive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnPreventive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreventive.FlatAppearance.BorderSize = 0;
            this.btnPreventive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreventive.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreventive.Location = new System.Drawing.Point(0, 0);
            this.btnPreventive.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreventive.Name = "btnPreventive";
            this.btnPreventive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreventive.Size = new System.Drawing.Size(130, 30);
            this.btnPreventive.TabIndex = 1;
            this.btnPreventive.Text = "Preventive";
            this.btnPreventive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreventive.UseVisualStyleBackColor = false;
            this.btnPreventive.Click += new System.EventHandler(this.btnPreventive_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 188);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(130, 30);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // panelSubProcess
            // 
            this.panelSubProcess.Controls.Add(this.btnLigths);
            this.panelSubProcess.Controls.Add(this.btnMotors);
            this.panelSubProcess.Controls.Add(this.btnProcess);
            this.panelSubProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProcess.Location = new System.Drawing.Point(0, 93);
            this.panelSubProcess.Name = "panelSubProcess";
            this.panelSubProcess.Size = new System.Drawing.Size(130, 95);
            this.panelSubProcess.TabIndex = 1;
            // 
            // btnLigths
            // 
            this.btnLigths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnLigths.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLigths.FlatAppearance.BorderSize = 0;
            this.btnLigths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigths.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLigths.Location = new System.Drawing.Point(0, 60);
            this.btnLigths.Margin = new System.Windows.Forms.Padding(4);
            this.btnLigths.Name = "btnLigths";
            this.btnLigths.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLigths.Size = new System.Drawing.Size(130, 30);
            this.btnLigths.TabIndex = 3;
            this.btnLigths.Text = "Lights";
            this.btnLigths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLigths.UseVisualStyleBackColor = false;
            this.btnLigths.Click += new System.EventHandler(this.btnLigths_Click);
            // 
            // btnMotors
            // 
            this.btnMotors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnMotors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotors.FlatAppearance.BorderSize = 0;
            this.btnMotors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotors.Location = new System.Drawing.Point(0, 30);
            this.btnMotors.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotors.Name = "btnMotors";
            this.btnMotors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMotors.Size = new System.Drawing.Size(130, 30);
            this.btnMotors.TabIndex = 2;
            this.btnMotors.Text = "Motors";
            this.btnMotors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotors.UseVisualStyleBackColor = false;
            this.btnMotors.Click += new System.EventHandler(this.btnMotors_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProcess.Location = new System.Drawing.Point(0, 0);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcess.Size = new System.Drawing.Size(130, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSCADA
            // 
            this.btnSCADA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.btnSCADA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSCADA.FlatAppearance.BorderSize = 0;
            this.btnSCADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCADA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSCADA.Location = new System.Drawing.Point(0, 63);
            this.btnSCADA.Margin = new System.Windows.Forms.Padding(4);
            this.btnSCADA.Name = "btnSCADA";
            this.btnSCADA.Size = new System.Drawing.Size(130, 30);
            this.btnSCADA.TabIndex = 0;
            this.btnSCADA.Text = "SCADA";
            this.btnSCADA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSCADA.UseVisualStyleBackColor = false;
            this.btnSCADA.Click += new System.EventHandler(this.btnSCADA_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(130, 63);
            this.panelHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(130, 531);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(878, 30);
            this.panelStatus.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(130, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(100, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(878, 531);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(244, 93);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(50, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SCADAv1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubSettings.ResumeLayout(false);
            this.panelSubMaintenance.ResumeLayout(false);
            this.panelSubProcess.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSCADA;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelSubProcess;
        private System.Windows.Forms.Button btnLigths;
        private System.Windows.Forms.Button btnMotors;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panelSubSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.Button btnConnectivity;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelSubMaintenance;
        private System.Windows.Forms.Button btnSpareParts;
        private System.Windows.Forms.Button btnCorrective;
        private System.Windows.Forms.Button btnPreventive;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

