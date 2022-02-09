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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Fullname = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            string Fname = "ko"; string Lname = "Thanousone";
            for (int i=0; i <= 3; i++)
            {
                MessageBox.Show(Fname +  " " + Lname + " " + i, "FullName");  
            }
            
            Fullname = Fname + " " + Lname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Fullname, "Fullname");
            
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
