using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class areaRecSquare
    {
        public void area(int a)
        {
            Console.WriteLine("area of square: "+ (a * a));
        }
        public void area(int a, int b)
        {
            Console.WriteLine("area of rec: " +(a * b));
        }
    }
}