using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    public abstract class abstactclass
    {
        public abstract void sumOftwo(int x, int y);
        public abstract void sumOfThree(int x, int y,int z);
        
    }
    public  class  Calculate : abstactclass
    {
        public override void sumOftwo(int x, int y) {
            Console.WriteLine("x+y:" + (x + y));
        }
        public override void sumOfThree(int x, int y, int z) {
            Console.WriteLine("x+y+z:" + (x + y+z));

        }

    }
}
