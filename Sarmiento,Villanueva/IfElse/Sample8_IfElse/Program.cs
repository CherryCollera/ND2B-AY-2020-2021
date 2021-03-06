/* /*19-01908
Jeande P. Sarmiento
Mervic M. Villanueva
ND2B
March 4, 2021
This program will display if else */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample8_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter First Number: \t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: \t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number: \t");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                if (num1 > num3)
                {
            Console.Write("\n {0} is greater than {1} and {2} ",num1,num2,num3);  }
                 else
                    {
                        Console.Write("\n {0} is greater than { 1}and { 2}",num3,num2,num1);
                      }
                }  
                  else if (num2 > num3) 
            
                    Console.Write("\n {0} is greater than {1}and {2}",num2,num1,num3);
                    
            else if ((num2 == num3) && num3 == num1)
                
                Console.Write("\n {0}, {1} and {2} are equal",num1,num2,num3);
            
            else
                  Console.Write("\n { 0} is greater than { 1} and { 2} ",num3,num2,num1);

            
            
            
            
            Console.ReadLine();

            Console.WriteLine("\n\nCoded By: Sarmiento and Villanueva");

            Console.ReadKey();

                
    

        }
    }
}
