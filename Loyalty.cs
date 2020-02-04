using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Assignment3
{
    public class Loyalty
    {

        double dblmyPoints;
        int intmyAccountNumber = 100;
        public int AccountNumber;

        public double Points
        {
            set
            {
                if ((value + dblmyPoints) >= 0)
                {
                    dblmyPoints = value;
                }

                else
                {
                    throw new ArgumentException("Not enough Points");
                }
            }
            get
            {
                return dblmyPoints;
            }
        }

        public void Deposit(double Amount)
        {
            Points += Amount;
        }

        public void Withdrawal(double Amount)
        {
            Points -= Amount;
        }

        public double DisplayBalance()
        {
            return Points;
        }

        public Loyalty()
        {
            dblmyPoints = 0.00;
            intmyAccountNumber = 100;
        }

        public Loyalty(String strNewFirstName, String strNewSurame, String strNewAddress, String strNewTown, String strNewCounty, String strNewPostcode, String strNewPhone, String strNewEmail, int dblPoints)
        {
            Points = dblPoints;
            intmyAccountNumber = AccountNumber;
        }

        public int GenerateAccountNumber()
        {
            return 56;
        }

    }
}
