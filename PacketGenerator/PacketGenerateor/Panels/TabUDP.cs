using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Transport;

namespace PacketGenerateor.Panels
{
    public partial class TabUDP : UserControl
    {
        private MainForm mainForm;

        public TabUDP()
        {
            InitializeComponent();
        }

        public TabUDP(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            txtSourcePort.Text = "4050";
            txtDestPort.Text = "53";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ushort? checksum = null;
                if (txtCheckSum.Enabled == true)
                {
                    checksum = ushort.Parse(txtCheckSum.Text);
                }

                UdpLayer udpLayer =
                    new UdpLayer
                    {
                        SourcePort = ushort.Parse(txtSourcePort.Text),
                        DestinationPort = ushort.Parse(txtDestPort.Text),
                        Checksum = checksum, // Will be filled automatically.
                        CalculateChecksumValue = checkBoxCalculateSum.Checked,
                    };
                mainForm.addToPacket(udpLayer, "UDP -> " + txtSourcePort.Text + " -> " + txtDestPort.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");

            }
        }

        private void checkBoxCheckSum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckSum.Checked)
            {
                txtCheckSum.Enabled = false;
            }
            else
            {
                txtCheckSum.Enabled = true;
            }
        }
    }
}
