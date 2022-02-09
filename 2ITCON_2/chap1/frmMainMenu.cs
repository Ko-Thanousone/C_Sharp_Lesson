using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void ສງຊສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ຂມນຜສະໜອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
