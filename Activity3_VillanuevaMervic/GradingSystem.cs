using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GradingSystem
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 98 && grade <= 100)
                Console.WriteLine("Grade is Equavalent " + "1.00" + "\r\n" + "The remarks is: Excelent");

            else if (grade >= 95 && grade <= 97)
                Console.WriteLine("Grade is Equavalent " + "1.25" + "\r\n" + "The remarks is: Excelent");

            else if (grade >= 92 && grade <= 94)
                Console.WriteLine("Grade is Equavalent " + "1.50" + "\r\n" + "The remarks is: Very Good");

            else if (grade >= 89 && grade <= 91)
                Console.WriteLine("Grade is Equavalent " + "1.75" + "\r\n" + "The remarks is: Very Good");

            else if (grade >= 86 && grade <= 88)
                Console.WriteLine("Grade is Equavalent " + "2.00" + "\r\n" + "The remarks is: Good");

            else if (grade >= 83 && grade <= 85)
                Console.WriteLine("Grade is Equavalent " + "2.25" + "\r\n" + "The remarks is: Good");

            else if (grade >= 80 && grade <= 82)
                Console.WriteLine("Grade is Equavalent " + "2.50" + "\r\n" + "The remarks is: Fair");

            else if (grade >= 77 && grade <= 79)
                Console.WriteLine("Grade is Equavalent " + "2.75" + "\r\n" + "The remarks is: Passed");

            else if (grade >= 75 && grade <= 76)
                Console.WriteLine("Grade is Equavalent " + "3.00" + "\r\n" + "The remarks is: Passed");

            else if (grade >= 72 && grade <= 74)
                Console.WriteLine("Grade is Equavalent " + "4.00" + "\r\n" + "The remarks is: Conditional (mt only)");

            else if (grade >= 60 && grade <= 71)
                Console.WriteLine("Grade is Equavalent " + "5.00" + "\r\n" + "The remarks is: Failed");

            else if (grade >= 0 && grade <= 59)
                Console.WriteLine("Grade is Equavalent " + "Inc" + "\r\n" + "The remarks is: Incomplete");


        }
    }
}
