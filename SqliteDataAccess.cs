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














    }
}

