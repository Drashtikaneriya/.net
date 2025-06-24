using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class BankAccount
    {
        double initialBalance = 0.0;
        string accountHolderName = "";
        
        public BankAccount() { }

        public BankAccount(double initialBalance,string accountHolderName)
        {
            this.initialBalance = initialBalance;
            this.accountHolderName =  accountHolderName;
        }

        public void Deposite(double cash)
        {
            initialBalance = initialBalance+ cash;
            Console.WriteLine("deposite by cash: " + initialBalance);
        }
        public void Withdrow(double cash)
        {
            initialBalance = initialBalance-cash;
            Console.WriteLine("deposite by cash: " + initialBalance);

        }
        public void Deposite(string name, double cash)
        {
            initialBalance = initialBalance+cash;
            Console.WriteLine("deposite by cheak: " + initialBalance);

        }
        public void Withdrow(string name, double cash) { 
            initialBalance -= cash;
            Console.WriteLine("deposite by cheak: " + initialBalance);

        }
    }
}
