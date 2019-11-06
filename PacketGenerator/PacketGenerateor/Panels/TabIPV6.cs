using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.mainForm = mainForm;
        }
    }
}
