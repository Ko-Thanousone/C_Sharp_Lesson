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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }
        string strConn = @"Data Source=DESKTOP-7V1ATA4\SQL2012;Initial Catalog=miniPOCSDB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            showData();

        }

        private void showData()
        {
            string sql = "select * from tbSupplier";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດຜູ້ສະໜອງ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ຜູ້ສະໜອງ";
            dataGridView1.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
            dataGridView1.Columns[3].HeaderText = "ທີ່ຢູ່";
            dataGridView1.Columns[4].HeaderText = "ເບີໂທຕິດຕໍ່";
        }
        private void clear() {
            txtSupID.Clear();
            txtSupName.Clear();
            txtContrName.Clear();
            txtAddress.Clear();
            txtTel.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbSupplier values('"+txtSupID.Text+"',N'"+txtSupName.Text+"',N'"+txtContrName.Text+"',N'"+
                txtAddress.Text+"','"+txtTel.Text+"')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update tbSupplier set supplierName=N'"+txtSupName.Text+
                "', contractName=N'"+txtContrName.Text+"', address=N'"+txtAddress.Text+"', telephone='"+txtTel.Text+
                "' where supplierID='" + txtSupID.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Question",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from tbSupplier where supplierID='"+txtSupID.Text+"'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                showData();
                clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cin = dataGridView1.CurrentRow.Index;
            txtSupID.Text = dataGridView1.Rows[cin].Cells[0].Value.ToString();
            txtSupName.Text = dataGridView1.Rows[cin].Cells[1].Value.ToString();
            txtContrName.Text = dataGridView1.Rows[cin].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[cin].Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.Rows[cin].Cells[4].Value.ToString();
        }

        
    }
}
