using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets;
using PcapDotNet.Base;
using PacketGenerateor.Panels.SubPanels;

namespace PacketGenerateor.Panels
{
    public partial class TabDNS : UserControl
    {
        private MainForm mainForm;

        public List<DnsQueryResourceRecord> Queries { get; set; }
        public List<DnsDataResourceRecord> Answers { get; set; }
        public List<DnsDataResourceRecord> Authorities { get; set; }
        public List<DnsDataResourceRecord> Additionals { get; set; }


        public TabDNS()
        {
            InitializeComponent();
        }

        public TabDNS(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            Queries = new List<DnsQueryResourceRecord>();
            Answers = new List<DnsDataResourceRecord>();
            Authorities = new List<DnsDataResourceRecord>();
            Additionals = new List<DnsDataResourceRecord>();

            foreach (var item in Enum.GetNames(typeof(DnsOpCode)))
            {
                cmbOpCode.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(DnsResponseCode)))
            {
                cmbResponseCode.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(DnsDomainNameCompressionMode)))
            {
                cmbCompression.Items.Add(item);
            }
            cmbCompression.SelectedIndex = 0;
            cmbOpCode.SelectedIndex = 0;
            cmbResponseCode.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DnsLayer layer = new DnsLayer
                {
                    Id = ushort.Parse(txtIdentification.Text),
                    IsResponse = ckResponse.Checked,
                    OpCode = (DnsOpCode)Enum.Parse(typeof(DnsOpCode), cmbOpCode.SelectedItem.ToString()),
                    IsAuthoritativeAnswer = ckAutoritativeAnswer.Checked,
                    IsTruncated = ckTruncated.Checked,
                    IsRecursionDesired = ckRecursionDesired.Checked,
                    IsRecursionAvailable = ckRecursionAvailable.Checked,
                    FutureUse = ckFutureUse.Checked,
                    IsAuthenticData = ckAuthenticData.Checked,
                    IsCheckingDisabled = ckCheckingDisabled.Checked,
                    ResponseCode = (DnsResponseCode)Enum.Parse(typeof(DnsResponseCode), cmbResponseCode.SelectedItem.ToString()),
                    Queries = Queries,
                    Answers = Answers,
                    Authorities = Authorities,
                    Additionals = Additionals,
                    DomainNameCompressionMode = (DnsDomainNameCompressionMode)Enum.Parse(typeof(DnsDomainNameCompressionMode), cmbCompression.SelectedItem.ToString()),
                };
                mainForm.addToPacket(layer, "DNS -> " + txtIdentification.Text + " -> " + cmbOpCode.SelectedItem.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }

        internal void addToAnswers(DnsDataResourceRecord record)
        {
            Answers.Add(record);
            listAnswers.Items.Add(record.DomainName);
        }

        internal void addToQueries(DnsQueryResourceRecord record)
        {
            Queries.Add(record);
            listQueries.Items.Add(record.DomainName);
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            Query query = new Query(this);
            query.Show();
        }

        private void btnRmQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Queries.RemoveAt(listQueries.SelectedIndex);
                listQueries.Items.Remove(listQueries.SelectedItem);

            }
            catch (Exception)
            {

            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer(this);
            answer.Show();
        }

        private void btnRmAuthorities_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }

        private void btnRmAnswers_Click(object sender, EventArgs e)
        {
            try
            {
                Answers.RemoveAt(listAnswers.SelectedIndex);
                listAnswers.Items.Remove(listAnswers.SelectedItem);
            }
            catch (Exception)
            {

            }
        }

        private void btnRmAdditional_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }
    }
}
