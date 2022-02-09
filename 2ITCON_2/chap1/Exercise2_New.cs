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
    public partial class Exercise2_New : Form
    {
        double fstNum, secNum;
        String oper;
      //  bool isOperPerformed = false;
        public Exercise2_New()
        {
            InitializeComponent();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0")) //|| (isOperPerformed))
                txtResult.Clear();

           // isOperPerformed = false;
            Button button=(Button)sender;


            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;
            }
            else
                txtResult.Text = txtResult.Text + button.Text;
        
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            secNum = double.Parse(txtResult.Text);
          //  isOperPerformed = true;

             switch (oper)
             {
                 case "+":
                     txtResult.Text = (fstNum + secNum).ToString();
                     break;
                 case "-":
                     txtResult.Text = (fstNum - secNum).ToString();
                     break;
                 case "*":
                     txtResult.Text = (fstNum * secNum).ToString();
                     break;
                 case "/":
                     txtResult.Text = (fstNum / secNum).ToString();
                     break;

                 default:
                     break;
             }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtResult.Text);
            oper = "+";
            label2.Text = fstNum.ToString() + " " + oper;
            txtResult.Text = "";
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtResult.Text);
            oper = "-";
            label2.Text = fstNum.ToString() + " " + oper;
            txtResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtResult.Text);
            oper = "*";
            label2.Text = fstNum.ToString() + " " + oper;
            txtResult.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtResult.Text);
            oper = "/";
            label2.Text = fstNum.ToString() + " " + oper;
            txtResult.Text = "";
        }

        private void btnMot_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtResult.Text);
            oper = "%";
            txtResult.Text = (fstNum/100).ToString();
        }

        private void Exercise2_New_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            label2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
                label2.Text = "";
            }
        }
    }
}
