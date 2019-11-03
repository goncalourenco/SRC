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
            this.btnHTTP = new System.Windows.Forms.Button();
            this.btnUDP = new System.Windows.Forms.Button();
            this.btnIPV6 = new System.Windows.Forms.Button();
            this.btnIPV4 = new System.Windows.Forms.Button();
            this.btnIGMP = new System.Windows.Forms.Button();
            this.labelApplication = new System.Windows.Forms.Label();
            this.btnDNS = new System.Windows.Forms.Button();
            this.labelTrasport = new System.Windows.Forms.Label();
            this.btnTCP = new System.Windows.Forms.Button();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.btnICMP = new System.Windows.Forms.Button();
            this.labelDataLink = new System.Windows.Forms.Label();
            this.btnARP = new System.Windows.Forms.Button();
            this.labelPhys = new System.Windows.Forms.Label();
            this.btnEthernet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetEthernet = new System.Windows.Forms.Button();
            this.btnAddDataLink = new System.Windows.Forms.Button();
            this.labelDestHardwareAddr = new System.Windows.Forms.Label();
            this.destProtocolAddr = new System.Windows.Forms.TextBox();
            this.destHardwareAddr = new System.Windows.Forms.TextBox();
            this.labeldestProtocolAddr = new System.Windows.Forms.Label();
            this.sourceProtocolAddr = new System.Windows.Forms.TextBox();
            this.labelSourceProtocolAddr = new System.Windows.Forms.Label();
            this.sourceHardwareAddr = new System.Windows.Forms.TextBox();
            this.labelSourceHardwareAddr = new System.Windows.Forms.Label();
            this.ethDestAddr = new System.Windows.Forms.TextBox();
            this.ethSourceAddr = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.listPacketLayers = new System.Windows.Forms.ListBox();
            this.labelPacketEstructure = new System.Windows.Forms.Label();
            this.btnRemovePacketLayer = new System.Windows.Forms.Button();
            this.netDestIP = new System.Windows.Forms.TextBox();
            this.labelNetDestIP = new System.Windows.Forms.Label();
            this.netSourceIP = new System.Windows.Forms.TextBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnHTTP);
            this.panel1.Controls.Add(this.btnUDP);
            this.panel1.Controls.Add(this.btnIPV6);
            this.panel1.Controls.Add(this.btnIPV4);
            this.panel1.Controls.Add(this.btnIGMP);
            this.panel1.Controls.Add(this.labelApplication);
            this.panel1.Controls.Add(this.btnDNS);
            this.panel1.Controls.Add(this.labelTrasport);
            this.panel1.Controls.Add(this.btnTCP);
            this.panel1.Controls.Add(this.labelNetwork);
            this.panel1.Controls.Add(this.btnICMP);
            this.panel1.Controls.Add(this.labelDataLink);
            this.panel1.Controls.Add(this.btnARP);
            this.panel1.Controls.Add(this.labelPhys);
            this.panel1.Controls.Add(this.btnEthernet);
            this.panel1.Location = new System.Drawing.Point(13, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 325);
            this.panel1.TabIndex = 4;
            // 
            // btnHTTP
            // 
            this.btnHTTP.Location = new System.Drawing.Point(95, 20);
            this.btnHTTP.Name = "btnHTTP";
            this.btnHTTP.Size = new System.Drawing.Size(87, 34);
            this.btnHTTP.TabIndex = 18;
            this.btnHTTP.Text = "HTTP";
            this.btnHTTP.UseVisualStyleBackColor = true;
            this.btnHTTP.Click += new System.EventHandler(this.btnHTTP_Click);
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(95, 77);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(87, 34);
            this.btnUDP.TabIndex = 17;
            this.btnUDP.Text = "UDP";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // btnIPV6
            // 
            this.btnIPV6.Location = new System.Drawing.Point(95, 174);
            this.btnIPV6.Name = "btnIPV6";
            this.btnIPV6.Size = new System.Drawing.Size(87, 34);
            this.btnIPV6.TabIndex = 16;
            this.btnIPV6.Text = "IPv6";
            this.btnIPV6.UseVisualStyleBackColor = true;
            this.btnIPV6.Click += new System.EventHandler(this.btnIPV6_Click);
            // 
            // btnIPV4
            // 
            this.btnIPV4.Location = new System.Drawing.Point(3, 174);
            this.btnIPV4.Name = "btnIPV4";
            this.btnIPV4.Size = new System.Drawing.Size(87, 34);
            this.btnIPV4.TabIndex = 15;
            this.btnIPV4.Text = "IPv4";
            this.btnIPV4.UseVisualStyleBackColor = true;
            this.btnIPV4.Click += new System.EventHandler(this.btnIPV4_Click);
            // 
            // btnIGMP
            // 
            this.btnIGMP.Location = new System.Drawing.Point(95, 134);
            this.btnIGMP.Name = "btnIGMP";
            this.btnIGMP.Size = new System.Drawing.Size(87, 34);
            this.btnIGMP.TabIndex = 14;
            this.btnIGMP.Text = "IGMP";
            this.btnIGMP.UseVisualStyleBackColor = true;
            this.btnIGMP.Click += new System.EventHandler(this.btnIGMP_Click);
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplication.Location = new System.Drawing.Point(3, 0);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(88, 17);
            this.labelApplication.TabIndex = 13;
            this.labelApplication.Text = "Application";
            // 
            // btnDNS
            // 
            this.btnDNS.Location = new System.Drawing.Point(4, 20);
            this.btnDNS.Name = "btnDNS";
            this.btnDNS.Size = new System.Drawing.Size(87, 34);
            this.btnDNS.TabIndex = 12;
            this.btnDNS.Text = "DNS";
            this.btnDNS.UseVisualStyleBackColor = true;
            this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click);
            // 
            // labelTrasport
            // 
            this.labelTrasport.AutoSize = true;
            this.labelTrasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrasport.Location = new System.Drawing.Point(3, 57);
            this.labelTrasport.Name = "labelTrasport";
            this.labelTrasport.Size = new System.Drawing.Size(79, 17);
            this.labelTrasport.TabIndex = 11;
            this.labelTrasport.Text = "Transport";
            // 
            // btnTCP
            // 
            this.btnTCP.Location = new System.Drawing.Point(4, 77);
            this.btnTCP.Name = "btnTCP";
            this.btnTCP.Size = new System.Drawing.Size(87, 34);
            this.btnTCP.TabIndex = 10;
            this.btnTCP.Text = "TCP";
            this.btnTCP.UseVisualStyleBackColor = true;
            this.btnTCP.Click += new System.EventHandler(this.btnTCP_Click);
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetwork.Location = new System.Drawing.Point(3, 114);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(66, 17);
            this.labelNetwork.TabIndex = 9;
            this.labelNetwork.Text = "Network";
            // 
            // btnICMP
            // 
            this.btnICMP.Location = new System.Drawing.Point(3, 134);
            this.btnICMP.Name = "btnICMP";
            this.btnICMP.Size = new System.Drawing.Size(87, 34);
            this.btnICMP.TabIndex = 8;
            this.btnICMP.Text = "ICMP";
            this.btnICMP.UseVisualStyleBackColor = true;
            this.btnICMP.Click += new System.EventHandler(this.btnICMP_Click);
            // 
            // labelDataLink
            // 
            this.labelDataLink.AutoSize = true;
            this.labelDataLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataLink.Location = new System.Drawing.Point(3, 211);
            this.labelDataLink.Name = "labelDataLink";
            this.labelDataLink.Size = new System.Drawing.Size(77, 17);
            this.labelDataLink.TabIndex = 7;
            this.labelDataLink.Text = "Data Link";
            // 
            // btnARP
            // 
            this.btnARP.Location = new System.Drawing.Point(4, 231);
            this.btnARP.Name = "btnARP";
            this.btnARP.Size = new System.Drawing.Size(178, 34);
            this.btnARP.TabIndex = 6;
            this.btnARP.Text = "ARP";
            this.btnARP.UseVisualStyleBackColor = true;
            this.btnARP.Click += new System.EventHandler(this.btnARP_Click);
            // 
            // labelPhys
            // 
            this.labelPhys.AutoSize = true;
            this.labelPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhys.Location = new System.Drawing.Point(1, 268);
            this.labelPhys.Name = "labelPhys";
            this.labelPhys.Size = new System.Drawing.Size(68, 17);
            this.labelPhys.TabIndex = 5;
            this.labelPhys.Text = "Physical";
            // 
            // btnEthernet
            // 
            this.btnEthernet.Enabled = false;
            this.btnEthernet.Location = new System.Drawing.Point(4, 288);
            this.btnEthernet.Name = "btnEthernet";
            this.btnEthernet.Size = new System.Drawing.Size(178, 34);
            this.btnEthernet.TabIndex = 0;
            this.btnEthernet.Text = "Ethernet";
            this.btnEthernet.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.netDestIP);
            this.panel2.Controls.Add(this.labelNetDestIP);
            this.panel2.Controls.Add(this.netSourceIP);
            this.panel2.Controls.Add(this.labelNetSourceIP);
            this.panel2.Controls.Add(this.btnSetEthernet);
            this.panel2.Controls.Add(this.btnAddDataLink);
            this.panel2.Controls.Add(this.labelDestHardwareAddr);
            this.panel2.Controls.Add(this.destProtocolAddr);
            this.panel2.Controls.Add(this.destHardwareAddr);
            this.panel2.Controls.Add(this.labeldestProtocolAddr);
            this.panel2.Controls.Add(this.sourceProtocolAddr);
            this.panel2.Controls.Add(this.labelSourceProtocolAddr);
            this.panel2.Controls.Add(this.sourceHardwareAddr);
            this.panel2.Controls.Add(this.labelSourceHardwareAddr);
            this.panel2.Controls.Add(this.ethDestAddr);
            this.panel2.Controls.Add(this.ethSourceAddr);
            this.panel2.Controls.Add(this.labelDestination);
            this.panel2.Controls.Add(this.labelSource);
            this.panel2.Location = new System.Drawing.Point(205, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 324);
            this.panel2.TabIndex = 5;
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
            // btnAddDataLink
            // 
            this.btnAddDataLink.Location = new System.Drawing.Point(457, 238);
            this.btnAddDataLink.Name = "btnAddDataLink";
            this.btnAddDataLink.Size = new System.Drawing.Size(100, 20);
            this.btnAddDataLink.TabIndex = 13;
            this.btnAddDataLink.Text = "Add";
            this.btnAddDataLink.UseVisualStyleBackColor = true;
            this.btnAddDataLink.Visible = false;
            this.btnAddDataLink.Click += new System.EventHandler(this.btnAddDataLink_Click);
            // 
            // labelDestHardwareAddr
            // 
            this.labelDestHardwareAddr.AutoSize = true;
            this.labelDestHardwareAddr.Location = new System.Drawing.Point(233, 222);
            this.labelDestHardwareAddr.Name = "labelDestHardwareAddr";
            this.labelDestHardwareAddr.Size = new System.Drawing.Size(97, 13);
            this.labelDestHardwareAddr.TabIndex = 12;
            this.labelDestHardwareAddr.Text = "DestHardwareAddr";
            this.labelDestHardwareAddr.Visible = false;
            // 
            // destProtocolAddr
            // 
            this.destProtocolAddr.Location = new System.Drawing.Point(351, 238);
            this.destProtocolAddr.Name = "destProtocolAddr";
            this.destProtocolAddr.Size = new System.Drawing.Size(100, 20);
            this.destProtocolAddr.TabIndex = 11;
            this.destProtocolAddr.Visible = false;
            // 
            // destHardwareAddr
            // 
            this.destHardwareAddr.Location = new System.Drawing.Point(236, 238);
            this.destHardwareAddr.Name = "destHardwareAddr";
            this.destHardwareAddr.Size = new System.Drawing.Size(100, 20);
            this.destHardwareAddr.TabIndex = 9;
            this.destHardwareAddr.Visible = false;
            // 
            // labeldestProtocolAddr
            // 
            this.labeldestProtocolAddr.AutoSize = true;
            this.labeldestProtocolAddr.Location = new System.Drawing.Point(348, 222);
            this.labeldestProtocolAddr.Name = "labeldestProtocolAddr";
            this.labeldestProtocolAddr.Size = new System.Drawing.Size(90, 13);
            this.labeldestProtocolAddr.TabIndex = 10;
            this.labeldestProtocolAddr.Text = "DestProtocolAddr";
            this.labeldestProtocolAddr.Visible = false;
            // 
            // sourceProtocolAddr
            // 
            this.sourceProtocolAddr.Location = new System.Drawing.Point(122, 238);
            this.sourceProtocolAddr.Name = "sourceProtocolAddr";
            this.sourceProtocolAddr.Size = new System.Drawing.Size(108, 20);
            this.sourceProtocolAddr.TabIndex = 7;
            this.sourceProtocolAddr.Visible = false;
            // 
            // labelSourceProtocolAddr
            // 
            this.labelSourceProtocolAddr.AutoSize = true;
            this.labelSourceProtocolAddr.Location = new System.Drawing.Point(119, 222);
            this.labelSourceProtocolAddr.Name = "labelSourceProtocolAddr";
            this.labelSourceProtocolAddr.Size = new System.Drawing.Size(102, 13);
            this.labelSourceProtocolAddr.TabIndex = 6;
            this.labelSourceProtocolAddr.Text = "SourceProtocolAddr";
            this.labelSourceProtocolAddr.Visible = false;
            // 
            // sourceHardwareAddr
            // 
            this.sourceHardwareAddr.Location = new System.Drawing.Point(7, 238);
            this.sourceHardwareAddr.Name = "sourceHardwareAddr";
            this.sourceHardwareAddr.Size = new System.Drawing.Size(106, 20);
            this.sourceHardwareAddr.TabIndex = 5;
            this.sourceHardwareAddr.Visible = false;
            // 
            // labelSourceHardwareAddr
            // 
            this.labelSourceHardwareAddr.AutoSize = true;
            this.labelSourceHardwareAddr.Location = new System.Drawing.Point(4, 222);
            this.labelSourceHardwareAddr.Name = "labelSourceHardwareAddr";
            this.labelSourceHardwareAddr.Size = new System.Drawing.Size(109, 13);
            this.labelSourceHardwareAddr.TabIndex = 4;
            this.labelSourceHardwareAddr.Text = "SourceHardwareAddr";
            this.labelSourceHardwareAddr.Visible = false;
            // 
            // ethDestAddr
            // 
            this.ethDestAddr.Location = new System.Drawing.Point(122, 295);
            this.ethDestAddr.Name = "ethDestAddr";
            this.ethDestAddr.Size = new System.Drawing.Size(109, 20);
            this.ethDestAddr.TabIndex = 3;
            this.ethDestAddr.Text = "F4:06:69:06:DC:EF";
            // 
            // ethSourceAddr
            // 
            this.ethSourceAddr.Location = new System.Drawing.Point(7, 295);
            this.ethSourceAddr.Name = "ethSourceAddr";
            this.ethSourceAddr.Size = new System.Drawing.Size(106, 20);
            this.ethSourceAddr.TabIndex = 2;
            this.ethSourceAddr.Text = "30:3A:64:69:70:FD";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(119, 279);
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
            // netDestIP
            // 
            this.netDestIP.Location = new System.Drawing.Point(130, 141);
            this.netDestIP.Name = "netDestIP";
            this.netDestIP.Size = new System.Drawing.Size(100, 20);
            this.netDestIP.TabIndex = 18;
            this.netDestIP.Visible = false;
            // 
            // labelNetDestIP
            // 
            this.labelNetDestIP.AutoSize = true;
            this.labelNetDestIP.Location = new System.Drawing.Point(127, 125);
            this.labelNetDestIP.Name = "labelNetDestIP";
            this.labelNetDestIP.Size = new System.Drawing.Size(42, 13);
            this.labelNetDestIP.TabIndex = 17;
            this.labelNetDestIP.Text = "Dest IP";
            this.labelNetDestIP.Visible = false;
            // 
            // netSourceIP
            // 
            this.netSourceIP.Location = new System.Drawing.Point(7, 141);
            this.netSourceIP.Name = "netSourceIP";
            this.netSourceIP.Size = new System.Drawing.Size(108, 20);
            this.netSourceIP.TabIndex = 16;
            this.netSourceIP.Visible = false;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(4, 125);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(54, 13);
            this.labelNetSourceIP.TabIndex = 15;
            this.labelNetSourceIP.Text = "Source IP";
            this.labelNetSourceIP.Visible = false;
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
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Button btnListDevices;
        private System.Windows.Forms.Button btnSendPackets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTrasport;
        private System.Windows.Forms.Button btnTCP;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.Button btnICMP;
        private System.Windows.Forms.Label labelDataLink;
        private System.Windows.Forms.Button btnARP;
        private System.Windows.Forms.Label labelPhys;
        private System.Windows.Forms.Button btnEthernet;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.Button btnDNS;
        private System.Windows.Forms.Button btnIPV6;
        private System.Windows.Forms.Button btnIPV4;
        private System.Windows.Forms.Button btnIGMP;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.Button btnHTTP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox ethDestAddr;
        private System.Windows.Forms.TextBox ethSourceAddr;
        private System.Windows.Forms.TextBox sourceProtocolAddr;
        private System.Windows.Forms.Label labelSourceProtocolAddr;
        private System.Windows.Forms.TextBox sourceHardwareAddr;
        private System.Windows.Forms.Label labelSourceHardwareAddr;
        private System.Windows.Forms.TextBox destProtocolAddr;
        private System.Windows.Forms.Label labeldestProtocolAddr;
        private System.Windows.Forms.TextBox destHardwareAddr;
        private System.Windows.Forms.Label labelDestHardwareAddr;
        private System.Windows.Forms.ListBox listPacketLayers;
        private System.Windows.Forms.Label labelPacketEstructure;
        private System.Windows.Forms.Button btnAddDataLink;
        private System.Windows.Forms.Button btnSetEthernet;
        private System.Windows.Forms.Button btnRemovePacketLayer;
        private System.Windows.Forms.TextBox netDestIP;
        private System.Windows.Forms.Label labelNetDestIP;
        private System.Windows.Forms.TextBox netSourceIP;
        private System.Windows.Forms.Label labelNetSourceIP;
    }
}

