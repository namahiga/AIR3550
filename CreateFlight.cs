using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                .Where(f => f.DepartureDate.Date == selectedDate.Date)
                .ToList();
            dataGridView2.DataSource = flights;
        }

        private async void CreateFlight_Load(object sender, EventArgs e)
        {
            // Load all flights from the database
            _flightsCache = SqliteDataAccess.LoadFlights();

            // Generate flight schedules for each day from today to the next 10 days
            var startDate = DateTime.Now.Date;
            var endDate = DateTime.Now.Date.AddDays(10);

            await Task.Run(() =>
            {
                for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
                {
                    var flights = _flightsCache
                        .Where(f => f.DepartureDate.Date == currentDate.Date)
                        .ToList();

                    if (flights.Count == 0)
                    {
                        List<string> planeTypes = new List<string> { "Boeing737", "Boeing767", "Boeing787" }; 
                        TimeSpan refuelTime = TimeSpan.FromHours(1);
                        var generatedFlights = SqliteDataAccess.GenerateFlightSchedules(planeTypes, refuelTime, currentDate);

                        foreach (var flight in generatedFlights)
                        {
                            // Check if the flight already exists in the database
                            var existingFlight = _flightsCache
                                .FirstOrDefault(f =>
                                    f.FlightID == flight.FlightID &&
                                    f.PlaneType == flight.PlaneType &&
                                    f.TakeoffTime == flight.TakeoffTime &&
                                    f.LandingTime == flight.LandingTime &&
                                    f.DepartureDate == flight.DepartureDate &&
                                    f.ArrivalDate == flight.ArrivalDate &&
                                    f.OriginLocation == flight.OriginLocation &&
                                    f.DestinationLocation == flight.DestinationLocation);

                            if (existingFlight == null)
                            {
                                SqliteDataAccess.SaveFlight(flight);
                                _flightsCache.Add(flight);
                            }
                        }
                    }
                }
            });

            monthCalendar1.MaxSelectionCount = 1;
            LoadFlights(DateTime.Now);
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadFlights(monthCalendar1.SelectionStart);
        }

    }
}
