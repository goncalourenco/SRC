namespace PacketGenerateor
{
    partial class UDPFlowForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxSwap = new System.Windows.Forms.CheckBox();
            this.checkboxRandomPorts = new System.Windows.Forms.CheckBox();
            this.checkbox_http = new System.Windows.Forms.CheckBox();
            this.numberPacketsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.netDestIP = new System.Windows.Forms.TextBox();
            this.labelNetDestIP = new System.Windows.Forms.Label();
            this.netSourceIP = new System.Windows.Forms.TextBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelIPv4Protocol = new System.Windows.Forms.Label();
            this.ethSourceAddr = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.cmbEthType = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.ethDestAddr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPacketsUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxSwap);
            this.groupBox1.Controls.Add(this.checkboxRandomPorts);
            this.groupBox1.Controls.Add(this.checkbox_http);
            this.groupBox1.Controls.Add(this.numberPacketsUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkboxSwap
            // 
            this.checkboxSwap.AutoSize = true;
            this.checkboxSwap.Location = new System.Drawing.Point(9, 95);
            this.checkboxSwap.Name = "checkboxSwap";
            this.checkboxSwap.Size = new System.Drawing.Size(132, 17);
            this.checkboxSwap.TabIndex = 4;
            this.checkboxSwap.Text = "Swap source and dest";
            this.checkboxSwap.UseVisualStyleBackColor = true;
            // 
            // checkboxRandomPorts
            // 
            this.checkboxRandomPorts.AutoSize = true;
            this.checkboxRandomPorts.Location = new System.Drawing.Point(9, 72);
            this.checkboxRandomPorts.Name = "checkboxRandomPorts";
            this.checkboxRandomPorts.Size = new System.Drawing.Size(93, 17);
            this.checkboxRandomPorts.TabIndex = 3;
            this.checkboxRandomPorts.Text = "Random Ports";
            this.checkboxRandomPorts.UseVisualStyleBackColor = true;
            // 
            // checkbox_http
            // 
            this.checkbox_http.AutoSize = true;
            this.checkbox_http.Location = new System.Drawing.Point(9, 48);
            this.checkbox_http.Name = "checkbox_http";
            this.checkbox_http.Size = new System.Drawing.Size(84, 17);
            this.checkbox_http.TabIndex = 2;
            this.checkbox_http.Text = "HTTP traffic";
            this.checkbox_http.UseVisualStyleBackColor = true;
            // 
            // numberPacketsUpDown
            // 
            this.numberPacketsUpDown.Location = new System.Drawing.Point(112, 24);
            this.numberPacketsUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberPacketsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPacketsUpDown.Name = "numberPacketsUpDown";
            this.numberPacketsUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberPacketsUpDown.TabIndex = 1;
            this.numberPacketsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of packets:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.netDestIP);
            this.groupBox2.Controls.Add(this.labelNetDestIP);
            this.groupBox2.Controls.Add(this.netSourceIP);
            this.groupBox2.Controls.Add(this.labelNetSourceIP);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Layer IPv4";
            // 
            // netDestIP
            // 
            this.netDestIP.Location = new System.Drawing.Point(9, 78);
            this.netDestIP.Name = "netDestIP";
            this.netDestIP.Size = new System.Drawing.Size(108, 20);
            this.netDestIP.TabIndex = 50;
            // 
            // labelNetDestIP
            // 
            this.labelNetDestIP.AutoSize = true;
            this.labelNetDestIP.Location = new System.Drawing.Point(6, 63);
            this.labelNetDestIP.Name = "labelNetDestIP";
            this.labelNetDestIP.Size = new System.Drawing.Size(42, 13);
            this.labelNetDestIP.TabIndex = 49;
            this.labelNetDestIP.Text = "Dest IP";
            // 
            // netSourceIP
            // 
            this.netSourceIP.Location = new System.Drawing.Point(9, 38);
            this.netSourceIP.Name = "netSourceIP";
            this.netSourceIP.Size = new System.Drawing.Size(108, 20);
            this.netSourceIP.TabIndex = 48;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(6, 22);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(54, 13);
            this.labelNetSourceIP.TabIndex = 47;
            this.labelNetSourceIP.Text = "Source IP";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(12, 434);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelIPv4Protocol);
            this.groupBox3.Controls.Add(this.ethSourceAddr);
            this.groupBox3.Controls.Add(this.labelSource);
            this.groupBox3.Controls.Add(this.cmbEthType);
            this.groupBox3.Controls.Add(this.labelDestination);
            this.groupBox3.Controls.Add(this.ethDestAddr);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 154);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ethernet Layer";
            // 
            // labelIPv4Protocol
            // 
            this.labelIPv4Protocol.AutoSize = true;
            this.labelIPv4Protocol.Location = new System.Drawing.Point(6, 103);
            this.labelIPv4Protocol.Name = "labelIPv4Protocol";
            this.labelIPv4Protocol.Size = new System.Drawing.Size(50, 13);
            this.labelIPv4Protocol.TabIndex = 47;
            this.labelIPv4Protocol.Text = "Eth Type";
            // 
            // ethSourceAddr
            // 
            this.ethSourceAddr.Location = new System.Drawing.Point(9, 32);
            this.ethSourceAddr.Name = "ethSourceAddr";
            this.ethSourceAddr.Size = new System.Drawing.Size(109, 20);
            this.ethSourceAddr.TabIndex = 42;
            this.ethSourceAddr.Text = "30:3A:64:69:70:FD";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(6, 16);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 40;
            this.labelSource.Text = "Source";
            // 
            // cmbEthType
            // 
            this.cmbEthType.Enabled = false;
            this.cmbEthType.FormattingEnabled = true;
            this.cmbEthType.Items.AddRange(new object[] {
            "IpV4"});
            this.cmbEthType.Location = new System.Drawing.Point(9, 119);
            this.cmbEthType.Name = "cmbEthType";
            this.cmbEthType.Size = new System.Drawing.Size(142, 21);
            this.cmbEthType.TabIndex = 46;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(6, 61);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 41;
            this.labelDestination.Text = "Destination";
            // 
            // ethDestAddr
            // 
            this.ethDestAddr.Location = new System.Drawing.Point(9, 77);
            this.ethDestAddr.Name = "ethDestAddr";
            this.ethDestAddr.Size = new System.Drawing.Size(109, 20);
            this.ethDestAddr.TabIndex = 43;
            this.ethDestAddr.Text = "F4:06:69:06:DC:EF";
            // 
            // UDPFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UDPFlowForm";
            this.Text = "UPDFlowForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPacketsUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numberPacketsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_http;
        private System.Windows.Forms.CheckBox checkboxRandomPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox netDestIP;
        private System.Windows.Forms.Label labelNetDestIP;
        private System.Windows.Forms.TextBox netSourceIP;
        private System.Windows.Forms.Label labelNetSourceIP;
        private System.Windows.Forms.CheckBox checkboxSwap;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelIPv4Protocol;
        private System.Windows.Forms.ComboBox cmbEthType;
        private System.Windows.Forms.TextBox ethDestAddr;
        private System.Windows.Forms.TextBox ethSourceAddr;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelSource;
    }
}