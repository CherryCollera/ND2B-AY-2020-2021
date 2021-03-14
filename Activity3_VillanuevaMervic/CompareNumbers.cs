using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace CompareNumbers
{
    public static class Program
    {
        public static void Main()
        {
            int num1, num2, num3;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Last number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num2 > num1) && (num1 > num3))
            {
                Console.WriteLine(num2 + " is greater than " + num1 + " and " + num3 + "\n" + num1 + " is less than " + num2 + "\n" + num3 + " is less than " + num2);
            }
            else if ((num3 > num1) && (num1 > num2))
            {
                Console.WriteLine(num3 + " is greater than " + num1 + " and " + num2 + "\n" + num1 + " is less than " + num3 + "\n" + num2 + " is less than " + num3);
            }
            else if ((num1 == num2) && (num2 == num3))
            {
                Console.WriteLine("\n {0}, {1}, and {2} are equal", num1,num2,num3);
            }
        }
    }
}