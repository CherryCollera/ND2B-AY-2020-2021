using System;

namespace ToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sum = {0}", num1 + num2);
            Console.ReadLine();
        }
    }
}
