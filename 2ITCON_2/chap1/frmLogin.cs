using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chap1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=NOMPHONE;Initial Catalog=minipro;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEX_ifelse_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string sql = "select * from Account where username='" + username + "' and password='"+password+"'";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count !=0)
            {
                MessageBox.Show("ຍິນດີຕ້ອນຮັບທ່ານ" +username+ "ເຂົ້າສູ່ລະບົບ", "ຜົນການ Login");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();


            }
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ງານ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ", "ຜົນການ Login");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmEX_listbox f = new frmEX_listbox();
            f.Show();
            this.Hide();
        }
    }
}
