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
    public partial class frmEX_listview : Form
    {
        public frmEX_listview()
        {
            InitializeComponent();
        }

        private void frmEX_listview_Load(object sender, EventArgs e)
        {
            ColumnHeader colfirst = lsvData.Columns.Add("ຊື່",200,HorizontalAlignment.Center);
            ColumnHeader colsecond = lsvData.Columns.Add("ນາມສະກຸນ",200,HorizontalAlignment.Center);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtfrisname.Text != "" && txtlastname.Text != "")
            {
                string[] anyitem = new string[] { txtfrisname.Text, txtlastname.Text };
                ListViewItem lvi = new ListViewItem(anyitem);
                lsvData.Items.Add(lvi);
                txtfrisname.Text = "";
                txtlastname.Clear();
                txtfrisname.Focus();
            }
            txtfrisname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= lsvData.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvData.SelectedItems[i];
                lsvData.Items.Remove(lvi);
            }
            txtfrisname.Focus();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lsvData.Items.Clear();
            txtfrisname.Focus();
        }

        private void frmEX_listview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                for (int i = 0; i <= lsvData.SelectedItems.Count - 1; i++)
                {
                    ListViewItem lvi = lsvData.SelectedItems[i];
                    lsvData.Items.Remove(lvi);
                }
            }
           
        }

        private void btn_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            ControlPaint.DrawBorder(e.Graphics, button.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
