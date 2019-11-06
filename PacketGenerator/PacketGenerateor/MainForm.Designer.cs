namespace PacketGenerateor
{
    partial class MainForm
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
            this.listDevices = new System.Windows.Forms.ListBox();
            this.btnListDevices = new System.Windows.Forms.Button();
            this.btnSendPackets = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetEthernet = new System.Windows.Forms.Button();
            this.ethDestAddr = new System.Windows.Forms.TextBox();
            this.ethSourceAddr = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.listPacketLayers = new System.Windows.Forms.ListBox();
            this.labelPacketEstructure = new System.Windows.Forms.Label();
            this.btnRemovePacketLayer = new System.Windows.Forms.Button();
            this.btnPhysical = new System.Windows.Forms.Button();
            this.btnDataLink = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(142, 12);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(646, 95);
            this.listDevices.TabIndex = 0;
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listDevices_SelectedIndexChanged);
            // 
            // btnListDevices
            // 
            this.btnListDevices.Location = new System.Drawing.Point(13, 13);
            this.btnListDevices.Name = "btnListDevices";
            this.btnListDevices.Size = new System.Drawing.Size(123, 42);
            this.btnListDevices.TabIndex = 1;
            this.btnListDevices.Text = "List Devices";
            this.btnListDevices.UseVisualStyleBackColor = true;
            this.btnListDevices.Click += new System.EventHandler(this.btnListDevices_Click);
            // 
            // btnSendPackets
            // 
            this.btnSendPackets.Location = new System.Drawing.Point(13, 61);
            this.btnSendPackets.Name = "btnSendPackets";
            this.btnSendPackets.Size = new System.Drawing.Size(123, 46);
            this.btnSendPackets.TabIndex = 2;
            this.btnSendPackets.Text = "Send Packets";
            this.btnSendPackets.UseVisualStyleBackColor = true;
            this.btnSendPackets.Click += new System.EventHandler(this.btnSendPackets_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApplication);
            this.panel1.Controls.Add(this.btnTransport);
            this.panel1.Controls.Add(this.btnNetwork);
            this.panel1.Controls.Add(this.btnDataLink);
            this.panel1.Controls.Add(this.btnPhysical);
            this.panel1.Location = new System.Drawing.Point(13, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 325);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.btnSetEthernet);
            this.panel2.Controls.Add(this.ethDestAddr);
            this.panel2.Controls.Add(this.ethSourceAddr);
            this.panel2.Controls.Add(this.labelDestination);
            this.panel2.Controls.Add(this.labelSource);
            this.panel2.Location = new System.Drawing.Point(205, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 324);
            this.panel2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 216);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSetEthernet
            // 
            this.btnSetEthernet.Location = new System.Drawing.Point(457, 287);
            this.btnSetEthernet.Name = "btnSetEthernet";
            this.btnSetEthernet.Size = new System.Drawing.Size(100, 20);
            this.btnSetEthernet.TabIndex = 14;
            this.btnSetEthernet.Text = "Set";
            this.btnSetEthernet.UseVisualStyleBackColor = true;
            this.btnSetEthernet.Click += new System.EventHandler(this.btnSetEthernet_Click);
            // 
            // ethDestAddr
            // 
            this.ethDestAddr.Location = new System.Drawing.Point(65, 299);
            this.ethDestAddr.Name = "ethDestAddr";
            this.ethDestAddr.Size = new System.Drawing.Size(109, 20);
            this.ethDestAddr.TabIndex = 3;
            this.ethDestAddr.Text = "F4:06:69:06:DC:EF";
            // 
            // ethSourceAddr
            // 
            this.ethSourceAddr.Location = new System.Drawing.Point(65, 276);
            this.ethSourceAddr.Name = "ethSourceAddr";
            this.ethSourceAddr.Size = new System.Drawing.Size(109, 20);
            this.ethSourceAddr.TabIndex = 2;
            this.ethSourceAddr.Text = "30:3A:64:69:70:FD";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(4, 302);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Destination";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(4, 279);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // listPacketLayers
            // 
            this.listPacketLayers.FormattingEnabled = true;
            this.listPacketLayers.Location = new System.Drawing.Point(802, 114);
            this.listPacketLayers.Name = "listPacketLayers";
            this.listPacketLayers.Size = new System.Drawing.Size(242, 160);
            this.listPacketLayers.TabIndex = 6;
            // 
            // labelPacketEstructure
            // 
            this.labelPacketEstructure.AutoSize = true;
            this.labelPacketEstructure.Location = new System.Drawing.Point(799, 98);
            this.labelPacketEstructure.Name = "labelPacketEstructure";
            this.labelPacketEstructure.Size = new System.Drawing.Size(92, 13);
            this.labelPacketEstructure.TabIndex = 7;
            this.labelPacketEstructure.Text = "Packet Estructure";
            // 
            // btnRemovePacketLayer
            // 
            this.btnRemovePacketLayer.Location = new System.Drawing.Point(917, 280);
            this.btnRemovePacketLayer.Name = "btnRemovePacketLayer";
            this.btnRemovePacketLayer.Size = new System.Drawing.Size(127, 30);
            this.btnRemovePacketLayer.TabIndex = 8;
            this.btnRemovePacketLayer.Text = "Remove";
            this.btnRemovePacketLayer.UseVisualStyleBackColor = true;
            this.btnRemovePacketLayer.Click += new System.EventHandler(this.btnRemovePacketLayer_Click);
            // 
            // btnPhysical
            // 
            this.btnPhysical.Enabled = false;
            this.btnPhysical.Location = new System.Drawing.Point(4, 284);
            this.btnPhysical.Name = "btnPhysical";
            this.btnPhysical.Size = new System.Drawing.Size(178, 38);
            this.btnPhysical.TabIndex = 14;
            this.btnPhysical.Text = "Physical";
            this.btnPhysical.UseVisualStyleBackColor = true;
            // 
            // btnDataLink
            // 
            this.btnDataLink.Location = new System.Drawing.Point(4, 240);
            this.btnDataLink.Name = "btnDataLink";
            this.btnDataLink.Size = new System.Drawing.Size(178, 38);
            this.btnDataLink.TabIndex = 15;
            this.btnDataLink.Text = "Data Link";
            this.btnDataLink.UseVisualStyleBackColor = true;
            this.btnDataLink.Click += new System.EventHandler(this.btnDataLink_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Location = new System.Drawing.Point(4, 196);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(178, 38);
            this.btnNetwork.TabIndex = 16;
            this.btnNetwork.Text = "Network";
            this.btnNetwork.UseVisualStyleBackColor = true;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnTransport
            // 
            this.btnTransport.Location = new System.Drawing.Point(4, 152);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(178, 38);
            this.btnTransport.TabIndex = 17;
            this.btnTransport.Text = "Transport";
            this.btnTransport.UseVisualStyleBackColor = true;
            // 
            // btnApplication
            // 
            this.btnApplication.Location = new System.Drawing.Point(4, 108);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(178, 38);
            this.btnApplication.TabIndex = 18;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "GET MY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 462);
            this.Controls.Add(this.btnRemovePacketLayer);
            this.Controls.Add(this.labelPacketEstructure);
            this.Controls.Add(this.listPacketLayers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendPackets);
            this.Controls.Add(this.btnListDevices);
            this.Controls.Add(this.listDevices);
            this.Name = "MainForm";
            this.Text = "ICMP";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Button btnListDevices;
        private System.Windows.Forms.Button btnSendPackets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox ethDestAddr;
        private System.Windows.Forms.TextBox ethSourceAddr;
        private System.Windows.Forms.ListBox listPacketLayers;
        private System.Windows.Forms.Label labelPacketEstructure;
        private System.Windows.Forms.Button btnSetEthernet;
        private System.Windows.Forms.Button btnRemovePacketLayer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Button btnDataLink;
        private System.Windows.Forms.Button btnPhysical;
        private System.Windows.Forms.Button button1;
    }
}

