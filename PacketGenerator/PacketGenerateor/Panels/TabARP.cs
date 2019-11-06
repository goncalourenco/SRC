using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Ethernet;
using System.Net;
using PcapDotNet.Base;

namespace PacketGenerateor.Panels
{
    public partial class TabARP : UserControl
    {
        private ListBox listPacketLayers;
        private MainForm mainForm;

        public TabARP()
        {
            InitializeComponent();
            
            sourceProtocolAddr.Text = "192.168.1.74";
            destProtocolAddr.Text = "192.168.1.47";
            destHardwareAddr.Text = sourceHardwareAddr.Text;
        }

        public TabARP(MainForm mainForm)
        {
            InitializeComponent();
            sourceProtocolAddr.Text = "192.168.1.74";
            destProtocolAddr.Text = "192.168.1.47";
            destHardwareAddr.Text = sourceHardwareAddr.Text;
            this.mainForm = mainForm;

        }

        private void btnAddDataLink_Click(object sender, EventArgs e)
        {
            try
            {
                ArpLayer arpLayer =
                new ArpLayer
                {
                    ProtocolType = EthernetType.IpV4,
                    Operation = ArpOperation.Request,
                    //SenderHardwareAddress = new byte[] { 3, 3, 3, 3, 3, 3 }.AsReadOnly(), // 03:03:03:03:03:03.
                    SenderHardwareAddress = sourceHardwareAddr.Text.Split(':').Select(x => Convert.ToByte(x, 16)).ToArray().AsReadOnly(), // 03:03:03:03:03:03.
                    //SenderProtocolAddress = new byte[] { 1, 2, 3, 4 }.AsReadOnly(), // 1.2.3.4.
                    SenderProtocolAddress = IPAddress.Parse(sourceProtocolAddr.Text).GetAddressBytes().AsReadOnly(), // 1.2.3.4.
                    //TargetHardwareAddress = new byte[] { 4, 4, 4, 4, 4, 4 }.AsReadOnly(), // 04:04:04:04:04:04.
                    TargetHardwareAddress = destHardwareAddr.Text.Split(':').Select(x => Convert.ToByte(x, 16)).ToArray().AsReadOnly(), // 04:04:04:04:04:04.
                    //TargetProtocolAddress = new byte[] { 11, 22, 33, 44 }.AsReadOnly(), // 11.22.33.44.
                    TargetProtocolAddress = IPAddress.Parse(destProtocolAddr.Text).GetAddressBytes().AsReadOnly(), // 11.22.33.44.
                };
                mainForm.addToPacket(arpLayer, "ARP -> " + sourceProtocolAddr.Text + " -> " + destProtocolAddr.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
            
            


        }

        private void btnGetMy_Click(object sender, EventArgs e)
        {
            sourceHardwareAddr.Text = mainForm.getMACAddress();

        }
    }
}
