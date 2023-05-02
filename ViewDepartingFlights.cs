using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AIR3550
{
    public partial class ViewDepartingFlights : Form
    {
        public ViewDepartingFlights(List<FlightModel> flights)
        {
            InitializeComponent();
            FillDataGridView(flights);
        }

        private void FillDataGridView(List<FlightModel> flights)
        {
            dataGridView1.DataSource = flights.Select(f => new
            {
                DepartureDate = f.DepartureDate,
                DepartureTime = f.TakeoffTime,
                ArrivalDate = f.ArrivalDate,
                ArrivalTime = f.LandingTime,
                DepartureCity = f.OriginLocation,
                ArrivalCity = f.DestinationLocation
            }).ToList();
        }

        private void F2RadioButton_D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ViewDeparting_Flights_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
