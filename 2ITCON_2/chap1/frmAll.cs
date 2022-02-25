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
    public partial class frmAll : Form
    {
        public frmAll()
        {
            InitializeComponent();
        }

        private void btncalculat_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmDT = new frmEX_Datetime();
            frmDT.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmie = new frmLogin();
            frmie.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frmlv = new frmEX_listview();
            frmlv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frmtf = new frmEX_textfile();
            frmtf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frmMM = new frmMainMenu();
            frmMM.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ex3 = new Exercise3();
            ex3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form ex2 = new Exercise2_New();
            ex2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form ex1 = new Exercise1();
            ex1.Show();
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form frmlb = new frmEX_listbox();
            frmlb.Show(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frmDB = new frmEX_ConDB();
            frmDB.Show();
        }
    }
}
