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
    public partial class frmEX_ConDB : Form
    {
        public frmEX_ConDB()
        {
            InitializeComponent();
        }

        private void frmEX_ConDB_Load(object sender, EventArgs e)
        {
            //connect database 1
            string strConn = @"Data Source=DESKTOP-7V1ATA4\SQL2012;Initial Catalog=miniPOCSDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sql = "select * from tbSupplier";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();

            //connect database 2
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            //connect database 3
            string strConn1 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2012\Projects\2ITCON_2\chap1\minPOdb.mdf;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strConn1);
            conn1.Open();
            string sql1 = "select * from tbSupplier";
            SqlCommand cmd1 = new SqlCommand(sql, conn1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            dataGridView3.DataSource = dt1;
            conn1.Close();
        }
    }
}
