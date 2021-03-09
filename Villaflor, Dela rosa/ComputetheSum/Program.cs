using System;

namespace ComputetheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sum = {0} ", num1 + num2);
            Console.ReadLine();

        }
    }
}
