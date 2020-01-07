using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.IpV6;
using PcapDotNet.Packets.IpV4;

namespace PacketGenerateor.Panels
{
    public partial class TabIPV6 : UserControl
    {
        private MainForm mainForm;

        public TabIPV6()
        {
            InitializeComponent();
        }

        public TabIPV6(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtsource.Text = "0123:4567:89AB:CDEF:0123:4567:89AB:CDEF";
            txtdestination.Text = "FEDC:BA98:7654:3210:FEDC:BA98:7654:3210";
            txtflowlabel.Text = "123";
            txthoplimit.Text = "100";

            foreach (var item in Enum.GetNames(typeof(IpV4Protocol)))
            {
                cmbINextHeader.Items.Add(item);
            }
            cmbINextHeader.SelectedIndex = 17;

        }

        private void btnAddDataLink_Click(object sender, EventArgs e)
        {
            try
            {
                IpV6Layer ipV6Layer =
                    new IpV6Layer
                    {
                        Source = new IpV6Address(txtsource.Text),
                        CurrentDestination = new IpV6Address(txtdestination.Text),
                        FlowLabel = Int16.Parse(txtflowlabel.Text),
                        HopLimit = byte.Parse(txthoplimit.Text),
                        NextHeader = null,
                    };
                if (cmbINextHeader.Enabled)
                {
                    ipV6Layer.NextHeader = (IpV4Protocol)Enum.Parse(typeof(IpV4Protocol), cmbINextHeader.SelectedIndex.ToString());
                }
                mainForm.addToPacket(ipV6Layer, "IPv6 -> " + txtsource.Text + " -> " + txtdestination.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }
    }
}
