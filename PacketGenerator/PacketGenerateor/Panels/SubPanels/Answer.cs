using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.IpV6;

namespace PacketGenerateor.Panels.SubPanels
{
    public partial class Answer : Form
    {
        private TabDNS tabDNS;

        public Answer()
        {
            InitializeComponent();
        }

        public Answer(TabDNS tabDNS)
        {
            this.tabDNS = tabDNS;
            InitializeComponent();
            foreach (var item in Enum.GetNames(typeof(DnsType)))
            {
                cmbType.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(DnsClass)))
            {
                cmbClass.Items.Add(item);
            }
            cmbDataType.Items.Add("Domain");
            cmbDataType.Items.Add("IPV4");
            cmbDataType.Items.Add("IPV6");
            cmbType.SelectedIndex = 0;
            cmbClass.SelectedIndex = 0;
            cmbDataType.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            object data = new DnsResourceDataDomainName(new DnsDomainName(txtData.Text));
            if (cmbDataType.SelectedIndex == 1)
            {
                data = new DnsResourceDataIpV4(new IpV4Address(txtData.Text));
            }
            else if (cmbDataType.SelectedIndex == 2)
            {
                data = new DnsResourceDataIpV6(new IpV6Address(txtData.Text));
            }
            DnsDataResourceRecord record = new DnsDataResourceRecord(
                                        new DnsDomainName(txtDomainName.Text),
                                        (DnsType)Enum.Parse(typeof(DnsType), cmbType.SelectedItem.ToString()),
                                        (DnsClass)Enum.Parse(typeof(DnsClass), cmbClass.SelectedItem.ToString())
                                        , int.Parse(txtTTL.Text),
                                        (DnsResourceData) data);
            tabDNS.addToAnswers(record);

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
