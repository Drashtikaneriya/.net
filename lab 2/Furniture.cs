using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    internal class Furniture
    {
        public String Material;
        public double price;
    }
     class Table : Furniture
    {
        public double Height;
        public double SurfaceArea;
        //public Table(String Material, double Price, double Height, double SurfaceArea)
        //{
        //    this.Material = Material;
        //    this.price = price;
        //    this.Height = Height;
        //    this.SurfaceArea = SurfaceArea;
        //}
        public void displayData(String Material, double price, double Height, double SurfaceArea)
        {
            Console.WriteLine("Material Type : " + Material);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Surface Area : " + SurfaceArea);
        }
    }
}
