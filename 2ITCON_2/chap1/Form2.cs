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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        const float PI = 3.14f;
        private void button1_Click(object sender, EventArgs e)
        {
            float Raduis, Area;
            Raduis = float.Parse(txtRaduis.Text);
            Area = PI * (Raduis * Raduis);
            txtArea.Text = Area.ToString();
            //MessageBox.Show("ເນື້ອທີ່ຮູບວົງມົນ: " + Area);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtRaduis.Focus();
        }

        private void btncalculat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btncalculat.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
