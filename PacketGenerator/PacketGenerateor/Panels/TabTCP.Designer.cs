namespace PacketGenerateor.Panels
{
    partial class TabTCP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.labelNetDestIP = new System.Windows.Forms.Label();
            this.txtSourcePort = new System.Windows.Forms.TextBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.checkBoxCheckSum = new System.Windows.Forms.CheckBox();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.labelNetworkCheckSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSequenceN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAckN = new System.Windows.Forms.TextBox();
            this.labelControlBits = new System.Windows.Forms.Label();
            this.cmbControlBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWindow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrgentPointer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDestPort
            // 
            this.txtDestPort.Location = new System.Drawing.Point(132, 30);
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.Size = new System.Drawing.Size(108, 20);
            this.txtDestPort.TabIndex = 49;
            // 
            // labelNetDestIP
            // 
            this.labelNetDestIP.AutoSize = true;
            this.labelNetDestIP.Location = new System.Drawing.Point(129, 14);
            this.labelNetDestIP.Name = "labelNetDestIP";
            this.labelNetDestIP.Size = new System.Drawing.Size(51, 13);
            this.labelNetDestIP.TabIndex = 48;
            this.labelNetDestIP.Text = "Dest Port";
            // 
            // txtSourcePort
            // 
            this.txtSourcePort.Location = new System.Drawing.Point(17, 30);
            this.txtSourcePort.Name = "txtSourcePort";
            this.txtSourcePort.Size = new System.Drawing.Size(108, 20);
            this.txtSourcePort.TabIndex = 47;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(14, 14);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(63, 13);
            this.labelNetSourceIP.TabIndex = 46;
            this.labelNetSourceIP.Text = "Source Port";
            // 
            // checkBoxCheckSum
            // 
            this.checkBoxCheckSum.AutoSize = true;
            this.checkBoxCheckSum.Checked = true;
            this.checkBoxCheckSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckSum.Location = new System.Drawing.Point(341, 32);
            this.checkBoxCheckSum.Name = "checkBoxCheckSum";
            this.checkBoxCheckSum.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCheckSum.TabIndex = 52;
            this.checkBoxCheckSum.Text = "AUTO";
            this.checkBoxCheckSum.UseVisualStyleBackColor = true;
            this.checkBoxCheckSum.CheckedChanged += new System.EventHandler(this.checkBoxCheckSum_CheckedChanged);
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Enabled = false;
            this.txtCheckSum.Location = new System.Drawing.Point(255, 30);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(80, 20);
            this.txtCheckSum.TabIndex = 51;
            // 
            // labelNetworkCheckSum
            // 
            this.labelNetworkCheckSum.AutoSize = true;
            this.labelNetworkCheckSum.Location = new System.Drawing.Point(252, 14);
            this.labelNetworkCheckSum.Name = "labelNetworkCheckSum";
            this.labelNetworkCheckSum.Size = new System.Drawing.Size(59, 13);
            this.labelNetworkCheckSum.TabIndex = 53;
            this.labelNetworkCheckSum.Text = "CheckSum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sequence Nº";
            // 
            // txtSequenceN
            // 
            this.txtSequenceN.Enabled = false;
            this.txtSequenceN.Location = new System.Drawing.Point(17, 78);
            this.txtSequenceN.Name = "txtSequenceN";
            this.txtSequenceN.Size = new System.Drawing.Size(80, 20);
            this.txtSequenceN.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ack Nº";
            // 
            // txtAckN
            // 
            this.txtAckN.Enabled = false;
            this.txtAckN.Location = new System.Drawing.Point(103, 78);
            this.txtAckN.Name = "txtAckN";
            this.txtAckN.Size = new System.Drawing.Size(65, 20);
            this.txtAckN.TabIndex = 56;
            // 
            // labelControlBits
            // 
            this.labelControlBits.AutoSize = true;
            this.labelControlBits.Location = new System.Drawing.Point(171, 64);
            this.labelControlBits.Name = "labelControlBits";
            this.labelControlBits.Size = new System.Drawing.Size(60, 13);
            this.labelControlBits.TabIndex = 59;
            this.labelControlBits.Text = "Control Bits";
            // 
            // cmbControlBits
            // 
            this.cmbControlBits.FormattingEnabled = true;
            this.cmbControlBits.Location = new System.Drawing.Point(174, 78);
            this.cmbControlBits.Name = "cmbControlBits";
            this.cmbControlBits.Size = new System.Drawing.Size(223, 21);
            this.cmbControlBits.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Window";
            // 
            // txtWindow
            // 
            this.txtWindow.Enabled = false;
            this.txtWindow.Location = new System.Drawing.Point(17, 116);
            this.txtWindow.Name = "txtWindow";
            this.txtWindow.Size = new System.Drawing.Size(80, 20);
            this.txtWindow.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Urgent Pointer";
            // 
            // txtUrgentPointer
            // 
            this.txtUrgentPointer.Enabled = false;
            this.txtUrgentPointer.Location = new System.Drawing.Point(103, 116);
            this.txtUrgentPointer.Name = "txtUrgentPointer";
            this.txtUrgentPointer.Size = new System.Drawing.Size(128, 20);
            this.txtUrgentPointer.TabIndex = 62;
            // 
            // TabTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrgentPointer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWindow);
            this.Controls.Add(this.labelControlBits);
            this.Controls.Add(this.cmbControlBits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAckN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSequenceN);
            this.Controls.Add(this.labelNetworkCheckSum);
            this.Controls.Add(this.checkBoxCheckSum);
            this.Controls.Add(this.txtCheckSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDestPort);
            this.Controls.Add(this.labelNetDestIP);
            this.Controls.Add(this.txtSourcePort);
            this.Controls.Add(this.labelNetSourceIP);
            this.Name = "TabTCP";
            this.Size = new System.Drawing.Size(477, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.Label labelNetDestIP;
        private System.Windows.Forms.TextBox txtSourcePort;
        private System.Windows.Forms.Label labelNetSourceIP;
        private System.Windows.Forms.CheckBox checkBoxCheckSum;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.Label labelNetworkCheckSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSequenceN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAckN;
        private System.Windows.Forms.Label labelControlBits;
        private System.Windows.Forms.ComboBox cmbControlBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrgentPointer;
    }
}
