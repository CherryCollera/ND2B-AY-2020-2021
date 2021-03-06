using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5_ComputeTheSum_Double
{
    /* /*19-01908
Jeande P. Sarmiento
Mervic M. Villanueva
ND2B
March 4, 2021
This program will compute for the sum of 2 interger values*/

   
    
        class Program
        {
            static void Main(string[] args)
            {
                double num1, num2;

                Console.Write("Enter First number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sum = {0} ", num1 + num2);
                Console.ReadKey();

            }
        }
    }

