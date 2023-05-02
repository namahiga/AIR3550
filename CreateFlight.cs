using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AIR3550
{
    public partial class CreateFlight : Form
    {
        private List<FlightModel> _flightsCache;

        public CreateFlight()
        {
            InitializeComponent();
            this.Load += CreateFlight_Load;
        }

        private void LoadFlights(DateTime selectedDate)
        {
            var flights = _flightsCache
                .Where(f => f.DepartureDate.Date == selectedDate.Date || f.ArrivalDate.Date == selectedDate.Date)
                .ToList();
            dataGridView2.DataSource = flights;
        }


        private void CreateFlight_Load(object sender, EventArgs e)
        {
            // Load all flights from the database
            _flightsCache = SqliteDataAccess.LoadFlights();

            // Add a checkbox column for the Canceled property
            var canceledColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Canceled",
                HeaderText = "Canceled",
                DataPropertyName = "Canceled"
            };
            dataGridView2.Columns.Add(canceledColumn);

            monthCalendar1.MaxSelectionCount = 1;
            LoadFlights(DateTime.Now);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadFlights(monthCalendar1.SelectionStart);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save changes to the flight cancellation status
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.DataBoundItem is FlightModel flight)
                {
                    SqliteDataAccess.UpdateFlightCancellationStatus(flight.FlightID, flight.Canceled);
                }
            }

            LoadFlights(monthCalendar1.SelectionStart);
        }
    }
}
