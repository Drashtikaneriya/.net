using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class RBI
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("RBI");
        }
    }
     class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("HDFC");
        }
    }

    class SBI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("SBI");
        }
    }
    class ICIC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("ICIC");
        }
    }
}
