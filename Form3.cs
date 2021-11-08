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
    public partial class Form3 : Form
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            
            


            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEW\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into sign_up values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "','" + gender + "','" + listBox1.Text.Trim() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("YOU HAVE SIGNED IN SUCCESSFULLY!!");
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.ResetAllControls(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
