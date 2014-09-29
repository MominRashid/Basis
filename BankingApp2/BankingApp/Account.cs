using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        public string number;
        public string name;
        public double balance;

        public void Deposit(double amount)
        {
               balance +=amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public string GetReport()
        {
            return name + " , Your Account Number : " + number + "it's balance " + balance;

        }



    }
}
