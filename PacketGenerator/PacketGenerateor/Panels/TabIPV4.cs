using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.IpV4;

namespace PacketGenerateor.Panels
{
    public partial class TabIPV4 : UserControl
    {
        private ListBox listPacketLayers;
        private MainForm mainForm;

        public TabIPV4()
        {
            InitializeComponent();

        }

        public TabIPV4(ListBox listPacketLayers)
        {
            InitializeComponent();
            this.listPacketLayers = listPacketLayers;
        }

        public TabIPV4(MainForm mainForm)
        {
            InitializeComponent();

            netSourceIP.Text = "192.168.1.1";
            netDestIP.Text = "192.168.1.2";
            this.mainForm = mainForm;
            foreach (var item in Enum.GetNames(typeof(IpV4Protocol)))
            {
                cmbIPV4Protocols.Items.Add(item);
            }
            cmbIPV4Protocols.SelectedIndex = 17;
        }

        private void checkBoxCheckSum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckSum.Checked)
            {
                networkCheckSum.Enabled = false;
            }
            else
            {
                networkCheckSum.Enabled = true;

            }
        }

        private void cmbIPV4Protocols_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ushort? checksum = null;
                if (networkCheckSum.Enabled == true)
                {
                    checksum = ushort.Parse(networkCheckSum.Text);
                }


                IpV4Layer ipV4Layer =
                            new IpV4Layer
                            {
                                Source = new IpV4Address(netSourceIP.Text),
                                CurrentDestination = new IpV4Address(netDestIP.Text),
                                Fragmentation = IpV4Fragmentation.None,
                                HeaderChecksum = checksum, // Will be filled automatically.
                                Identification = ushort.Parse(identification.Text),
                                Options = IpV4Options.None,
                                Protocol = null, // Will be filled automatically.
                                Ttl = byte.Parse(networkTTL.Text),
                                TypeOfService = byte.Parse(networkTOS.Text),
                            };
                if (cmbIPV4Protocols.Enabled)
                {
                    ipV4Layer.Protocol = (IpV4Protocol)Enum.Parse(typeof(IpV4Protocol), cmbIPV4Protocols.SelectedIndex.ToString());
                }
                mainForm.addToPacket(ipV4Layer, "IPv4 -> " + netSourceIP.Text + " -> " + netDestIP.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbIPV4Protocols.Enabled = false;
            }
            else
            {
                cmbIPV4Protocols.Enabled = true;

            }
        }
    }
}
