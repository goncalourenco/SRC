namespace PacketGenerateor.Panels
{
    partial class TabIPV4
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
            this.checkBoxCheckSum = new System.Windows.Forms.CheckBox();
            this.networkCheckSum = new System.Windows.Forms.TextBox();
            this.labelNetworkCheckSum = new System.Windows.Forms.Label();
            this.networkTOS = new System.Windows.Forms.TextBox();
            this.labelTOS = new System.Windows.Forms.Label();
            this.networkTTL = new System.Windows.Forms.TextBox();
            this.labelTTL = new System.Windows.Forms.Label();
            this.labelIPv4Protocol = new System.Windows.Forms.Label();
            this.cmbIPV4Protocols = new System.Windows.Forms.ComboBox();
            this.identification = new System.Windows.Forms.TextBox();
            this.labelNetworkID = new System.Windows.Forms.Label();
            this.netDestIP = new System.Windows.Forms.TextBox();
            this.labelNetDestIP = new System.Windows.Forms.Label();
            this.netSourceIP = new System.Windows.Forms.TextBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxCheckSum
            // 
            this.checkBoxCheckSum.AutoSize = true;
            this.checkBoxCheckSum.Checked = true;
            this.checkBoxCheckSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckSum.Location = new System.Drawing.Point(511, 92);
            this.checkBoxCheckSum.Name = "checkBoxCheckSum";
            this.checkBoxCheckSum.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCheckSum.TabIndex = 44;
            this.checkBoxCheckSum.Text = "AUTO";
            this.checkBoxCheckSum.UseVisualStyleBackColor = true;
            this.checkBoxCheckSum.CheckedChanged += new System.EventHandler(this.checkBoxCheckSum_CheckedChanged);
            // 
            // networkCheckSum
            // 
            this.networkCheckSum.Enabled = false;
            this.networkCheckSum.Location = new System.Drawing.Point(425, 90);
            this.networkCheckSum.Name = "networkCheckSum";
            this.networkCheckSum.Size = new System.Drawing.Size(80, 20);
            this.networkCheckSum.TabIndex = 43;
            // 
            // labelNetworkCheckSum
            // 
            this.labelNetworkCheckSum.AutoSize = true;
            this.labelNetworkCheckSum.Location = new System.Drawing.Point(422, 74);
            this.labelNetworkCheckSum.Name = "labelNetworkCheckSum";
            this.labelNetworkCheckSum.Size = new System.Drawing.Size(59, 13);
            this.labelNetworkCheckSum.TabIndex = 42;
            this.labelNetworkCheckSum.Text = "CheckSum";
            // 
            // networkTOS
            // 
            this.networkTOS.Location = new System.Drawing.Point(425, 41);
            this.networkTOS.Name = "networkTOS";
            this.networkTOS.Size = new System.Drawing.Size(80, 20);
            this.networkTOS.TabIndex = 41;
            this.networkTOS.Text = "0000";
            // 
            // labelTOS
            // 
            this.labelTOS.AutoSize = true;
            this.labelTOS.Location = new System.Drawing.Point(422, 25);
            this.labelTOS.Name = "labelTOS";
            this.labelTOS.Size = new System.Drawing.Size(29, 13);
            this.labelTOS.TabIndex = 40;
            this.labelTOS.Text = "TOS";
            // 
            // networkTTL
            // 
            this.networkTTL.Location = new System.Drawing.Point(339, 41);
            this.networkTTL.Name = "networkTTL";
            this.networkTTL.Size = new System.Drawing.Size(80, 20);
            this.networkTTL.TabIndex = 39;
            this.networkTTL.Text = "100";
            // 
            // labelTTL
            // 
            this.labelTTL.AutoSize = true;
            this.labelTTL.Location = new System.Drawing.Point(336, 26);
            this.labelTTL.Name = "labelTTL";
            this.labelTTL.Size = new System.Drawing.Size(27, 13);
            this.labelTTL.TabIndex = 38;
            this.labelTTL.Text = "TTL";
            // 
            // labelIPv4Protocol
            // 
            this.labelIPv4Protocol.AutoSize = true;
            this.labelIPv4Protocol.Location = new System.Drawing.Point(116, 74);
            this.labelIPv4Protocol.Name = "labelIPv4Protocol";
            this.labelIPv4Protocol.Size = new System.Drawing.Size(46, 13);
            this.labelIPv4Protocol.TabIndex = 37;
            this.labelIPv4Protocol.Text = "Protocol";
            // 
            // cmbIPV4Protocols
            // 
            this.cmbIPV4Protocols.Enabled = false;
            this.cmbIPV4Protocols.FormattingEnabled = true;
            this.cmbIPV4Protocols.Location = new System.Drawing.Point(119, 88);
            this.cmbIPV4Protocols.Name = "cmbIPV4Protocols";
            this.cmbIPV4Protocols.Size = new System.Drawing.Size(214, 21);
            this.cmbIPV4Protocols.TabIndex = 36;
            // 
            // identification
            // 
            this.identification.Location = new System.Drawing.Point(233, 42);
            this.identification.Name = "identification";
            this.identification.Size = new System.Drawing.Size(100, 20);
            this.identification.TabIndex = 35;
            this.identification.Text = "123";
            // 
            // labelNetworkID
            // 
            this.labelNetworkID.AutoSize = true;
            this.labelNetworkID.Location = new System.Drawing.Point(230, 26);
            this.labelNetworkID.Name = "labelNetworkID";
            this.labelNetworkID.Size = new System.Drawing.Size(67, 13);
            this.labelNetworkID.TabIndex = 34;
            this.labelNetworkID.Text = "Identification";
            // 
            // netDestIP
            // 
            this.netDestIP.Location = new System.Drawing.Point(119, 42);
            this.netDestIP.Name = "netDestIP";
            this.netDestIP.Size = new System.Drawing.Size(108, 20);
            this.netDestIP.TabIndex = 33;
            // 
            // labelNetDestIP
            // 
            this.labelNetDestIP.AutoSize = true;
            this.labelNetDestIP.Location = new System.Drawing.Point(116, 26);
            this.labelNetDestIP.Name = "labelNetDestIP";
            this.labelNetDestIP.Size = new System.Drawing.Size(42, 13);
            this.labelNetDestIP.TabIndex = 32;
            this.labelNetDestIP.Text = "Dest IP";
            // 
            // netSourceIP
            // 
            this.netSourceIP.Location = new System.Drawing.Point(4, 42);
            this.netSourceIP.Name = "netSourceIP";
            this.netSourceIP.Size = new System.Drawing.Size(108, 20);
            this.netSourceIP.TabIndex = 31;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(1, 26);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(54, 13);
            this.labelNetSourceIP.TabIndex = 30;
            this.labelNetSourceIP.Text = "Source IP";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(454, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(339, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "AUTO";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TabIPV4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkBoxCheckSum);
            this.Controls.Add(this.networkCheckSum);
            this.Controls.Add(this.labelNetworkCheckSum);
            this.Controls.Add(this.networkTOS);
            this.Controls.Add(this.labelTOS);
            this.Controls.Add(this.networkTTL);
            this.Controls.Add(this.labelTTL);
            this.Controls.Add(this.labelIPv4Protocol);
            this.Controls.Add(this.cmbIPV4Protocols);
            this.Controls.Add(this.identification);
            this.Controls.Add(this.labelNetworkID);
            this.Controls.Add(this.netDestIP);
            this.Controls.Add(this.labelNetDestIP);
            this.Controls.Add(this.netSourceIP);
            this.Controls.Add(this.labelNetSourceIP);
            this.Name = "TabIPV4";
            this.Size = new System.Drawing.Size(578, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCheckSum;
        private System.Windows.Forms.TextBox networkCheckSum;
        private System.Windows.Forms.Label labelNetworkCheckSum;
        private System.Windows.Forms.TextBox networkTOS;
        private System.Windows.Forms.Label labelTOS;
        private System.Windows.Forms.TextBox networkTTL;
        private System.Windows.Forms.Label labelTTL;
        private System.Windows.Forms.Label labelIPv4Protocol;
        private System.Windows.Forms.ComboBox cmbIPV4Protocols;
        private System.Windows.Forms.TextBox identification;
        private System.Windows.Forms.Label labelNetworkID;
        private System.Windows.Forms.TextBox netDestIP;
        private System.Windows.Forms.Label labelNetDestIP;
        private System.Windows.Forms.TextBox netSourceIP;
        private System.Windows.Forms.Label labelNetSourceIP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
