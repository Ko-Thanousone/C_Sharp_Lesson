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
    public partial class frmProductType : Form
    {
        public frmProductType()
        {
            InitializeComponent();
        }
        string strConn = @"Data Source=DESKTOP-7V1ATA4\SQL2012;Initial Catalog=miniPOCSDB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        private void frmProductType_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            showData();
        }
        private void showData()
        {
            string sql = "select * from tbProType";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດປະເພດສິນຄ້າ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ປະເພດສິນຄ້າ";
        }
        private void clear()
        {
            txtPtTypeID.Clear();
            txtPtTypeName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbProType values('" + txtPtTypeID.Text + "',N'" + txtPtTypeName.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update tbProType set ProTypeName=N'"+txtPtTypeName.Text+
                "' where ProType_id='" + txtPtTypeID.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            showData();
            clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cin = dataGridView1.CurrentRow.Index;
            txtPtTypeID.Text = dataGridView1.Rows[cin].Cells[0].Value.ToString();
            txtPtTypeName.Text = dataGridView1.Rows[cin].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from tbProType where ProType_id='" + txtPtTypeID.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                showData();
                clear();
            }
        }
    }
}
