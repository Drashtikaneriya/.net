using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    internal class salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;
        public salary()
        {
            Console.WriteLine("enter basic: ");
            Basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());
            DA = 10000;
            HRA = 20000;
        }
        public void Totalsalary()
        {
            Console.WriteLine("salary: "+(Basic+TA+HRA+DA));
        }
    }
}
