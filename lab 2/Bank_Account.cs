using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_2to4.lab_2
{
    internal class Bank_Account
    {
        public int Account_no;
        public string emails;
        public string user_name;
        public string account_type;
        public string account_balace;

        public void GetAccountDetails()
        {
            Console.Write("enter Account no : ");
            Account_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter emails : ");
            emails = Console.ReadLine();
            Console.Write("enter username: ");
            user_name = Console.ReadLine();
            Console.Write("enter account_type: ");
            account_type = Console.ReadLine();
            Console.Write("enter account_balance: ");
            account_balace = Console.ReadLine();

        }
        public void DisplayAccountDetails()

        {
            Console.WriteLine(Account_no);
            Console.WriteLine(emails);
            Console.WriteLine(user_name);   
            Console.WriteLine(account_type);
             Console.WriteLine(account_balace);
        }
    }
}
