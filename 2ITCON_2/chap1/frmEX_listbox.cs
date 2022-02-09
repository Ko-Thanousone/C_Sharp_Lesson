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
    public partial class frmEX_listbox : Form
    {
        public frmEX_listbox()
        {
            InitializeComponent();
        }
        int indexToSelect = 0;

        private void frmEX_listbox_Load(object sender, EventArgs e)
        {
            lstData.Items.Add("ເເຂວງ ຜົ້ງສາລີ");
            lstData.Items.Add("ເເຂວງ ຫຼວງນໍ້າທາ");
            lstData.Items.Add("ເເຂວງ ບໍ່ເເກ້ວ");
            lstData.Items.Add("ເເຂວງ ຫົວພັນ");
            lstData.Items.Add("ເເຂວງ ຫຼວງພະບາງ");
            lstData.Items.Add("ເເຂວງ ຊຽງຂວາງ");
            lstData.SelectedIndex = 0;
            lblCount.Text = "ຈໍານວນລາຍການ : " + lstData.Items.Count.ToString();
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

        private void btnup_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedIndex > 0) {
                lstData.SelectedIndex--;
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
        string ListToSelect;
        indexToSelect = lstData.SelectedIndex;
        ListToSelect = (string)lstData.SelectedItem;
        txtData. Text = ListToSelect;
        txtData.Focus();
        txtData.SelectAll();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedIndex < lstData.Items.Count-1)
            {
                lstData.SelectedIndex++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim() != "") {
                if (lstData.FindString(txtData.Text, -1) < 0)
                {
                    lstData.Items.Add(txtData.Text);
                    lstData.Text = "";
                    lstData.Focus();
                }
                else {
                    MessageBox.Show("ຂໍ້ມູນທີ່ເພີ່ມເຂົ້າໄປ ມີຢູ່ໃນລາຍການແລ້ວ !!!", "ຜົນການກວດສອບ");
                }
                lblCount.Text = "ຈໍານວນລາຍການ : " + lstData.Items.Count.ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedIndex != 1) {
                lstData.Items[indexToSelect] = txtData.Text.Trim();
            }
            lblCount.Text = "ຈໍານວນລາຍການ : " + lstData.Items.Count.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedIndex != 1) {
                lstData.Items.RemoveAt(indexToSelect);
            }
            lblCount.Text = "ຈໍານວນລາຍການ : " + lstData.Items.Count.ToString();
        }
        
    }
}
