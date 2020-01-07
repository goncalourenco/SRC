using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Base;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace PacketGenerateor
{
    public partial class UDPFlowForm : Form
    {
        public PacketCommunicator Communicator { get; set; }
        public UDPFlowForm()
        {
            InitializeComponent();
            cmbEthType.SelectedIndex = 0;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int numberOfPackets = Convert.ToInt32(numberPacketsUpDown.Value);
            List<Layer> packetLayers;
            EthernetLayer ethernetLayer;
            Random random = new Random();

            for (int i = 0; i < numberOfPackets; i++)
            {
                bool isSwap = random.Next(0, 2) == 1; //0 ou 1
                packetLayers = new List<Layer>();
                if (checkboxSwap.Checked && isSwap)
                {
                    ethernetLayer = new EthernetLayer
                    {
                        Source = new MacAddress(ethDestAddr.Text),
                        Destination = new MacAddress(ethSourceAddr.Text) ,
                        EtherType = (EthernetType)Enum.Parse(typeof(EthernetType), cmbEthType.SelectedItem.ToString()),
                    };
                    packetLayers.Add(ethernetLayer);
                }
                else
                {
                    ethernetLayer = new EthernetLayer
                    {
                        Source = new MacAddress(ethSourceAddr.Text),
                        Destination = new MacAddress(ethDestAddr.Text),
                        EtherType = (EthernetType)Enum.Parse(typeof(EthernetType), cmbEthType.SelectedItem.ToString()),
                    };
                    packetLayers.Add(ethernetLayer);
                }
                

                IpV4Layer ipV4Layer = new IpV4Layer
                {
                    Source = new IpV4Address(netSourceIP.Text),
                    CurrentDestination = new IpV4Address(netDestIP.Text),
                    Fragmentation = IpV4Fragmentation.None,
                    HeaderChecksum = null, // Will be filled automatically.
                    Identification = 1,//ushort.Parse(identification.Text),
                    Options = IpV4Options.None,
                    Protocol = null, // Will be filled automatically.
                    Ttl = byte.Parse("1000"),//byte.Parse(networkTTL.Text),
                    TypeOfService = byte.Parse("0")
                };
            }    
        }
    }
}
