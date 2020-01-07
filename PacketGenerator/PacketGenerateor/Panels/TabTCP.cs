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
    public partial class TabTCP : UserControl
    {
        private MainForm mainForm;

        public TabTCP()
        {
            InitializeComponent();
        }

        public TabTCP(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            txtSourcePort.Text = "4050";
            txtDestPort.Text = "25";
            txtSequenceN.Text = "100";
            txtAckN.Text = "50";
            txtWindow.Text = "100";
            txtUrgentPointer.Text = "0";
            foreach (var item in Enum.GetNames(typeof(TcpControlBits)))
            {
                cmbControlBits.Items.Add(item);
            }
            cmbControlBits.SelectedIndex = 5;
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

                TcpLayer tcpLayer =
                    new TcpLayer
                    {
                        SourcePort = ushort.Parse(txtSourcePort.Text),
                        DestinationPort = ushort.Parse(txtDestPort.Text),
                        Checksum = checksum, // Will be filled automatically.
                        SequenceNumber = uint.Parse(txtSequenceN.Text),
                        AcknowledgmentNumber = uint.Parse(txtAckN.Text),
                        ControlBits = getControlBits(),
                        Window = ushort.Parse(txtWindow.Text),
                        UrgentPointer = ushort.Parse(txtUrgentPointer.Text),
                        Options = TcpOptions.None,
                    };
                mainForm.addToPacket(tcpLayer, "TCP -> " + txtSourcePort.Text + " -> " + txtDestPort.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }

        private TcpControlBits getControlBits()
        {
            return (TcpControlBits)Enum.Parse(typeof(TcpControlBits), cmbControlBits.SelectedItem.ToString());
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
