using System;
using System.Collections;
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
    public partial class Form2 : Form

    {
        Hashtable h;
        public delegate void SetFoodValueCallback(string str);
        public SetFoodValueCallback SetFoodValue;
        public Form2()
        {
            InitializeComponent();
        }
        public void SetText(string str)
        {
            label3.Text = str;
            
        }
        public void SetMovieTickets(string str)
        {
            label11.Text = str;
        }
        public void orderFood(string str)
        {
            label12.Text = str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEW\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete from sign_up where username=' " + textBox1.Text.Trim() + "';", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ACCOUNT IS DELETED!!");
            Con.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
           
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "--Select--";
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int snacks_cost = 0;
            if (comboBox1.Text == "DRINKS")
            {
                snacks_cost += 100;
            }else if(comboBox1.Text == "POPCORN")
            {
                snacks_cost += 120;
            }
            else if (comboBox1.Text == "POPCORN")
            {
                snacks_cost += 120;
            }
            else if(comboBox1.Text == "COMBO 1")
            {
                snacks_cost += 180;
            }
            else
            {
                snacks_cost += 250;
            }
            var frm2 = new Form2();
            this.SetFoodValue = new SetFoodValueCallback(frm2.orderFood);
            SetFoodValue(textBox3.Text);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message1 = "Your food Selection is:" + comboBox1.Text +Environment.NewLine+ "Name of the Customer" + textBox2.Text +Environment.NewLine+ "total Price Cost:" + textBox3.Text;
            string title1 = "Food Selection:";
            MessageBox.Show(message1, title1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToShortDateString();
            if(theDate == "6/3/2021")
            {
                pictureBox1.Image = new Bitmap("C:\\Users\\NEW\\source\\repos\\PT_Sem_18CS1019\\PT_Sem_18CS1019\\Resources\\movie1.jpg");
            }
            else if(theDate == "6/4/2021")
            {
                pictureBox1.Image = new Bitmap("C:\\Users\\NEW\\source\\repos\\PT_Sem_18CS1019\\PT_Sem_18CS1019\\Resources\\movie2.jpg");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrations bt = new Administrations();
            bt.seats_blocked(Convert.ToInt32(textBox4.Text));
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Administrations bt = new Administrations();
            bt.seats_blocked(Convert.ToInt32(textBox5.Text), listBox1.Text);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            h = new Hashtable();
            h.Add("Godzilla VS KIng Kong", 13 - Convert.ToInt32(textBox5.Text));

            foreach(DictionaryEntry i in h)
            {
                listBox2.Items.Add(i.Key + ":" + i.Value);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int snacks_cost = 0;
            if (comboBox1.Text == "DRINKS")
            {
                snacks_cost += 100;
            }
            else if (comboBox1.Text == "POPCORN")
            {
                snacks_cost += 120;
            }
            else if (comboBox1.Text == "POPCORN")
            {
                snacks_cost += 120;
            }
            else if (comboBox1.Text == "COMBO 1")
            {
                snacks_cost += 180;
            }
            else
            {
                snacks_cost += 250;
            }
            var frm2 = new Form2();
            this.SetFoodValue = new SetFoodValueCallback(frm2.orderFood);
            SetFoodValue(textBox3.Text);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
