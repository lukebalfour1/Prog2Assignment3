using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Assignment3
{
    public class Person
    {
        String strmyFirstName;
        String strmySurname;
        String strmyAddress;
        String strmyTown;
        String strmyCounty;
        String strmyPostcode;
        String strmyPhone;
        String strmyEmail;

        public string CustomerFirstName
        {
            get { return this.strmyFirstName; }
            set { this.strmyFirstName = value; }
        }

        public string CustomerSurname
        {
            get { return this.strmySurname; }
            set { this.strmySurname = value; }
        }

        public string CustomerAddress
        {
            get { return this.strmyAddress; }
            set { this.strmyAddress = value; }
        }
   
        public string CustomerTown
        {
            get { return this.strmyTown; }
            set { this.strmyTown = value; }
        }

        public string CustomerCounty
        {
            get { return this.strmyCounty; }
            set { this.strmyCounty = value; }
        }

        public string CustomerPostcode
        {
            get { return this.strmyPostcode; }
            set { this.strmyPostcode = value; }
        }

        public string CustomerPhone
        {
            get { return this.strmyPhone; }
            set { this.strmyPhone = value; }
        }

        public string CustomerEmail
        {
            get { return this.strmyEmail; }
            set { this.strmyEmail = value; }
        }

        public Person()
        {
            strmyFirstName = "dftFirstName";
            strmySurname = "dftSurname";
            strmyAddress = "dftAddress";
            strmyTown = "dftTown";
            strmyCounty = "dftCounty";
            strmyPostcode = "dftPC";
            strmyPhone = "123454";
            strmyEmail = "dftEmail";
        }

        public Person(String strNewFirstName, String strNewSurame, String strNewAddress, String strNewTown, String strNewCounty, String strNewPostcode, String strNewPhone, String strNewEmail, Double dblMyBalance)

        {
            CustomerFirstName = strNewFirstName;
            CustomerSurname = strNewSurame;
            CustomerAddress = strNewAddress;
            CustomerTown = strNewTown;
            CustomerCounty = strNewCounty;
            CustomerPostcode = strNewPostcode;
            CustomerPhone = strNewPhone;
            CustomerEmail = strNewEmail;
        }

    }
}
