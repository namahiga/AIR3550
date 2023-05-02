using Dapper;
using System.Collections.Generic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Security.Principal;
using System.Linq;



namespace AIR3550
{
    public class SqliteDataAccess
    {
        public static List<DatabaseModel> LoadDatabase()
        {
            try
            {
                using (IDbConnection connect = new SQLiteConnection(LoadConnectionString()))
                {
                    return connect.Query<DatabaseModel>("SELECT * FROM Airports").AsList<DatabaseModel>();

                }
            }
            catch (SQLiteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                return null;
            }
        }

        public static void SaveDatabase(DatabaseModel Airports)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Airports (Cities, State, Name, AirportCode) values (@Cities, @State, @Name, @AirportCode)", Airports);
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        //Delete button connection too database
        public static void DeleteDatabase(int Id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                cnn.Execute($"DELETE FROM Airports WHERE (Id ={Id})");

            }
        }
        //Account Methods
        public static List<DatabaseModel> LoadDatabaseAcc()
        {
            try
            {
                using (IDbConnection connect = new SQLiteConnection(LoadConnectionString()))
                {
                    return connect.Query<DatabaseModel>("SELECT * FROM Account").AsList<DatabaseModel>();
                }
            }
            catch (SQLiteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                return null;
            }
        }
        public static void SaveDatabaseAcc(DatabaseModel Account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Account (Username, Password, AccState, AccCity, FirstName, LastName, MiddleName, Email, Address, Gender, PhoneNumber, DateOfBirth, ZipCode) values (@Username, @Password, @AccState, @AccCity, @FirstName, @LastName, @MiddleName, @Email,@Address, @Gender, @PhoneNumber, @DateOfBirth, @ZipCode)", Account);
            }
        }
        public static bool CheckCredentials(DatabaseModel Account)
        {
            string query = $"SELECT COUNT(*) FROM Account WHERE Username ='{Account.Username}' AND Password = '{Account.Password}'";

            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    Console.WriteLine("Executing query: {0}", query);
                    int count = cnn.QuerySingle<int>(query);
                    Console.WriteLine("Checking credentials for user '{0}' with password '{1}'... count = {2}", Account.Username, Account.Password, count);
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking credentials: {0}", ex.Message);
                return false;
            }
        }

        public static void UpdateDatabaseAcc(DatabaseModel d, string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE ACCOUNT SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Email = @Email, DateOfBirth = @DateOfBirth, ZipCode = @ZipCode, Gender = @Gender, Address = @Address, PhoneNumber = @PhoneNumber, AccCity = @AccCity, AccState = @AccState WHERE Username = @Username AND Password = @Password", new
                {
                    FirstName = d.FirstName,
                    MiddleName = d.MiddleName,
                    LastName = d.LastName,
                    Email = d.Email,
                    DateOfBirth = d.DateOfBirth,
                    ZipCode = d.ZipCode,
                    Gender = d.Gender,
                    Address = d.Address,
                    PhoneNumber = d.PhoneNumber,
                    AccCity = d.AccCity,
                    AccState = d.AccState,
                    Username = username,
                    Password = password
                });
            }
        }

        public static DatabaseModel PopulateDatabaseAcc(string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DatabaseModel>("SELECT * FROM Account WHERE Username = @Username AND Password = @Password", new { Username = username, Password = password });
                return output.FirstOrDefault();
            }
        }

        public static List<string> LoadAirportCities()
        {
            try
            {
                using (IDbConnection connect = new SQLiteConnection(LoadConnectionString()))
                {
                    return connect.Query<string>("SELECT Cities FROM Airports").AsList();
                }
            }
            catch (SQLiteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                return null;
            }
        }

        private static double Haversine(double lat1, double lon1, double lat2, double lon2)
        {
            const double earthRadiusMiles = 3958.8; // Earth's radius in miles
            double dLat = DegreeToRadian(lat2 - lat1);
            double dLon = DegreeToRadian(lon2 - lon1);

            lat1 = DegreeToRadian(lat1);
            lat2 = DegreeToRadian(lat2);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Asin(Math.Sqrt(a));

            return earthRadiusMiles * c;
        }
        private static double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }

        public static (double points, double money) CalculatePointsAndMoney(string departureCity, string arrivalCity)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var departureAirport = cnn.QuerySingleOrDefault<DatabaseModel>("SELECT * FROM Airports WHERE Cities = @Cities", new { Cities = departureCity });
                var arrivalAirport = cnn.QuerySingleOrDefault<DatabaseModel>("SELECT * FROM Airports WHERE Cities = @Cities", new { Cities = arrivalCity });

                if (departureAirport != null && arrivalAirport != null)
                {
                    Console.WriteLine($"Departure Airport: {departureAirport.Cities}, Latitude: {departureAirport.Latitude}, Longitude: {departureAirport.Longitude}");
                    Console.WriteLine($"Arrival Airport: {arrivalAirport.Cities}, Latitude: {arrivalAirport.Latitude}, Longitude: {arrivalAirport.Longitude}");

                    double distance = Haversine(departureAirport.Latitude, departureAirport.Longitude, arrivalAirport.Latitude, arrivalAirport.Longitude);
                    Console.WriteLine($"Distance: {distance} miles");


                    // Calculate points and money based on the distance
                    double points = Math.Ceiling(distance * 0.18);
                    double money = Math.Ceiling(distance * 1.6);


                    return (points, money);
                }

                else
                {
                    throw new ArgumentException("Invalid departure or arrival city.");
                }
            }
        }

        public static List<FlightModel> LoadFlights()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand("SELECT * FROM Flights", connection);
                var reader = command.ExecuteReader();

                var flights = new List<FlightModel>();
                while (reader.Read())
                {
                    var flight = new FlightModel
                    {
                        FlightID = reader.GetInt32(reader.GetOrdinal("FlightID")),
                        PlaneType = reader.GetString(reader.GetOrdinal("PlaneType")),
                        TakeoffTime = reader.GetDateTime(reader.GetOrdinal("TakeoffTime")).TimeOfDay,
                        LandingTime = reader.GetDateTime(reader.GetOrdinal("LandingTime")).TimeOfDay,
                        DepartureDate = reader.GetDateTime(reader.GetOrdinal("DepartureDate")),
                        ArrivalDate = reader.GetDateTime(reader.GetOrdinal("ArrivalDate")),
                        OriginLocation = reader.GetString(reader.GetOrdinal("OriginLocation")),
                        DestinationLocation = reader.GetString(reader.GetOrdinal("DestinationLocation")),
                        AvailableSeats = reader.GetInt32(reader.GetOrdinal("AvailableSeats")),
                        Canceled = reader.GetBoolean(reader.GetOrdinal("Canceled"))
                    };

                    flights.Add(flight);
                }

                return flights;
            }
        }

        public static void SaveFlight(FlightModel flight, DateTime departureDate)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "INSERT INTO Flights (PlaneType, TakeoffTime, LandingTime, DepartureDate, ArrivalDate, OriginLocation, DestinationLocation, AvailableSeats, Canceled) VALUES (@PlaneType, @TakeoffTime, @LandingTime, @DepartureDate, @ArrivalDate, @OriginLocation, @DestinationLocation, @AvailableSeats, @Canceled)";
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@PlaneType", flight.PlaneType);
                command.Parameters.AddWithValue("@TakeoffTime", flight.TakeoffTime);
                command.Parameters.AddWithValue("@LandingTime", flight.LandingTime);
                command.Parameters.AddWithValue("@DepartureDate", departureDate);
                command.Parameters.AddWithValue("@ArrivalDate", departureDate);
                command.Parameters.AddWithValue("@OriginLocation", flight.OriginLocation);
                command.Parameters.AddWithValue("@DestinationLocation", flight.DestinationLocation);
                command.Parameters.AddWithValue("@AvailableSeats", flight.AvailableSeats);
                command.Parameters.AddWithValue("@Canceled", flight.Canceled);

                int retries = 3;
                while (retries > 0)
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        break;
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.Message.Contains("database is locked"))
                        {
                            retries--;
                            if (retries > 0)
                            {
                                System.Threading.Thread.Sleep(200); // Wait for 200ms before retrying
                            }
                        }
                        else
                        {
                            throw;
                        }
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                if (retries == 0)
                {
                    throw new Exception("Failed to save flight after multiple retries due to locked database.");
                }
            }
        }



        public static List<AirportModel> LoadAirports()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand("SELECT * FROM Airports", connection);
                var reader = command.ExecuteReader();

                var airports = new List<AirportModel>();
                while (reader.Read())
                {
                    var airport = new AirportModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Cities = reader.GetString(reader.GetOrdinal("Cities")),
                        State = reader.GetString(reader.GetOrdinal("State")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        AirportCode = reader.GetString(reader.GetOrdinal("AirportCode")),
                        Longitude = reader.GetDouble(reader.GetOrdinal("Longitude")),
                        Latitude = reader.GetDouble(reader.GetOrdinal("Latitude"))
                    };

                    airports.Add(airport);
                }

                return airports;
            }
        }

        private static TimeSpan RoundToNearest15Minutes(TimeSpan time)
        {
            int totalMinutes = (int)Math.Round(time.TotalMinutes / 15.0) * 15;
            return TimeSpan.FromMinutes(totalMinutes);
        }

        public static List<FlightModel> GenerateFlightSchedules(List<string> planeTypes, TimeSpan refuelTime, DateTime currentDate)
        {
            var generatedFlights = new List<FlightModel>();

            var airports = LoadAirports();
            var flightIdCounter = 1;

            TimeSpan startTime = new TimeSpan(6, 0, 0); // 6:00 AM
            TimeSpan endTime = new TimeSpan(22, 0, 0); // 10:00 PM

            DateTime endDate = currentDate.AddYears(1); // Generate flights for one year

            while (currentDate < endDate)
            {
                foreach (var origin in airports)
                {
                    foreach (var destination in airports)
                    {
                        if (origin.Id != destination.Id)
                        {
                            double distance = Haversine(origin.Latitude, origin.Longitude, destination.Latitude, destination.Longitude);

                            foreach (var planeType in planeTypes)
                            {
                                double speed;

                                int availableSeats;
                                switch (planeType)
                                {
                                    case "Boeing737":
                                        speed = 520;
                                        availableSeats = 100;
                                        break;
                                    case "Boeing767":
                                        speed = 530;
                                        availableSeats = 150;
                                        break;
                                    case "Boeing787":
                                        speed = 560;
                                        availableSeats = 250;
                                        break;
                                    default:
                                        throw new ArgumentException($"Invalid plane type: {planeType}");
                                }

                                TimeSpan flightDuration = TimeSpan.FromHours(distance / speed);

                                TimeSpan currentTakeoffTime = RoundToNearest15Minutes(startTime);


                                while (currentTakeoffTime + flightDuration <= endTime)
                                {
                                    var flight = new FlightModel
                                    {
                                        FlightID = flightIdCounter++,
                                        PlaneType = planeType,
                                        TakeoffTime = currentTakeoffTime,
                                        LandingTime = RoundToNearest15Minutes(currentTakeoffTime + flightDuration),
                                        DepartureDate = currentDate,
                                        ArrivalDate = currentDate, // Assuming same-day arrival
                                        OriginLocation = origin.Cities, // Using Cities property for OriginLocation
                                        DestinationLocation = destination.Cities, // Using Cities property for DestinationLocation
                                        AvailableSeats = availableSeats,
                                        Canceled = false
                                    };

                                    generatedFlights.Add(flight);

                                    // Increment the current takeoff time by flightDuration, refuelTime, and a buffer time for boarding and deboarding
                                    currentTakeoffTime = RoundToNearest15Minutes(currentTakeoffTime + flightDuration + refuelTime + TimeSpan.FromMinutes(30));
                                }
                            }
                        }
                    }
                }

                currentDate = currentDate.AddDays(1); // Move to the next day
            }

            return generatedFlights;
        }



        public static void GenerateAndSaveFlights()
        {
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = startDate.AddDays(15);

            List<string> planeTypes = new List<string> { "Boeing737", "Boeing767", "Boeing787" };
            TimeSpan refuelTime = TimeSpan.FromHours(1);

            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var generatedFlights = GenerateFlightSchedules(planeTypes, refuelTime, currentDate);
                foreach (var flight in generatedFlights)
                {
                    SaveFlight(flight, currentDate);
                }
            }   
        }


        public static void UpdateFlightCancellationStatus(int flightID, bool canceled)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "UPDATE Flights SET Canceled = @Canceled WHERE FlightID = @FlightID";
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@FlightID", flightID);
                command.Parameters.AddWithValue("@Canceled", canceled);

                int retries = 3;
                while (retries > 0)
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        break;
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.Message.Contains("database is locked"))
                        {
                            retries--;
                            if (retries > 0)
                            {
                                System.Threading.Thread.Sleep(200); // Wait for 200ms before retrying
                            }
                        }
                        else
                        {
                            throw;
                        }
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }

                if (retries == 0)
                {
                    throw new Exception("Failed to update flight cancellation status after multiple retries due to locked database.");
                }
            }
        }


        public static DateTime? GetLastFlightGenerationDate()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand("SELECT MAX(DepartureDate) FROM Flights", connection);
                var result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return Convert.ToDateTime(result);
                }
                else
                {
                    return null;
                }
            }
        }


        public static List<FlightModel> SearchFlights(string departureCity, string arrivalCity, DateTime departureDate)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "SELECT * FROM Flights WHERE OriginLocation = @DepartureCity AND DestinationLocation = @ArrivalCity AND DepartureDate = @DepartureDate";
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@DepartureCity", departureCity);
                command.Parameters.AddWithValue("@ArrivalCity", arrivalCity);
                command.Parameters.AddWithValue("@DepartureDate", departureDate.Date);

                connection.Open();
                var reader = command.ExecuteReader();

                var flights = new List<FlightModel>();
                while (reader.Read())
                {
                    flights.Add(new FlightModel
                    {
                        FlightID = reader.GetInt32(0),
                        PlaneType = reader.GetString(1),
                        TakeoffTime = reader.GetDateTime(2).TimeOfDay, // Convert DateTime to TimeSpan
                        LandingTime = reader.GetDateTime(3).TimeOfDay, // Convert DateTime to TimeSpan
                        DepartureDate = reader.GetDateTime(4),
                        ArrivalDate = reader.GetDateTime(5),
                        OriginLocation = reader.GetString(6),
                        DestinationLocation = reader.GetString(7),
                        AvailableSeats = reader.GetInt32(8),
                        Canceled = reader.GetBoolean(9),
                    });
                }

                return flights;
            }
        }















    }
}














