using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap1
{
    public partial class frmEX_Datetime : Form
    {
        public frmEX_Datetime()
        {
            InitializeComponent();
        }

        private void frmEX_Datetime_Load(object sender, EventArgs e)
        {
            cboStyle.Items.Add("d MMMM yyyy");
            cboStyle.Items.Add("dd/MM/yyyy");
            cboStyle.Items.Add("d M yyyy");
            cboStyle.Items.Add("MM, d, yyyy");
            cboStyle.Items.Add("dd-MM-yyyy");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtfIn;
            string dtstyle = "";
            if (optInvaraint.Checked)
            {
                dtfIn = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtfIn = DateTimeFormatInfo.CurrentInfo;
            }
            dtstyle = cboStyle.Text;
            lblDisplay.Text = dt.ToString(dtstyle, dtfIn);

        }

        private void btnFormat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnFormat.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
