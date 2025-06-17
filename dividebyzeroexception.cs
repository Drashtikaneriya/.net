using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class dividebyzeroexception
    {
       public void dividebyZero()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Excepation "+e.Message);                
            }
        }
    }
}
