using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR3550
{
    public partial class SearchFlights : Form
    {
        public SearchFlights()
        {
            InitializeComponent();
        }

        private void editAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp newForm = new SignUp();

            // Show the new form
            newForm.Show();
        }

        private void viewBookedFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFlights newForm = new myFlights();

            // Show the new form
            newForm.Show();
        }

        private void cancelFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();

            // Show the new form
            newForm.Show();

            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage newForm = new loginPage();

            // Show the new form
            newForm.Show();

            this.Hide();
       
        }
    }
}
