using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount : Account
    {
        public const int TRANSACTION_FEE = 5;
        public double WithdrawLimit { get; set; }
        public CheckingAccount(int number, string clientName, double balance, double withrawLimit) : base(number, clientName, balance)
        {
            this.WithdrawLimit = withrawLimit;
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
