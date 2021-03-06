/* /*19-01908
Jeande P. Sarmiento
Mervic M. Villanueva
ND2B
March 4, 2021
This program will compute for the sum of 2 interger values*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample4_ComputeTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sum = {0} ", num1 + num2);
            Console.ReadKey();

        }
    }
}
