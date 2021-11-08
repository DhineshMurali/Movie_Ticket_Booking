using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Sem_18CS1019
{
    class Administrations
    {
        

        public void seats_blocked(int n)
        {
            MessageBox.Show(n + " tickets reserved");
        }
        public void seats_blocked(int n,string s)
        {
            MessageBox.Show(n + "tickets Blocked" + Environment.NewLine + "For the Movie" + s);
        }
        public void amount_collected()
        {

        }
    }
}
