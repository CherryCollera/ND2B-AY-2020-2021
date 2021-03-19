using System;


namespace CompareNames
{

    public class Program 
    {
        public static void Main()
        {
		string string1 = "Iva";
   string string2 = "Iva";
      string string3 = "Ivan";
         string string4 = "Ivan";
            string string5 = "IVAN";
   Console.WriteLine("using Equals() Method");
        Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Equals(string1, string2));
             Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
                  Console.WriteLine(" lenght of {0} is {1}", string1, string1.Length);
                       Console.WriteLine(" string {0} Substring(0,3) will return {1}", string5,string5.Substring(0,3));
   Console.WriteLine("using Compare () Method");
        Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
             Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
                  Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
                       Console.WriteLine(" compare {0} to {1}: {2}", string4, string5, String.Equals(string4, string5));
    Console.WriteLine("using CompareTo() Method");
          Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
                Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
                      Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, string2.CompareTo(string1));	
        }
    }
}