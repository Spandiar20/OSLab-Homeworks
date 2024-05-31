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
    public partial class UserManagementPage : Form
    {
        public UserManagementPage()
        {
            InitializeComponent();
        }

        private void UserManagementPage_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Customer1", connection);
            DataTable dtb1 = new DataTable();
            adapt.Fill(dtb1);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtb1;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox2.Text != null && comboBox1.Text != null)
            {
                string query = "UPDATE Customer1 SET " + comboBox1.Text + " = '" + textBox2.Text + "' WHERE Id ='" + textBox1.Text + "'";

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Customer1", connection);
                DataTable dtb1 = new DataTable();
                adapt.Fill(dtb1);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtb1;

                textBox1.Text = textBox2.Text = comboBox1.Text = "";

                MessageBox.Show("Change commited!");

                connection.Close();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
            {

                string query = "DELETE FROM Customer1 WHERE Id = '" + textBox4.Text + "'";

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Customer1", connection);
                DataTable dtb1 = new DataTable();
                adapt.Fill(dtb1);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtb1;

                textBox4.Clear();


                connection.Close();
                MessageBox.Show("User Deleted!");
            }
            else
            {
                label5.Visible = true;
            }
        }
    }
}
