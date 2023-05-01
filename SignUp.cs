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

namespace AIR3550
{
    public partial class SignUp : Form
    {
        List<DatabaseModel> database = new List<DatabaseModel>();
        public SignUp()
        {
            InitializeComponent();
            LoadDatabaseAcc();
        }
        private void LoadDatabaseAcc()
        {
            database = SqliteDataAccess.LoadDatabaseAcc();
            // WireUpDatabase();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Button_Click(object sender, EventArgs e)
        {
            // Check if the username ends with -adm
            if (UserText.Text.EndsWith("-adm"))
            {
                MessageBox.Show("Username cannot end with -adm. Please choose a different username.");
                return;
            }

            DatabaseModel d = new DatabaseModel();

            // The rest of your code remains unchanged

            d.FirstName = FNameText.Text;
            d.MiddleName = MNameText.Text;
            d.LastName = LNameText.Text;
            d.Username = UserText.Text;
            d.Password = PassText.Text;
            d.Email = EmailText.Text;
            d.DateOfBirth = DOBText.Text;
            d.ZipCode = int.Parse(ZipCodeText.Text);

            // Get selected gender from radio buttons
            string gender= "";
            if (Male.Checked)
            {
                gender = "Male";
            }
            else if (Female.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
            d.Gender = gender;

            d.Address = AddressText.Text;
            d.PhoneNumber = PhoneNumText.Text;
            d.AccCity = CityText.Text;
            d.AccState = StateText.Text;

            SqliteDataAccess.SaveDatabaseAcc(d);

            FNameText.Text = "";
            MNameText.Text = "";
            LNameText.Text = "";
            UserText.Text = "";
            PassText.Text = "";
            EmailText.Text = "";
            DOBText.Text = "";
            AddressText.Text = "";
            PhoneNumText.Text = "";
            CityText.Text = "";
            StateText.Text = "";
            ZipCodeText.Text = "";

            loginPage form2 = new loginPage();

            // Display the new form
            form2.Show();

            this.Hide();
        }


    }
}