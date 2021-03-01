using System;

namespace Sample3_InputMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Welcome to OOP environment.");

            Console.WriteLine("");
            Console.WriteLine("Enter your name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine("Hello " + name2 );
            Console.WriteLine("Welcome to OOP environment.");
        }
    }
}
