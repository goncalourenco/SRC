using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PacketGenerator;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.IpV4;

namespace PacketGenerateor
{
    public partial class MainForm : Form
    {
        private IList<LivePacketDevice> allDevices;
        public MainForm()
        {
            InitializeComponent();
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
            PacketDevice selectedDevice = allDevices[listDevices.SelectedIndex];

            // Open the output device
            using (PacketCommunicator communicator = selectedDevice.Open(100, // name of the device
                                                                         PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                                                         1000)) // read timeout
            {
                // Supposing to be on ethernet, set mac source to 01:01:01:01:01:01
                MacAddress source = new MacAddress("01:01:01:01:01:01");

                // set mac destination to 02:02:02:02:02:02
                MacAddress destination = new MacAddress("02:02:02:02:02:02");

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
                    Source = new IpV4Address("1.2.3.4"),
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
                    ipV4Layer.CurrentDestination = new IpV4Address("2.3.4." + i);
                    ipV4Layer.Identification = (ushort)i;

                    // Set ICMP parameters
                    icmpLayer.SequenceNumber = (ushort)i;
                    icmpLayer.Identifier = (ushort)i;

                    // Build the packet
                    Packet packet = builder.Build(DateTime.Now);

                    // Send down the packet
                    communicator.SendPacket(packet);
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
    }
}
