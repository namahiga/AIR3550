using System;

namespace AIR3550
{
    public class FlightModel
    {
        public int FlightID { get; set; }
        public string PlaneType { get; set; }
        public TimeSpan TakeoffTime { get; set; }
        public TimeSpan LandingTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        public int AvailableSeats { get; set; }
        public bool Canceled { get; set; }
    }

    public class AirportModel
    {
        public int Id { get; set; }
        public string Cities { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string AirportCode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

}
