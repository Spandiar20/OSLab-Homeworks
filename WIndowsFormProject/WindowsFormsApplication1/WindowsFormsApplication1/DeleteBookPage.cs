using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DeleteBookPage : Form
    {
        public DeleteBookPage()
        {
            InitializeComponent();
        }

        private void DeleteBookPage_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Book", connection);
            DataTable dtb1 = new DataTable();
            adapt.Fill(dtb1);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtb1;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
            {

                string query = "DELETE FROM Book WHERE Id = '" + textBox1.Text + "'";

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Book", connection);
                DataTable dtb1 = new DataTable();
                adapt.Fill(dtb1);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtb1;

                connection.Close();
            }
            else
            {
                label5.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
