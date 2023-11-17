using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bansach
{
    public partial class FormHoadon : Form
    {
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void FormHoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bansachDataSet17.hoadon3' table. You can move, or remove it, as needed.
            this.hoadon3TableAdapter.Fill(this.bansachDataSet17.hoadon3);

        }
    }
}
