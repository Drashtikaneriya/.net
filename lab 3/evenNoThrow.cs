using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class evenNoThrow
    {
        int a;
        public void demo()
        {
            try
            {
                Console.WriteLine("enter number: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0)
                {
                    throw new Exception("number is not even ...!!!!");
                }
                else
                {
                    Console.WriteLine("number is even ..!!");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
