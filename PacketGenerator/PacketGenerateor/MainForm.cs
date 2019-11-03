using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
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
            fillNetworkList();
            fillTransportList();
            fillApplicationList();
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
            applications.Add(btnDNS);
            applications.Add(btnHTTP);
        }

        private void fillTransportList()
        {
            transport = new List<Button>();
            transport.Add(btnUDP);
            transport.Add(btnTCP);
        }

        private void fillNetworkList()
        {
            network = new List<Button>();
            network.Add(btnICMP);
            network.Add(btnIGMP);
            network.Add(btnIPV4);
            network.Add(btnIPV6);
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

        private void btnIPV4_Click(object sender, EventArgs e)
        {
            disableButtons(sender);

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
            if(sourceHardwareAddr.Visible == true)
            {
                sourceHardwareAddr.Text = getMACAddress();
            }
            ethSourceAddr.Text = getMACAddress();
        }

        private void btnARP_Click(object sender, EventArgs e)
        {
            List<Label> arpLabels = new List<Label>();
            List<TextBox> arpTextBoxes = new List<TextBox>();
            arpLabels.Add(labelSourceProtocolAddr);
            arpLabels.Add(labelSourceHardwareAddr);
            arpLabels.Add(labeldestProtocolAddr);
            arpLabels.Add(labelDestHardwareAddr);
            arpTextBoxes.Add(sourceProtocolAddr);
            arpTextBoxes.Add(sourceHardwareAddr);
            arpTextBoxes.Add(destHardwareAddr);
            arpTextBoxes.Add(destProtocolAddr);
            if (labelSourceProtocolAddr.Visible == false)
            {
                foreach (Label l in arpLabels)
                {
                    l.Visible = true;
                }
                foreach (TextBox l in arpTextBoxes)
                {
                    l.Visible = true;
                }
                btnAddDataLink.Visible = true;
            }
            else
            {
                foreach (Label l in arpLabels)
                {
                    l.Visible = false;
                }
                foreach (TextBox l in arpTextBoxes)
                {
                    l.Visible = false;
                }
                btnAddDataLink.Visible = false;

            }
            sourceHardwareAddr.Text = getMACAddress();
            sourceProtocolAddr.Text = "192.168.1.74";
            destProtocolAddr.Text = "192.168.1.47";
            destHardwareAddr.Text = sourceHardwareAddr.Text;

        }

        private string getMACAddress()
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

        private void btnAddDataLink_Click(object sender, EventArgs e)
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
            packetLayers.Add(arpLayer);
            listPacketLayers.Items.Add("ARP -> " + sourceProtocolAddr.Text + " -> " + destProtocolAddr.Text);

        }

        private void btnSetEthernet_Click(object sender, EventArgs e)
        {
            EthernetLayer ethernetLayer = new EthernetLayer
            {
                Source = new MacAddress(ethSourceAddr.Text),
                Destination = new MacAddress(ethDestAddr.Text)
            };
            packetLayers[0] = ethernetLayer;
            listPacketLayers.Items[0] = ("ETH -> " + ethernetLayer.ToString());
        }

        private void btnRemovePacketLayer_Click(object sender, EventArgs e)
        {
            if(listPacketLayers.SelectedIndex > 0)
            {
                listPacketLayers.Items.RemoveAt(listPacketLayers.SelectedIndex);
            }
        }
    }

}
