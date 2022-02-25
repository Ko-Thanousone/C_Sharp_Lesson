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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=DESKTOP-7V1ATA4\SQL2012;Initial Catalog=miniPOCSDB;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            showData();
        }
        private void showData()
        {
            string sql = "select * from tbCustomers";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດລູກຄ້າ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ລູກຄ້າ";
            dataGridView1.Columns[2].HeaderText = "ທີ່ຢູ່";
            dataGridView1.Columns[3].HeaderText = "ເບີໂທລະສັບ";
        }

        private void clear()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txttel.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbCustomers values('" + txtid.Text + "',N'" + txtname.Text + "',N'"
               + txtaddress.Text + "',N'" + txttel.Text + "')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cin = dataGridView1.CurrentRow.Index;
            txtid.Text = dataGridView1.Rows[cin].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[cin].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[cin].Cells[2].Value.ToString();
            txttel.Text = dataGridView1.Rows[cin].Cells[3].Value.ToString();
            
            
        }

        private void brndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from tbCustomers where cust_id = '" + txtid.Text + "'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                showData();
                clear();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string sql = "update tbCustomers set cust_Name=N'" + txtname.Text + "', cust_Address=N'" + txtaddress.Text + "', telephone='" + txttel.Text + "' where cust_id = '" + txtid.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
