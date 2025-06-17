using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    internal class Candidate
    {
        int ID;
        string Name;
        double Weight;
        double Height;

        public void GetCandidateDetails()
        {
            Console.Write("enter user id: ");
             ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Name : ");
             Name = Console.ReadLine();
            Console.Write("enter weight: ");
             Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter height: ");
             Height = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine(ID);
            Console.WriteLine($"name is {Name}");
            Console.WriteLine($"weight is {Weight}");
            Console.WriteLine($"height is {Height}");
        }
    }
}
