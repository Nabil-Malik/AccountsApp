using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class VisaAccount : Account
    {
        public const double TRANSACTION_FEE = 2.5;

        public double InterestRate { get; set; }
        public VisaAccount(int number, string clientName, double balance, double interestRate) : base(number, clientName, balance)
        {
            this.InterestRate = interestRate;
        }
        public override void Deposit(double amount)
        {
            this.Balance += amount;
            this.Balance = this.Balance - TRANSACTION_FEE;
        }

        public override void Withdraw(double amount)
        {
            this.Balance -= amount;
            this.Balance = this.Balance - TRANSACTION_FEE;
        }
    }
}
