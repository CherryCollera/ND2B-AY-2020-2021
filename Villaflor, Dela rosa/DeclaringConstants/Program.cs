using System;

namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
			double pi = 3.14159, Ac, rad;
            Console.WriteLine("Enter Radius: ");
            rad = Convert.ToDouble(Console.ReadLine());

            Ac = pi * rad * rad;

            Console.WriteLine (("Radius: "+ rad) + (", Area: " + Ac));
            Console.ReadKey();
		}
	}
}
