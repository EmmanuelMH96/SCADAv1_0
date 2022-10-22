
namespace SCADAv1_0
{
    partial class FormConnectivity
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
            this.groupBoxSerial = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnSB2 = new System.Windows.Forms.RadioButton();
            this.rbtnSB1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxBAUD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxPORTCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSerial
            // 
            this.groupBoxSerial.Controls.Add(this.btnCancel);
            this.groupBoxSerial.Controls.Add(this.btnSave);
            this.groupBoxSerial.Controls.Add(this.cboxParity);
            this.groupBoxSerial.Controls.Add(this.label5);
            this.groupBoxSerial.Controls.Add(this.rbtnSB2);
            this.groupBoxSerial.Controls.Add(this.rbtnSB1);
            this.groupBoxSerial.Controls.Add(this.label4);
            this.groupBoxSerial.Controls.Add(this.cboxDataBits);
            this.groupBoxSerial.Controls.Add(this.label3);
            this.groupBoxSerial.Controls.Add(this.cboxBAUD);
            this.groupBoxSerial.Controls.Add(this.label2);
            this.groupBoxSerial.Controls.Add(this.cboxPORTCOM);
            this.groupBoxSerial.Controls.Add(this.label1);
            this.groupBoxSerial.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxSerial.Location = new System.Drawing.Point(16, 15);
            this.groupBoxSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSerial.Name = "groupBoxSerial";
            this.groupBoxSerial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSerial.Size = new System.Drawing.Size(283, 318);
            this.groupBoxSerial.TabIndex = 0;
            this.groupBoxSerial.TabStop = false;
            this.groupBoxSerial.Text = "Serial Port";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(156, 208);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(28, 208);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Accept";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboxParity
            // 
            this.cboxParity.FormattingEnabled = true;
            this.cboxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cboxParity.Location = new System.Drawing.Point(112, 126);
            this.cboxParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxParity.Name = "cboxParity";
            this.cboxParity.Size = new System.Drawing.Size(160, 24);
            this.cboxParity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "PARITY BIT:";
            // 
            // rbtnSB2
            // 
            this.rbtnSB2.AutoSize = true;
            this.rbtnSB2.Checked = true;
            this.rbtnSB2.Location = new System.Drawing.Point(203, 162);
            this.rbtnSB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSB2.Name = "rbtnSB2";
            this.rbtnSB2.Size = new System.Drawing.Size(37, 21);
            this.rbtnSB2.TabIndex = 10;
            this.rbtnSB2.TabStop = true;
            this.rbtnSB2.Text = "2";
            this.rbtnSB2.UseVisualStyleBackColor = true;
            // 
            // rbtnSB1
            // 
            this.rbtnSB1.AutoSize = true;
            this.rbtnSB1.Location = new System.Drawing.Point(129, 162);
            this.rbtnSB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSB1.Name = "rbtnSB1";
            this.rbtnSB1.Size = new System.Drawing.Size(37, 21);
            this.rbtnSB1.TabIndex = 9;
            this.rbtnSB1.Text = "1";
            this.rbtnSB1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "STOP BITS:";
            // 
            // cboxDataBits
            // 
            this.cboxDataBits.FormattingEnabled = true;
            this.cboxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboxDataBits.Location = new System.Drawing.Point(112, 92);
            this.cboxDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxDataBits.Name = "cboxDataBits";
            this.cboxDataBits.Size = new System.Drawing.Size(160, 24);
            this.cboxDataBits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA BITS:";
            // 
            // cboxBAUD
            // 
            this.cboxBAUD.FormattingEnabled = true;
            this.cboxBAUD.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBAUD.Location = new System.Drawing.Point(112, 59);
            this.cboxBAUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxBAUD.Name = "cboxBAUD";
            this.cboxBAUD.Size = new System.Drawing.Size(160, 24);
            this.cboxBAUD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE:";
            // 
            // cboxPORTCOM
            // 
            this.cboxPORTCOM.FormattingEnabled = true;
            this.cboxPORTCOM.Location = new System.Drawing.Point(112, 26);
            this.cboxPORTCOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxPORTCOM.Name = "cboxPORTCOM";
            this.cboxPORTCOM.Size = new System.Drawing.Size(160, 24);
            this.cboxPORTCOM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT:";
            // 
            // FormConnectivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1149, 606);
            this.Controls.Add(this.groupBoxSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConnectivity";
            this.Text = "FormConnectivity";
            this.Load += new System.EventHandler(this.FormConnectivity_Load);
            this.groupBoxSerial.ResumeLayout(false);
            this.groupBoxSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerial;
        private System.Windows.Forms.ComboBox cboxPORTCOM;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxBAUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnSB2;
        private System.Windows.Forms.RadioButton rbtnSB1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}