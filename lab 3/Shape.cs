using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lab3
{
    internal interface Shape_Interface
    {
        void Circle(double radius);
        void Triangle(double baseLength, double height);
        void Square(double sideLength);

    }
    public class Shape : Shape_Interface
    {
        public void Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
        public void Triangle(double baseLength, double height)
        {
            double area = 0.5 * baseLength * height;
            Console.WriteLine("Area of Triangle: " + area);
        }
        public void Square(double sideLength)
        {
            double area = sideLength * sideLength;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}
