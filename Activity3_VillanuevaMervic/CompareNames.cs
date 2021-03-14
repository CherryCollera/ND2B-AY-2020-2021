using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CompareNames
{
    public static class Program
    {
        public static void Main()
        {

            string string1 = "Mervic";
            string string2 = "Mervic";
            string string3 = "Villanueva";
            string string4 = "villanueva";
            string string5 = "VILLANUEVA";

            Console.WriteLine("Using Equals() methods");

            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Equals(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
            Console.WriteLine("Length of {0} is {1} ", string1, string1.Length);
            Console.WriteLine("String {0} SubString(0,3) will return {1}", string5, string5.Substring(0,3));

            Console.WriteLine("Using Compare() method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
            Console.WriteLine(" compare {0} to {1}: {2}", string4, string5, String.Compare(string4, string5));

            Console.WriteLine("Using CompareTo() methods");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string3.CompareTo(string1));
        }
    }
}