using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class overideIntfloat
    {
        public void Twoadd(int a,int b)
        {
            Console.WriteLine("add two int no:"+(a+b));
        }
        public void Twoadd(float a,float b)
        {
            Console.WriteLine("add two float no : "+(a+b));
        }
    }
}
