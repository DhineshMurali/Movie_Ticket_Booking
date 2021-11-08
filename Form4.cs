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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEW\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("update sign_up set password = ' " + textBox2.Text.Trim()  + " 'where username=' " + textBox1.Text.Trim() + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("PASSWORD IS UPDATED!!");
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
