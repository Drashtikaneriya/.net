using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class Distance
    {
        public double dist1, dist2, dist3;

        public Distance(double d1, double d2)
        {
            dist1 = d1;
            dist2 = d2;
            dist3 = 0;
        }
        public void AddDistances()
        {
            dist3 = dist1 + dist2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("Distance 1: " + dist1);
            Console.WriteLine("Distance 2: " + dist2);
            Console.WriteLine("Total Distance (dist3): " + dist3);
        }
    }
}
