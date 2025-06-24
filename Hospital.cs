using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("main hospital..!!!");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo hospital..!!!");
        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital..!!!");
        }
    }
    class Gokul_Superspeciality : Hospital {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality hospital..!!!");
        }
    }
}
