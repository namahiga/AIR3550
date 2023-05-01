using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AIR3550
{
    public class DatabaseModel
    {
        //Airport Table
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cities { get; set; }
        public string State { get; set; }
        public string AirportCode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string FullName => $"{AirportCode} - {Name}";
        public string FullLocation => $"{Cities}, {State}";
        public string Full => $"{FullName}, {FullLocation}";
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        //CustomerAccount Table
        public int AccId { get; set; }
        public string Username { get; set; }//Require
        public string Password { get; set; }//Require
        public string Email { get; set; }//Require
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }//Require
        public string MiddleName { get; set; }//Require
        public string LastName { get; set; }//Require
        public string DateOfBirth { get; set; }//Require

        public string AccCity { get; set; }

        public string AccState { get; set; }
        public string Address { get; set; }//Require
        public int ZipCode { get; set; } //Require
        public string Gender { get; set; }//Require
        public int CCNum { get; set; }
        public int CCSecurityNum { get; set; }
        public string CCExpDate { get; set; }

        //Ticket Table

        //Flights Table

        //Financial Table
    }
}