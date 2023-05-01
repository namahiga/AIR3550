using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace AIR3550
{
    public partial class loginPage : Form
    {
        List<DatabaseModel> database = new List<DatabaseModel>();
        public static string username;
        public static string password;

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
            username = UsernamePrompt.Text;
        }

        private void PasswordPrompt_text(object sender, EventArgs e)
        {
            password = PasswordPrompt.Text;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // TODO: Validate the input fields (e.g., check for empty fields)
            bool isValidUser = SqliteDataAccess.CheckCredentials(new DatabaseModel { Username = username, Password = password });

            if (isValidUser)
            {
                // Check if the user has a username with -adm at the end
                if (username.EndsWith("-adm"))
                {
                    // Navigate to the CreateFlight form
                    CreateFlight form2 = new CreateFlight();
                    form2.Show();
                }
                else
                {
                    // Navigate to the SearchFlights form
                    SearchFlights form2 = new SearchFlights();
                    form2.Show();
                }

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
