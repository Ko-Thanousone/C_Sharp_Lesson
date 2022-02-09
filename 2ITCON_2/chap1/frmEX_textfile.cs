using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace chap1
{
    public partial class frmEX_textfile : Form
    {
        public frmEX_textfile()
        {
            InitializeComponent();
        }

        private void frmEX_textfile_Load(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "( Text file .txt)|*.txt";
            opf.Title = opf.FileName;
            opf.Multiselect = false;
            opf.InitialDirectory = "C: \\";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblpathfile.Text = opf.FileName;
                    StreamReader sr = new StreamReader(lblpathfile.Text);
                    txtconten.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                { 
                    lblpathfile.Text = "";
                    MessageBox.Show("ເກີດຂໍ້ຜິດພາດບໍ່ສາມາດອ່ານຂໍ້ມູນໄດ້" + ex.Message);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdg = new SaveFileDialog();
            sfdg.Title = "ບັນທຶກຂໍ້ມູນ";
            sfdg.Filter = "(text file .txt)|*.txt";
            sfdg.FileName = lblpathfile.Text;
            if(sfdg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfdg.FileName, false);
                sw.WriteLine(txtconten.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("ບັນທຶກຂໍ້ມູນສໍາເລັດ");
            }
        }
    }
}
