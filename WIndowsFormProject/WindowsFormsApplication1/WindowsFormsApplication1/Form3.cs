using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public static Form3 bookPage = new Form3();
        public Label labe1;
        public Label labe2;
        public Label labe3;
        public Label labe4;
        public Label labe5;
        public Label labe6;
        public Label labe7;
        public Form3()
        {
            InitializeComponent();
            bookPage = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labe1 = label1;
            labe2 = label2;
            labe3 = label3;
            labe4 = label4;
            labe5 = label5;
            labe6 = label6;
            labe7 = label7;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowSuccess form = new BorrowSuccess();
            form.Show();
            this.Hide();
        }
    }
}
