using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_3
{
    internal class Distance
    {
        private double dist1, dist2, dist3;

        // Constructor to initialize dist1 and dist2
        public Distance(double d1, double d2)
        {
            dist1 = d1;
            dist2 = d2;
            dist3 = 0;
        }

        // Function to add dist1 and dist2, and store in dist3
        public void AddDistances()
        {
            dist3 = dist1 + dist2;
        }

        // Function to display the addition result
        public void DisplayDistance()
        {
            Console.WriteLine("Distance 1: " + dist1);
            Console.WriteLine("Distance 2: " + dist2);
            Console.WriteLine("Total Distance (dist3): " + dist3);
        }
    }
}
