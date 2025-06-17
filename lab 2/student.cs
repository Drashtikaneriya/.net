using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2to4.lab_2
{
    
            class Student
        {
           
            private string Enrollment_No;
            private string Student_Name;
            private int Semester;
            private float CPI;
            private float SPI;

            public Student(string enrollmentNo, string name, int semester, float cpi, float spi)
            {
                Enrollment_No = enrollmentNo;
                Student_Name = name;
                Semester = semester;
                CPI = cpi;
                SPI = spi;
            }

            public void DisplayStudentDetails()
            {
                Console.WriteLine("Student Details:");
                Console.WriteLine($"Enrollment No: {Enrollment_No}");
                Console.WriteLine($"Name: {Student_Name}");
                Console.WriteLine($"Semester: {Semester}");
                Console.WriteLine($"CPI: {CPI}");
                Console.WriteLine($"SPI: {SPI}");
            }
        }

    }

