using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    internal class Staff
    {
        public string Name;
        public string Depatment;
        public string Designation;
        public string Experience;
        public double Salary;
        public void Getdata() 
        {
            Console.Write("enter user name: ");
            Name = Console.ReadLine();
            Console.Write("enter department: : ");
            Depatment = Console.ReadLine();
            Console.Write("enter Designation: ");
            Designation = Console.ReadLine();
            Console.Write("enter experience: ");
            Experience = Console.ReadLine();
            Console.Write("enter salary");
            Salary = Convert.ToDouble(Console.ReadLine());

        } 
        public void displaydata()
        {
            if(Designation.ToLower() == "hod")
            {
                Console.WriteLine($"hod is {Name} and his/her salary is {Salary}");
            }
        }
    }
}
