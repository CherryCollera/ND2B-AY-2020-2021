using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
                Console.WriteLine("{0} is greater than {1} and {2}", num1, num2, num3);
            else if ((num2 > num1) && (num2 > num3))
                Console.WriteLine("{0} is greater than {1} and {2}", num2, num1, num3);
            else
                Console.WriteLine("{0} is equal to {1} and {2}", num1, num2, num3);
            Console.ReadLine();
        }
    }
}
