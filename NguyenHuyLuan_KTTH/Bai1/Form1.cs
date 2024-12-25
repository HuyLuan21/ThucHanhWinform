using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Load_data()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI\\MSI;Initial Catalog=SACH;User ID=sa;Password=1234;");
            SqlDataAdapter da = new SqlDataAdapter("select * from Products", con);
            DataTable tb = new DataTable();
            da.Fill(tb); dataGridView1.DataSource = tb;

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "productcode");
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Description");
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "UnitPrice");
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "OnHandQuantity");

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }
 

   



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị danh sách sản phẩm theo categoryid nếu cần
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                string connectionString = "Data Source=MSI\\MSI;Initial Catalog=SACH;User ID=sa;Password=1234;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM products WHERE productcode = @productcode";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@productcode", textBox1.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                Load_data();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MSI;Initial Catalog=SACH;User ID=sa;Password=1234;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO products (productcode, description, unitprice, OnHandQuantity, categoryid) " +
                               "VALUES (@productcode, @description, @unitprice, @OnHandQuantity, @categoryid)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@productcode", textBox1.Text);
                cmd.Parameters.AddWithValue("@description", textBox2.Text);
                cmd.Parameters.AddWithValue("@unitprice", textBox3.Text);
                cmd.Parameters.AddWithValue("@OnHandQuantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@categoryid", comboBox1.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            Load_data();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MSI;Initial Catalog=SACH;User ID=sa;Password=1234;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE products SET description = @description, unitprice = @unitprice, OnHandQuantity = @OnHandQuantity, categoryid = @categoryid " +
                               "WHERE productcode = @productcode";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@description", textBox2.Text);
                cmd.Parameters.AddWithValue("@unitprice", textBox3.Text);
                cmd.Parameters.AddWithValue("@OnHandQuantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@categoryid", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@productcode", textBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            Load_data();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_data();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            // Kết nối và load dữ liệu lên comboBox
            string connectionString = "Data Source=MSI\\MSI;Initial Catalog=SACH;User ID=sa;Password=1234;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM category", con);
                DataTable tb = new DataTable();
                da.Fill(tb);

                comboBox1.DataSource = tb;
                comboBox1.DisplayMember = "categoryname";
                comboBox1.ValueMember = "categoryid";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}
