/* /*19-01908
Jeande P. Sarmiento
Mervic M. Villanueva
ND2B
March 4, 2021
This program will compute for the Average */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample6_ComputeAve
{
    class Program
    {
        static void Main(string[] args)
        {
            double ave = 0;
            Console.WriteLine("Enter 5 grades: ");
            
            for (int i= 1; i<=5; i++)
            {
                Console.Write("");
                double grades = Convert.ToDouble(Console.ReadLine());
                ave += grades;

            }
            double fa = ave / 5;
            Console.Write("The Average is " + fa);
            Console.ReadKey();
        }
    }
}
