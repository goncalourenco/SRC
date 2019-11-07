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

namespace PacketGenerateor.Panels.SubPanels
{
    public partial class Query : Form
    {
        private TabDNS tabDNS;

        public Query()
        {
            InitializeComponent();
        }

        public Query(TabDNS tabDNS)
        {
            InitializeComponent();
            this.tabDNS = tabDNS;
            foreach (var item in Enum.GetNames(typeof(DnsType)))
            {
                cmbType.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(DnsClass)))
            {
                cmbClass.Items.Add(item);
            }
            cmbType.SelectedIndex = 0;
            cmbClass.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DnsQueryResourceRecord record = new DnsQueryResourceRecord(
                                            new DnsDomainName(txtDomainName.Text),
                                            (DnsType)Enum.Parse(typeof(DnsType), cmbType.SelectedItem.ToString()),
                                            (DnsClass)Enum.Parse(typeof(DnsClass), cmbClass.SelectedItem.ToString()));

                tabDNS.addToQueries(record);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
