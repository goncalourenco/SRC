using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Icmp;

namespace PacketGenerateor.Panels
{
    public partial class TabICMP : UserControl
    {
        private MainForm mainForm;

        public TabICMP()
        {
            InitializeComponent();
        }

        public TabICMP(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

                IcmpEchoLayer icmpLayer =
                    new IcmpEchoLayer
                    {
                        Checksum = checksum, // Will be filled automatically.
                        Identifier = ushort.Parse(txtidentification.Text),
                        SequenceNumber = ushort.Parse(txtSequence.Text),

                    };
                mainForm.addToPacket(icmpLayer, "ICMP -> " + txtidentification.Text + " -> " + txtSequence.Text);
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
