using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR3550
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<DatabaseModel> airports = SqliteDataAccess.LoadDatabase();
            if (airports != null)
            {
                foreach (DatabaseModel airport in airports)
                {
                    Console.WriteLine(" Name: {0}, Cities: {1}, State: {2}",
                         airport.Name, airport.Cities, airport.State);
                }
            }
            List<DatabaseModel> accounts = SqliteDataAccess.LoadDatabaseAcc();
            foreach (var account in accounts)
            {
                Console.WriteLine("Username: {0}, Password: {1}, First Name: {2}, Last Name: {3}, Email: {4}", account.Username, account.Password, account.FirstName, account.LastName, account.Email);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginPage());
        }
    }
}
