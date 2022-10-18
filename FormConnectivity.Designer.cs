
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
            this.groupBoxSerial.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSerial.Name = "groupBoxSerial";
            this.groupBoxSerial.Size = new System.Drawing.Size(212, 258);
            this.groupBoxSerial.TabIndex = 0;
            this.groupBoxSerial.TabStop = false;
            this.groupBoxSerial.Text = "Serial Port";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(117, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(21, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Accept";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboxParity
            // 
            this.cboxParity.FormattingEnabled = true;
            this.cboxParity.Items.AddRange(new object[] {
            "No",
            "Odd",
            "Even"});
            this.cboxParity.Location = new System.Drawing.Point(84, 102);
            this.cboxParity.Name = "cboxParity";
            this.cboxParity.Size = new System.Drawing.Size(121, 21);
            this.cboxParity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PARITY BIT:";
            // 
            // rbtnSB2
            // 
            this.rbtnSB2.AutoSize = true;
            this.rbtnSB2.Checked = true;
            this.rbtnSB2.Location = new System.Drawing.Point(152, 132);
            this.rbtnSB2.Name = "rbtnSB2";
            this.rbtnSB2.Size = new System.Drawing.Size(31, 17);
            this.rbtnSB2.TabIndex = 10;
            this.rbtnSB2.TabStop = true;
            this.rbtnSB2.Text = "2";
            this.rbtnSB2.UseVisualStyleBackColor = true;
            // 
            // rbtnSB1
            // 
            this.rbtnSB1.AutoSize = true;
            this.rbtnSB1.Location = new System.Drawing.Point(97, 132);
            this.rbtnSB1.Name = "rbtnSB1";
            this.rbtnSB1.Size = new System.Drawing.Size(31, 17);
            this.rbtnSB1.TabIndex = 9;
            this.rbtnSB1.Text = "1";
            this.rbtnSB1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
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
            this.cboxDataBits.Location = new System.Drawing.Point(84, 75);
            this.cboxDataBits.Name = "cboxDataBits";
            this.cboxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboxDataBits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
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
            this.cboxBAUD.Location = new System.Drawing.Point(84, 48);
            this.cboxBAUD.Name = "cboxBAUD";
            this.cboxBAUD.Size = new System.Drawing.Size(121, 21);
            this.cboxBAUD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE:";
            // 
            // cboxPORTCOM
            // 
            this.cboxPORTCOM.FormattingEnabled = true;
            this.cboxPORTCOM.Location = new System.Drawing.Point(84, 21);
            this.cboxPORTCOM.Name = "cboxPORTCOM";
            this.cboxPORTCOM.Size = new System.Drawing.Size(121, 21);
            this.cboxPORTCOM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT:";
            // 
            // FormConnectivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(862, 492);
            this.Controls.Add(this.groupBoxSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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