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
    public partial class cancelFlight : Form
    {
        public cancelFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                // Display a confirmation dialog box
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked "Yes", proceed with the deletion
                if (result == DialogResult.Yes)
                {
                MessageBox.Show("Your flight has been successfully cancelled");

                this.Close();

                SearchFlights newForm = new SearchFlights();

                // Show the new form
                newForm.Show();
            }
                // If the user clicked "No", do nothing
                else if (result == DialogResult.No)
                {
                    // Do nothing
                }
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

