using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Sem_18CS1019
{
    public partial class Form5 : Form
    {
        public delegate void SetTicketValueCallback(string str);
        public SetTicketValueCallback SetTicketValue;
        public Form5()
        {
            InitializeComponent();
        }

        public void SelectTickets()
        {
           }
    

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string Balcony = " ";
            int selected_seats = 0;
            int total_cost = 0;
            
       
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox1.Text;
                    selected_seats++;
                    total_cost += 150;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox2.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox2.Text;
                    selected_seats++;
                    total_cost += 150;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox3.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox3.Text;
                    selected_seats++;
                    total_cost += 150;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox4.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox4.Text;
                    selected_seats++;
                    total_cost *= 150;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox5.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox5.Text;
                    selected_seats++;
                    total_cost += 150;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox6.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox6.Text;
                    selected_seats++;
                    total_cost += 100;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox7.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox7.Text;
                    selected_seats++;
                    total_cost += 100;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox8.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox1.Text;
                    selected_seats++;
                    total_cost += 100;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox9.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox9.Text;
                    selected_seats++;
                    total_cost += 100;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox10.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox10.Text;
                    selected_seats++;
                    total_cost += 100;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox11.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox11.Text;
                    selected_seats++;
                    total_cost += 80;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox12.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox12.Text;
                    selected_seats++;
                    total_cost += 80;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            switch (checkBox13.CheckState)
            {
                case CheckState.Checked:
                    Balcony += checkBox13.Text;
                    selected_seats++;
                    total_cost += 80;
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            string message = "Selected Tickets are:" + Balcony + Environment.NewLine + "Total no. of tickets:" + selected_seats + Environment.NewLine + "Total Costs:" + total_cost;
            string title = "Book Info";
            MessageBox.Show(message,title);
            var frm2 = new Form2();
            frm2.Show();
            this.Hide();
            this.SetTicketValue = new SetTicketValueCallback(frm2.SetText);
            SetTicketValue(Balcony);

        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
