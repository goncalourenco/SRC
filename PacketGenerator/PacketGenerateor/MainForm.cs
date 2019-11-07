using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using PacketGenerateor.Panels;
using PacketGenerator;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.IpV4;

namespace PacketGenerateor
{
    public partial class MainForm : Form
    {
        private IList<LivePacketDevice> allDevices;
        private List<Button> network;
        private List<Button> transport;
        private List<Button> applications;
        private PacketDevice selectedDevice;
        private List<Object> packetLayers;
        public MainForm()
        {
            packetLayers = new List<object>();
            InitializeComponent();
            tabControl1.TabPages.Clear();
            addEthernetLayer();
        }

        private void addEthernetLayer()
        {
            EthernetLayer ethernetLayer = new EthernetLayer
            {
                Source = new MacAddress(ethSourceAddr.Text),
                Destination = new MacAddress(ethDestAddr.Text)
            };
            packetLayers.Add(ethernetLayer);
            listPacketLayers.Items.Add("ETH -> " + ethernetLayer.ToString());
        }

        private void fillApplicationList()
        {
            applications = new List<Button>();
        }

        private void fillTransportList()
        {
            transport = new List<Button>();
        }

        private void fillNetworkList()
        {
            network = new List<Button>();
        }

        private void btnListDevices_Click(object sender, EventArgs e)
        {
            allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                listDevices.Items.Add(device.Description);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }
        }

        private void btnSendPackets_Click(object sender, EventArgs e)
        {
            // Take the selected adapter
            selectedDevice = allDevices[listDevices.SelectedIndex];

            // Open the output device
            using (PacketCommunicator communicator = selectedDevice.Open(100, // name of the device
                                                                         PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                                                         1000)) // read timeout
            {
                // Supposing to be on ethernet, set mac source to 01:01:01:01:01:01
                MacAddress source = new MacAddress("30:3A:64:69:70:FD");

                // set mac destination to 02:02:02:02:02:02
                MacAddress destination = new MacAddress("F4:06:69:06:DC:EF");

                // Create the packets layers

                // Ethernet Layer
                EthernetLayer ethernetLayer = new EthernetLayer
                {
                    Source = source,
                    Destination = destination
                };

                // IPv4 Layer
                IpV4Layer ipV4Layer = new IpV4Layer
                {
                    Source = new IpV4Address("10.20.228.173"),
                    Ttl = 128,
                    // The rest of the important parameters will be set for each packet
                };

                // ICMP Layer
                IcmpEchoLayer icmpLayer = new IcmpEchoLayer();

                // Create the builder that will build our packets
                PacketBuilder builder = new PacketBuilder(ethernetLayer, ipV4Layer, icmpLayer);

                // Send 100 Pings to different destination with different parameters
                for (int i = 0; i != 100; ++i)
                {
                    // Set IPv4 parameters
                    ipV4Layer.CurrentDestination = new IpV4Address("10.20.229.46");
                    ipV4Layer.Identification = (ushort)i;

                    // Set ICMP parameters
                    icmpLayer.SequenceNumber = (ushort)i;
                    icmpLayer.Identifier = (ushort)i;

                    // Build the packet
                    Packet packet = builder.Build(DateTime.Now);

                    // Send down the packet
                    /*
                    while (true)
                    {
                        communicator.SendPacket(packet);
                    }*/
                }
                
                communicator.SendPacket(PcapLib.BuildEthernetPacket());
                communicator.SendPacket(PcapLib.BuildArpPacket());
                communicator.SendPacket(PcapLib.BuildVLanTaggedFramePacket());
                communicator.SendPacket(PcapLib.BuildIpV4Packet());
                communicator.SendPacket(PcapLib.BuildIpV6Packet());
                communicator.SendPacket(PcapLib.BuildIcmpPacket());
                communicator.SendPacket(PcapLib.BuildIgmpPacket());
                communicator.SendPacket(PcapLib.BuildGrePacket());
                communicator.SendPacket(PcapLib.BuildUdpPacket());
                communicator.SendPacket(PcapLib.BuildTcpPacket());
                communicator.SendPacket(PcapLib.BuildDnsPacket());
                communicator.SendPacket(PcapLib.BuildHttpPacket());
                communicator.SendPacket(PcapLib.BuildComplexPacket());
            }
        }

