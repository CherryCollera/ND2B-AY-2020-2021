using System;

namespace Switch
{

    public class Program 
    {
        public static void Main()
        {
		string name;
		char gender;
		
		Console.Write("Enter your name: ");
		name = Console.ReadLine();
		Console.Write("Enter your Gender M/F: ");
		gender = Convert.ToChar(Console.ReadLine());
		
		switch(gender)
		{
			case 'M':
			case 'm':
			Console.WriteLine("\nHi" + name + "!" + "Your gender is Male!.");
			break;
			case 'F':
			case 'f':
            Console.WriteLine("Hi" + name + "!" + "Your gender is Female!.");
			break;
			default:
			Console.WriteLine("\n Invalid input...Try again!!!...");
			break;
		}
		Console.ReadKey();
        }
    }
}