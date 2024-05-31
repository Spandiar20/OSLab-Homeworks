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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string query = "SELECT " + "*" + " FROM Customer1 WHERE Name ='" + userName + "'" + " AND Password ='" + password + "';";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader(); //Update Write Delete

            while (reader.Read())
            {
                if (reader["Password"].ToString() == password)
                {

                    if (reader["UserType"].ToString() == "normal")
                    {
                        Form2 form = new Form2();
                        form.Show();
                    }

                    else
                    {
                        Form4 form = new Form4();
                        form.Show();
                        Form1 form1 = new Form1();
                        form1.Hide();
                    }

                    textBox1.Clear();
                    textBox2.Clear();

                }
            }

            label2.Visible = true;
            textBox2.Clear();
            MessageBox.Show("Wrong username or password!");

            connection.Close();

            //DataTable dt = new DataTable();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage rg = new RegisterPage();
            rg.Show();
        }
    }
}
