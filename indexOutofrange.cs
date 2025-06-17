using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class indexOutofrange
    {
       public void demo()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(numbers[5]); 
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
