/* /*19-01908
Jeande P. Sarmiento
Mervic M. Villanueva
ND2B
March 4, 2021
This program will Declaring Constants*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample7_DeclaringConstants
{
    class Program

    {
        
        static void Main(string[] args)
        {

            const double PI = 3.14159;
            double radius  ;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("Radius "+ radius);
           
            double areaCircle =(PI * radius * radius);
           
            Console.Write("Area: " + areaCircle);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
