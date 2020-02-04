using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Assignment3
{
    public partial class frmPicnicCafe : Form
    {
        public static Person P1 = new Person();
        public static Loyalty L1 = new Loyalty();

        public frmPicnicCafe()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            P1.CustomerFirstName = txtFirstName.Text;
            P1.CustomerSurname = txtSurname.Text;
            P1.CustomerAddress = txtAddress.Text;
            P1.CustomerTown = txtTown.Text;
            P1.CustomerCounty = txtCounty.Text;
            P1.CustomerPostcode = txtPostcode.Text;
            P1.CustomerPhone = txtPhone.Text;
            P1.CustomerEmail = txtEmail.Text;
            MessageBox.Show("Information Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = P1.CustomerFirstName;
            txtSurname.Text = P1.CustomerSurname;
            txtAddress.Text = P1.CustomerAddress;
            txtTown.Text = P1.CustomerTown;
            txtCounty.Text = P1.CustomerCounty;
            txtPostcode.Text = P1.CustomerPostcode;
            txtPhone.Text = P1.CustomerPhone;
            txtEmail.Text = P1.CustomerEmail;

        }

        private void frmPicnicCafe_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double deposit = Convert.ToDouble(txtPointsEarned.Text);
            L1.Deposit(deposit);
            txtPointsEarned.Text = "";
            txtMoneySpent.Text = "";
            MessageBox.Show("Balance: " + L1.DisplayBalance());
            txtBalance.Text = Convert.ToString(L1.DisplayBalance());
        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtMoneySpent.Text) < 10)
            {
                txtPointsEarned.Text = Convert.ToString(Convert.ToInt32(txtMoneySpent.Text));
            }
            else if (Convert.ToDouble(txtMoneySpent.Text) > 10 && Convert.ToDouble(txtMoneySpent.Text) < 50)
            {
                txtPointsEarned.Text = Convert.ToString(Convert.ToInt32(txtMoneySpent.Text) * 2);
            }
            else if (Convert.ToDouble(txtMoneySpent.Text) > 50)
            {
                txtPointsEarned.Text = Convert.ToString(Convert.ToInt32(txtMoneySpent.Text) * 5);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double withdraw = Convert.ToDouble(txtWithdraw.Text);
                L1.Withdrawal(withdraw);
                txtWithdraw.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtWithdraw.Text = "";
            }
            MessageBox.Show("Balance: " + L1.DisplayBalance());
            txtBalance.Text = Convert.ToString(L1.DisplayBalance());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    namespace Classes_in_C
    {
        class BankAccount : Person
        {
            int intmyAccountNumber;
            double dblmyPoints;
        }
    }
}
