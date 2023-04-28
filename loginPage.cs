using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR3550
{
    public partial class loginPage : Form
    {
        List<DatabaseModel> database = new List<DatabaseModel>();
        public loginPage()
        {

            InitializeComponent();
            LoadDatabase();

            // Set the AcceptButton property to the "Login" button
            this.AcceptButton = Login;
        }
        private void LoadDatabase()
        {
            database = SqliteDataAccess.LoadDatabase();
            
        }

        private void UsernamePrompt_text(object sender, EventArgs e)
        {

        }

        private void PasswordPrompt_text(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            string username = UsernamePrompt.Text;
            string password = PasswordPrompt.Text;
            //Console.WriteLine(username + ":" + password);
            // TODO: Validate the input fields (e.g., check for empty fields)
            bool isValidUser = SqliteDataAccess.CheckCredentials( new DatabaseModel { Username = username, Password = password });

            if (isValidUser)
            {
                // Navigate to the next form
                SearchFlights form2 = new SearchFlights();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            SignUp form2 = new SignUp();

            // Display the new form
            form2.Show();

            this.Hide();
        }
        
    }
}

