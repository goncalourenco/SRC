using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Igmp;
using PcapDotNet.Packets.IpV4;

namespace PacketGenerateor.Panels
{
    public partial class TabIGMP : UserControl
    {
        private MainForm mainForm;

        public TabIGMP()
        {
            InitializeComponent();
        }

        public TabIGMP(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtSourceIP.Text = "192.168.1.1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IgmpQueryVersion1Layer igmpLayer =
                    new IgmpQueryVersion1Layer
                    {
                        GroupAddress = new IpV4Address(txtSourceIP.Text),
                    };
                mainForm.addToPacket(igmpLayer, "ICMP -> " + txtSourceIP.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }
    }
}
