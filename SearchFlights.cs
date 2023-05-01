using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AIR3550
{
    public partial class SearchFlights : Form
    {
        //private DatabaseModel user;

        private List<string> airportCities;
        private List<string> arrivalCities;

        public SearchFlights()
        {
            InitializeComponent();
            // Set the selected index to 0
            tripTypeComboBox.SelectedIndex = 0;

            // Populate the departPlaceComboBox with airport cities
            airportCities = SqliteDataAccess.LoadAirportCities();
            departPlaceComboBox.DataSource = airportCities;

            // Create a copy of the airport cities list and remove the selected departure city
            arrivalCities = new List<string>(airportCities);
            arrivalCities.Remove(departPlaceComboBox.SelectedItem?.ToString());

            // Set the DataSource property of the arrivePlaceComboBox to the arrivalCities list
            arrivePlaceComboBox.DataSource = arrivalCities;
        }
        private void tripTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                var selectedValue = tripTypeComboBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(selectedValue))
                {
                    return;
                }

                switch (selectedValue)
                {
                    case "One-way":
                        HideReturnDateControls();
                        break;
                    case "Round-trip":
                        ShowReturnDateControls();
                        break;
                    default:
                        // Handle any other cases here
                        break;
                }
            }
        }
        
        

        private void ShowReturnDateControls()
        {
            arrivalCalendar.Visible = true;
            arrivalDateLabel.Visible = true;
        }

        private void HideReturnDateControls()
        {
            arrivalCalendar.Visible = false;
            arrivalDateLabel.Visible = false;
        }

        private void editAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Retrieve the user's information from the database
            DatabaseModel user = SqliteDataAccess.PopulateDatabaseAcc(loginPage.username, loginPage.password);

            EditInfo newForm = new EditInfo(loginPage.username, loginPage.password);

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
            cancelFlight newForm = new cancelFlight();

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

        private void departPlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the departPlaceComboBox
            string selectedDeparture = departPlaceComboBox.SelectedItem?.ToString();

            // If the selected item is null or whitespace, do nothing
            if (string.IsNullOrWhiteSpace(selectedDeparture))
            {
                return;
            }

            // Remove the selected departure city from the arrivalCities list
            arrivalCities = new List<string>(airportCities);
            arrivalCities.Remove(selectedDeparture);
            // Set the DataSource property of the arrivePlaceComboBox to the arrivalCities list
            arrivePlaceComboBox.DataSource = arrivalCities;
        }

        private void arrivePlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the arrivePlaceComboBox
            string selectedArrival = arrivePlaceComboBox.SelectedItem?.ToString();

            // If the selected item is null or whitespace, do nothing
            if (string.IsNullOrWhiteSpace(selectedArrival))
            {
                return;
            }
        }
      
        private void SearchFlightButton_Click(object sender, EventArgs e)
        {
            {
                // Get the selected departure and arrival cities
                string selectedDeparture = departPlaceComboBox.SelectedItem?.ToString();
                string selectedArrival = arrivePlaceComboBox.SelectedItem?.ToString();

                // If either selection is null or whitespace, show an error message and return
                if (string.IsNullOrWhiteSpace(selectedDeparture) || string.IsNullOrWhiteSpace(selectedArrival))
                {
                    MessageBox.Show("Please select a departure and arrival city.");
                    return;
                }

                // Get the selected dates from the calendars
                DateTime? departureDate = departureCalendar.SelectionStart;
                DateTime? arrivalDate = arrivalCalendar.SelectionStart;

                // If either date is null, show an error message and return
                if (!departureDate.HasValue || !arrivalDate.HasValue)
                {
                    MessageBox.Show("Please select a departure and arrival date.");
                    return;
                }

                // Display the selected departure and arrival cities and dates in a message box
                MessageBox.Show($"Departure City: {selectedDeparture}\nArrival City: {selectedArrival}\nDeparture Date: {departureDate.Value.ToShortDateString()}\nArrival Date: {arrivalDate.Value.ToShortDateString()}");
            }
        }

        
    }

}