using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Form1 : Form
    {
        private List<Account> accounts=new List<Account>();
        public Form1()
        {
            InitializeComponent();
            if(rbtChecking.Checked==true)
            {
                txtDailyWithdrawlLimit.Enabled = true;
                txtInterestRate.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpAccountDetails_Enter(object sender, EventArgs e)
        {

        }

        private void rbtVisa_CheckedChanged(object sender, EventArgs e)
        {
            txtDailyWithdrawlLimit.Enabled =false;
            txtInterestRate.Enabled = true;
            txtDailyWithdrawlLimit.Text = "";
        }

        private void rbtChecking_CheckedChanged(object sender, EventArgs e)
        {
            txtDailyWithdrawlLimit.Enabled = true;
            txtInterestRate.Enabled = false;
            txtInterestRate.Text = "";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account account;
                if (rbtChecking.Checked == true)
                {
                    account = new CheckingAccount(Convert.ToInt32(txtAccountNumber.Text), txtClientName.Text, Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtDailyWithdrawlLimit.Text));

                }
                else
                {
                    account = new VisaAccount(Convert.ToInt32(txtAccountNumber.Text), txtClientName.Text, Convert.ToDouble(txtBalance.Text), Convert.ToDouble(txtInterestRate.Text));
                }
                accounts.Add(account);
                txtAccountNumber.Text = "";
                txtBalance.Text = "";
                txtClientName.Text = "";
                txtDailyWithdrawlLimit.Text = "";
                txtInterestRate.Text = "";
                MessageBox.Show("Number of Accounts: "+accounts.Count.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int AccountNo = Convert.ToInt16(txtSearchAccount.Text);
                foreach(Account i in accounts)
                {
                    if(i.Number==AccountNo)
                    {
                        if(i.GetType().ToString().Equals("AccountsApp.CheckingAccount"))
                        {
                            txtAccountNumber.Text =i.Number.ToString();
                            txtBalance.Text =i.Balance.ToString();
                            txtClientName.Text = i.ClientName;
                            CheckingAccount c = (CheckingAccount)i;
                            txtDailyWithdrawlLimit.Text = c.WithdrawLimit.ToString();
                            txtInterestRate.Enabled = false;
                            txtDailyWithdrawlLimit.Enabled = true;
                            txtInterestRate.Text = "";
                             }
                        else
                        {
                            txtAccountNumber.Text = i.Number.ToString();
                            txtBalance.Text = i.Balance.ToString();
                            txtClientName.Text = i.ClientName;
                            VisaAccount v = (VisaAccount)i;
                            txtInterestRate.Text =v.InterestRate.ToString();
                            txtDailyWithdrawlLimit.Text = "";
                            txtDailyWithdrawlLimit.Enabled = false;
                            txtInterestRate.Enabled = true;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
