namespace PacketGenerateor.Panels
{
    partial class TabUDP
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
            this.labelNetworkCheckSum = new System.Windows.Forms.Label();
            this.checkBoxCheckSum = new System.Windows.Forms.CheckBox();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.labelNetDestIP = new System.Windows.Forms.Label();
            this.txtSourcePort = new System.Windows.Forms.TextBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.checkBoxCalculateSum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNetworkCheckSum
            // 
            this.labelNetworkCheckSum.AutoSize = true;
            this.labelNetworkCheckSum.Location = new System.Drawing.Point(10, 60);
            this.labelNetworkCheckSum.Name = "labelNetworkCheckSum";
            this.labelNetworkCheckSum.Size = new System.Drawing.Size(59, 13);
            this.labelNetworkCheckSum.TabIndex = 61;
            this.labelNetworkCheckSum.Text = "CheckSum";
            // 
            // checkBoxCheckSum
            // 
            this.checkBoxCheckSum.AutoSize = true;
            this.checkBoxCheckSum.Checked = true;
            this.checkBoxCheckSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckSum.Location = new System.Drawing.Point(101, 79);
            this.checkBoxCheckSum.Name = "checkBoxCheckSum";
            this.checkBoxCheckSum.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCheckSum.TabIndex = 60;
            this.checkBoxCheckSum.Text = "AUTO";
            this.checkBoxCheckSum.UseVisualStyleBackColor = true;
            this.checkBoxCheckSum.CheckedChanged += new System.EventHandler(this.checkBoxCheckSum_CheckedChanged);
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Enabled = false;
            this.txtCheckSum.Location = new System.Drawing.Point(13, 76);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(80, 20);
            this.txtCheckSum.TabIndex = 59;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDestPort
            // 
            this.txtDestPort.Location = new System.Drawing.Point(128, 30);
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.Size = new System.Drawing.Size(108, 20);
            this.txtDestPort.TabIndex = 57;
            // 
            // labelNetDestIP
            // 
            this.labelNetDestIP.AutoSize = true;
            this.labelNetDestIP.Location = new System.Drawing.Point(125, 14);
            this.labelNetDestIP.Name = "labelNetDestIP";
            this.labelNetDestIP.Size = new System.Drawing.Size(51, 13);
            this.labelNetDestIP.TabIndex = 56;
            this.labelNetDestIP.Text = "Dest Port";
            // 
            // txtSourcePort
            // 
            this.txtSourcePort.Location = new System.Drawing.Point(13, 30);
            this.txtSourcePort.Name = "txtSourcePort";
            this.txtSourcePort.Size = new System.Drawing.Size(108, 20);
            this.txtSourcePort.TabIndex = 55;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(10, 14);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(63, 13);
            this.labelNetSourceIP.TabIndex = 54;
            this.labelNetSourceIP.Text = "Source Port";
            // 
            // checkBoxCalculateSum
            // 
            this.checkBoxCalculateSum.AutoSize = true;
            this.checkBoxCalculateSum.Checked = true;
            this.checkBoxCalculateSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCalculateSum.Location = new System.Drawing.Point(101, 102);
            this.checkBoxCalculateSum.Name = "checkBoxCalculateSum";
            this.checkBoxCalculateSum.Size = new System.Drawing.Size(155, 17);
            this.checkBoxCalculateSum.TabIndex = 62;
            this.checkBoxCalculateSum.Text = "Calculate CheckSum Value";
            this.checkBoxCalculateSum.UseVisualStyleBackColor = true;
            // 
            // TabUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCalculateSum);
            this.Controls.Add(this.labelNetworkCheckSum);
            this.Controls.Add(this.checkBoxCheckSum);
            this.Controls.Add(this.txtCheckSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDestPort);
            this.Controls.Add(this.labelNetDestIP);
            this.Controls.Add(this.txtSourcePort);
            this.Controls.Add(this.labelNetSourceIP);
            this.Name = "TabUDP";
            this.Size = new System.Drawing.Size(418, 221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNetworkCheckSum;
        private System.Windows.Forms.CheckBox checkBoxCheckSum;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.Label labelNetDestIP;
        private System.Windows.Forms.TextBox txtSourcePort;
        private System.Windows.Forms.Label labelNetSourceIP;
        private System.Windows.Forms.CheckBox checkBoxCalculateSum;
    }
}
