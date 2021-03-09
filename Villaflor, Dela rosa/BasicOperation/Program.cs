using System;

namespace BasicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSum = {0}", num1 + num2 );
            Console.WriteLine("Difference = {0}", num1 - num2 );
            Console.WriteLine("Product = {0}", num1 * num2);
            Console.WriteLine("Quotient = {0}", num1 / num2);
            Console.WriteLine("Remainder = {0}", num1 % num2);

            Console.ReadKey();
        }
    }
}
