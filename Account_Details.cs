using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    internal class Account_Details
    {
        public string AccountHolderName;
        public int AccountNumber;
        public double Balance;
        public double RateOfInterest;
        public int Years;


        public void GetAccountDetails()
        {
            Console.Write("Enter Account Holder Name: ");
            AccountHolderName = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Balance: ");
            Balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest (in %): ");
            RateOfInterest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            Years = Convert.ToInt32(Console.ReadLine());
        }
        public class Interest : Account_Details
        {
            public void CalculateAndDisplayInterest()
            {
                double interest = (Balance * RateOfInterest * Years) / 100;
                Console.WriteLine("\n--- Account Summary ---");
                Console.WriteLine("Account Holder: " + AccountHolderName);
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Balance: " + Balance);
                Console.WriteLine("Interest Rate: " + RateOfInterest + "%");
                Console.WriteLine("Years: " + Years);
                Console.WriteLine("Total Interest: " + interest);
            }
        }
    }
}
