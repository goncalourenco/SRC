using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Packets.Http;
using PcapDotNet.Packets;

namespace PacketGenerateor.Panels
{
    public partial class TabHttp : UserControl
    {
        private MainForm mainForm;

        public TabHttp()
        {
            InitializeComponent();
        }

        public TabHttp(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtBody.Text = "Sample Text";
            txtURI.Text = "ipleiria.pt";
            cmbVersion.Items.Add("Version 1");
            cmbVersion.Items.Add("Version 1.1");
            cmbVersion.SelectedIndex = 0;

            foreach (var item in Enum.GetNames(typeof(HttpRequestKnownMethod)))
            {
                cmbMethod.Items.Add(item);
            }
            cmbMethod.SelectedIndex = 1;
        }

        private void btnAddDataLink_Click(object sender, EventArgs e)
        {
            try
            {
                HttpRequestLayer httpLayer =
                    new HttpRequestLayer
                    {
                        Version = cmbVersion.SelectedIndex == 0 ? HttpVersion.Version10 : HttpVersion.Version11,
                        Header = new HttpHeader(new HttpContentLengthField((uint)txtBody.Text.Length)),
                        Body = new Datagram(Encoding.ASCII.GetBytes(txtBody.Text)),
                        Method = new HttpRequestMethod((HttpRequestKnownMethod)Enum.Parse(typeof(HttpRequestKnownMethod), cmbMethod.SelectedItem.ToString())),
                        Uri = @txtBody.Text,
                    };
                mainForm.addToPacket(httpLayer, "HTTP -> " + cmbMethod.SelectedItem.ToString() + " -> " + txtURI.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Parameters");
            }
        }
    }
}
