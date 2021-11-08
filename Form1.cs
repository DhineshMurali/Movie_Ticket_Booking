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

namespace PT_Sem_18CS1019
{
    public partial class Form1 : Form
    {
        public delegate void SetTextValueCallback(string str);
        public SetTextValueCallback SetTextValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEW\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from [Table] where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("LOGIN SUCCESS!!");
                var frm2 = new Form2();
                frm2.Show();
                this.Hide();
                this.SetTextValue = new SetTextValueCallback(frm2.SetText);
                SetTextValue(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