        internal void addToPacket(object layer, string v)
        {
            listPacketLayers.Items.Add(v);
            packetLayers.Add(layer);
        }

        private void btnIPV4_Click(object sender, EventArgs e)
        {
            disableButtons(sender);
            TabPage page = new TabPage("IPV4");
            page.Controls.Add(new TabIPV4(listPacketLayers));
            tabControl1.TabPages.Add(page);

        }

        private void disableButtons(object sender)
        {
            if (network.Contains((Button)sender))
            {
                foreach (Button btn in network)
                {
                    if (!btn.Equals(sender))
                    {
                        if (btn.Enabled == true)
                        {
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
            else if (applications.Contains((Button)sender))
            {
                foreach (Button btn in applications)
                {
                    if (!btn.Equals(sender))
                    {
                        if (btn.Enabled == true)
                        {
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
            else if (transport.Contains((Button)sender))
            {
                foreach (Button btn in transport)
                {
                    if (!btn.Equals(sender))
                    {
                        if (btn.Enabled == true)
                        {
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnIPV6_Click(object sender, EventArgs e)
        {
            disableButtons(sender);
        }

        private void btnIGMP_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

        }

        private void btnICMP_Click(object sender, EventArgs e)
        {
            disableButtons(sender);
        }

        private void btnUDP_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

        }

        private void btnTCP_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

        }

        private void btnHTTP_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

        }

        private void btnDNS_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

        }

        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDevice = allDevices[listDevices.SelectedIndex];
        }


        public string getMACAddress()
        {
            if(selectedDevice == null)
            {
                return string.Empty;
            }
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Id.Equals("{" + selectedDevice.Name.Split('{')[1]))
                {
                    String macAddr = string.Empty;
                    IPInterfaceProperties properties = ni.GetIPProperties();
                    int i = 0;
                    foreach (char ch in ni.GetPhysicalAddress().ToString())
                    {
                        i++;
                        macAddr += ch;
                        if(i%2 == 0 && i < ni.GetPhysicalAddress().ToString().Length)
                        {
                            macAddr += ":";
                        }
                    }
                    return macAddr;
                }
            }
            return string.Empty;
        }

        

        private void btnSetEthernet_Click(object sender, EventArgs e)
        {
            try
            {
                EthernetLayer ethernetLayer = new EthernetLayer
                {
                    Source = new MacAddress(ethSourceAddr.Text),
                    Destination = new MacAddress(ethDestAddr.Text)
                };
                packetLayers[0] = ethernetLayer;
                listPacketLayers.Items[0] = ("ETH -> " + ethernetLayer.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }

        private void btnRemovePacketLayer_Click(object sender, EventArgs e)
        {
            if(listPacketLayers.SelectedIndex > 0)
            {
                listPacketLayers.Items.RemoveAt(listPacketLayers.SelectedIndex);
                packetLayers.Remove(listPacketLayers.SelectedIndex);
            }
        }

        private void btnDataLink_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            TabPage page = new TabPage("ARP");
            page.Controls.Add(new TabARP(this));
            tabControl1.TabPages.Add(page);
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            TabPage page = new TabPage("IPV4");
            page.Controls.Add(new TabIPV4(this));
            tabControl1.TabPages.Add(page);
            TabPage page2 = new TabPage("IPV6");
            page2.Controls.Add(new TabIPV6(this));
            tabControl1.TabPages.Add(page2);
            TabPage page3 = new TabPage("ICMP");
            page3.Controls.Add(new TabICMP(this));
            tabControl1.TabPages.Add(page3);
            TabPage page4 = new TabPage("IGMP");
            page4.Controls.Add(new TabIGMP(this));
            tabControl1.TabPages.Add(page4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ethSourceAddr.Text = getMACAddress();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            TabPage page = new TabPage("TCP");
            page.Controls.Add(new TabTCP(this));
            tabControl1.TabPages.Add(page);
            TabPage page2 = new TabPage("UDP");
            page2.Controls.Add(new TabUDP(this));
            tabControl1.TabPages.Add(page2);
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            TabPage page = new TabPage("HTTP");
            page.Controls.Add(new TabHttp(this));
            tabControl1.TabPages.Add(page);
            TabPage page2 = new TabPage("DNS");
            page2.Controls.Add(new TabDNS(this));
            tabControl1.TabPages.Add(page2);
        }
    }

}
