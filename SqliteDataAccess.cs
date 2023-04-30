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

    }
}