using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal interface  interfaceCal
    {
        public void addition(int x, int y);
        public void subtraction(int x, int y);
    }
     public class  Result: interfaceCal
    {
       
        public void addition(int x, int y)
        {
            Console.WriteLine("x+y: "+(x + y));
        }
        public void subtraction(int x, int y)
        {
            Console.WriteLine("x+y: " + (x - y));
        }
    }
}
