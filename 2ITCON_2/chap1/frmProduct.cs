using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // ປະກາດເພື່ອເອີ້ນໃຊ້ຖານຂໍ້ມູນ
using System.IO;  // ປະກາດເພື່ອເອີ້ນໃຊ້ MemoryStream

namespace chap1
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=DESKTOP-7V1ATA4\SQL2012;Initial Catalog=miniPOCSDB;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            string sql = "select * from tbProType";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbotype.DataSource = dt;
            cbotype.DisplayMember = "ProTypeName";
            cbotype.ValueMember = "ProType_id";
            showData("");
        }
        private void showData(string str)
        {
            string sqlstr = "";
            if (str != "")
            {
                //sqlstr = "selete * from Product";
                sqlstr = "where ProID like '" + str + "%' or ProName like N'" + str + "%'";
            }
            string sql = "select * from Product" + sqlstr;
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            dataGridView1.Columns[2].HeaderText = "ຈໍານວນ";
            dataGridView1.Columns[3].HeaderText = "ລາຄາ";
            dataGridView1.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            dataGridView1.Columns[5].HeaderText = "ຈໍານວນຄົງເຫຼືອ";
            dataGridView1.Columns[6].HeaderText = "ປະເພດ";
            dataGridView1.Columns[7].HeaderText = "ປະເພດສິນຄ້າ";
        }

        private void clear()
        {
            txtproid.Clear();
            txtproname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtunit.Clear();
            txtstock.Clear();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("ກະລຸນາເລືອກຮູບກ່ອນ");
                return;
            }

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imgbt = ms.GetBuffer();

            string sql = "insert into Product values('" + txtproid.Text + "',N'" + txtproname.Text + "','"
                + txtqty.Text + "','" + txtprice.Text + "',N'" + txtunit.Text + "','"
                + txtstock.Text + "','" + cbotype.SelectedValue + "',@img)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@img", imgbt);
            cmd.ExecuteNonQuery();
            showData("");
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Product where ProID = '" + txtproid.Text + "'";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                showData("");
                clear();
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("ກະລຸນາເລືອກຮູບກ່ອນ");
                return;
            }

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imgbt = ms.GetBuffer();

            string sql = "update Product set ProName=N'" + txtproname.Text + "', Quantity='" + txtqty.Text
                + "', Unitprice='" + txtprice.Text + "', Unit=N'" + txtunit.Text + "' , Linstock='" + txtstock.Text
                 + "' , ProTypeID='" + cbotype.SelectedValue + "',pro_img=@img  where ProID = '" + txtproid.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@img", imgbt);
            cmd.ExecuteNonQuery();
            showData("");
            clear();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int cin = dataGridView1.CurrentRow.Index;
            txtproid.Text = dataGridView1.Rows[cin].Cells[0].Value.ToString();
            txtproname.Text = dataGridView1.Rows[cin].Cells[1].Value.ToString();
            txtqty.Text = dataGridView1.Rows[cin].Cells[2].Value.ToString();
            txtprice.Text = dataGridView1.Rows[cin].Cells[3].Value.ToString();
            txtunit.Text = dataGridView1.Rows[cin].Cells[4].Value.ToString();
            txtstock.Text = dataGridView1.Rows[cin].Cells[5].Value.ToString();
            cbotype.SelectedValue = dataGridView1.Rows[cin].Cells[6].Value.ToString();
            var obimg = (byte[])dataGridView1.Rows[cin].Cells[7].Value;
            MemoryStream ms = new MemoryStream(obimg);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "(Image Type *.jpg;*.gif; *.png)|.jpg;*.gif; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            showData(txtsearch.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
