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
    public partial class Form2 : Form
    {
        public static Form2 SearchWindow;
        public string[] bookProp = new string[7];
        public static string[] books;
        public Form2()
        {
            InitializeComponent();
            SearchWindow = this;
        }

        private void buttonSesrch_Click(object sender, EventArgs e)
        {
            string bookName = textBox1.Text;
            string query = "SELECT " + "TOP(1000) *" + " FROM Book WHERE Name LIKE'%" + bookName + "%'";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader(); //Update Write Delete

            while (reader.Read())
            {
                
                if (true)
                {
                    bookProp[0] = reader["Name"].ToString();
                    bookProp[1] = reader["BookNum"].ToString();
                    bookProp[2] = reader["Author"].ToString();
                    bookProp[3] = reader["PublishDate"].ToString();
                    bookProp[4] = reader["Address"].ToString();
                    bookProp[5] = reader["EditionNum"].ToString();
                    bookProp[6] = reader["IsBorrowed"].ToString();

                    Form3 form1 = new Form3();

                    form1.Show();

                    Form3.bookPage.labe1.Text = bookProp[0];
                    Form3.bookPage.labe2.Text = bookProp[1];
                    Form3.bookPage.labe3.Text = bookProp[2];
                    Form3.bookPage.labe4.Text = bookProp[3];
                    Form3.bookPage.labe5.Text = bookProp[4];
                    Form3.bookPage.labe6.Text = bookProp[5];
                    Form3.bookPage.labe7.Text = bookProp[6];

                    textBox1.Clear();

                    if (bookProp[0] == "")
                    {
                        label2.Visible = true;
                    }

                }
            }


            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookAuthor = textBox2.Text;
            string query = "SELECT " + "TOP(1000) *" + " FROM Book WHERE Author LIKE'%" + bookAuthor + "%'";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\hp\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader(); //Update Write Delete

            while (reader.Read())
            {

                if (true)
                {
                    bookProp[0] = reader["Name"].ToString();
                    bookProp[1] = reader["BookNum"].ToString();
                    bookProp[2] = reader["Author"].ToString();
                    bookProp[3] = reader["PublishDate"].ToString();
                    bookProp[4] = reader["Address"].ToString();
                    bookProp[5] = reader["EditionNum"].ToString();
                    bookProp[6] = reader["IsBorrowed"].ToString();

                    Form3 form1 = new Form3();

                    form1.Show();

                    Form3.bookPage.labe1.Text = bookProp[0];
                    Form3.bookPage.labe2.Text = bookProp[1];
                    Form3.bookPage.labe3.Text = bookProp[2];
                    Form3.bookPage.labe4.Text = bookProp[3];
                    Form3.bookPage.labe5.Text = bookProp[4];
                    Form3.bookPage.labe6.Text = bookProp[5];
                    Form3.bookPage.labe7.Text = bookProp[6];

                    textBox2.Clear();

                    if (bookProp[0] == "")
                    {
                        label4.Visible = true;
                    }

                }
            }


            connection.Close();

        }
    }
}
