using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Assignment3
{
    class Customer
    {
        int intmyAccNumb;
        string strPersonFirstName;
        string strPersonSurname;
        string strPersonAddress;
        string strPersonTown;
        string strPersonCounty;
        string strPersonPostcode;
        string strPersonPhone;
        string strPersonEmail;
        private double dblmyBalance;

        public int CustomerNumber
        {
            get { return intmyAccNumb; }
            set { intmyAccNumb = value; }
        }

        public string PersonFirstName
        {
            get { return strPersonFirstName; }
            set { strPersonFirstName = value; }
        }

        public string PersonSurname
        {
            get { return strPersonSurname; }
            set { strPersonSurname = value; }
        }

        public string PersonAddress
        {
            get { return strPersonAddress; }
            set { strPersonAddress = value; }
        }

        public string PersonTown
        {
            get { return strPersonTown; }
            set { strPersonTown = value; }
        }

        public string PersonCounty
        {
            get { return strPersonCounty; }
            set { strPersonCounty = value; }
        }

        public string PersonPostcode
        {
            get { return strPersonPostcode; }
            set { strPersonPostcode = value; }
        }

        public string PersonPhone
        {
            get { return strPersonPhone; }
            set { strPersonPhone = value; }
        }

        public string PersonEmail
        {
            get { return strPersonEmail; }
            set { strPersonEmail = value; }
        }

        public int AccountNumber
        {
            get { return GenerateAccountNumber(); }
        }

        public int GenerateAccountNumber()
        {
            Random rand1 = new Random();
            int r = rand1.Next(1, 50);
            return r;
        }

        public Customer() : base()
        {
            intmyAccNumb = 0;
            dblmyBalance = 0.00;
        }

        public Customer(String strNewFirstName, String strNewSurname, String strNewAddress, String strNewTown, String strNewCounty, String dteNewPostcode, String strNewPhone, String strNewEmail, Double dblmyBalance) : base()
        {
            intmyAccNumb = 999;
            dblmyBalance = 0;
        }
    }
}
