using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Area
    {
        public void area1(int a)
        {
            Console.WriteLine("area of square: " + (a * a));
        }
        public void area1(int a, int b)
        {
            Console.WriteLine("area of rec: " + (a * b));

        }
        public void area1(double a)
        {
            Console.WriteLine("area of circle"+(2 * 12.14 * a));
        }
    }
}
