using AIR3550;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AIR3550
{
    public partial class EditInfo : Form
    {
        private string username;
        private string password;
        private DatabaseModel user;


        private void PopulateUserInfo(string username, string password)
        {
            // Retrieve the user's information from the database
            DatabaseModel user = SqliteDataAccess.PopulateDatabaseAcc(username, password);

            // Populate the form fields with the user's information
            FNameText.Text = user.FirstName;
            MNameText.Text = user.MiddleName;
            LNameText.Text = user.LastName;
            EmailText.Text = user.Email;
            DOBText.Text = user.DateOfBirth;
            ZipCodeText.Text = user.ZipCode.ToString();

            if (user.Gender == "Male")
            {
                Male.Checked = true;
            }
            else if (user.Gender == "Female")
            {
                Female.Checked = true;
            }

            AddressText.Text = user.Address;
            PhoneNumText.Text = user.PhoneNumber;
            CityText.Text = user.AccCity;
            StateText.Text = user.AccState;
        }

        public EditInfo(string username, string password)
        {
            InitializeComponent();

            // Save the username and password
            this.username = username;
            this.password = password;

            // Retrieve and populate the user's information
            PopulateUserInfo(username, password);

            // Check if the user object is null before accessing its properties
            if (user != null)
            {
                // Prepopulate the first name and last name text boxes
                FNameText.Text = user.FirstName;
                LNameText.Text = user.LastName;

                // Prepopulate the rest of the form fields with the user's information
                MNameText.Text = user.MiddleName;
                EmailText.Text = user.Email;
                DOBText.Text = user.DateOfBirth;
                ZipCodeText.Text = user.ZipCode.ToString();

                if (user.Gender == "Male")
                {
                    Male.Checked = true;
                }
                else if (user.Gender == "Female")
                {
                    Female.Checked = true;
                }

                AddressText.Text = user.Address;
                PhoneNumText.Text = user.PhoneNumber;
                CityText.Text = user.AccCity;
                StateText.Text = user.AccState;
            }
        }



        private void EditInfo_Button_Click(object sender, EventArgs e)
        {
            // Create a new instance of the DatabaseModel class to hold the updated user information
            DatabaseModel updatedUser = new DatabaseModel();

            // Populate the updated user information from the form fields
            updatedUser.FirstName = FNameText.Text;
            updatedUser.MiddleName = MNameText.Text;
            updatedUser.LastName = LNameText.Text;
            updatedUser.Email = EmailText.Text;
            updatedUser.DateOfBirth = DOBText.Text;
            updatedUser.ZipCode = int.Parse(ZipCodeText.Text);

            if (Male.Checked)
            {
                updatedUser.Gender = "Male";
            }
            else if (Female.Checked)
            {
                updatedUser.Gender = "Female";
            }

            updatedUser.Address = AddressText.Text;
            updatedUser.PhoneNumber = PhoneNumText.Text;
            updatedUser.AccCity = CityText.Text;
            updatedUser.AccState = StateText.Text;

            // Update the user information in the database
            SqliteDataAccess.UpdateDatabaseAcc(updatedUser, username, password);

            // Display a message box indicating that the update was successful
            MessageBox.Show("Information updated successfully.");
        }

    }

}