using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap1
{
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        Splitter splitter = new Splitter();

        private void testdata_Load(object sender, EventArgs e)
        {
            ColumnHeader colfirst = lsvData.Columns.Add("ຊື່", 200, HorizontalAlignment.Center);
            ColumnHeader colsecond = lsvData.Columns.Add("ນາມສະກຸນ", 300, HorizontalAlignment.Center);

            System.IO.StreamReader file = new System.IO.StreamReader("testData.txt");

            //set list view in details mode
            lsvData.View = View.Details;

            string line = "";
            //read text file line by line.     
            while (( line = file.ReadLine()) != null)
            {
                var item = new ListViewItem(new[] { line.ToString().Split(',')[0].ToString(), line.ToString().Split(',')[1].ToString()
                  });
                lsvData.Items.Add(item);

            }
            file.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text != "" && txtjob.Text != "")
            {
                string[] anyitem = new string[] { txtfullname.Text, txtjob.Text };
                ListViewItem lvi = new ListViewItem(anyitem);
                lsvData.Items.Add(lvi);
                txtfullname.Text = "";
                txtjob.Clear();
               
            }
            txtfullname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= lsvData.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvData.SelectedItems[i];
                lsvData.Items.Remove(lvi);
            }
            txtfullname.Focus();
        }

        private void btsavedata_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "ບັນທຶກໄຟລ";
            sfd.Filter = "ໄຟລຂໍ້ມູນ (.txt) | *.txt";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (ListViewItem item in lsvData.Items)
                        {
                            sw.WriteLine("{0},{1} {2}", item.SubItems[0].Text, splitter, item.SubItems[1].Text);
                             
                        }
                    }
                    MessageBox.Show("ບັນທຶກຮຽບຮ້ອຍເເລ້ວ", "ເເຈ້ງເຕືອນ");
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

        private void lsvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvData.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvData.SelectedItems[0];
                txtfullname.Text = item.SubItems[0].Text;
                txtjob.Text = item.SubItems[1].Text;
            }
            else
            {
                txtfullname.Text = string.Empty;
                txtjob.Text = string.Empty;
            }
            
        }
    }
}
