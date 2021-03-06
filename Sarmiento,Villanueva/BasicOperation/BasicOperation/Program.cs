using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            
    
                double num1, num2;
                Console.Write("Enter 1st num: ");

                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd num: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("sum={0}", num1 + num2);
                Console.ReadLine();

                Console.Write("difference ={0}", num1 - num2);
                Console.ReadLine();

                Console.Write("Product ={0}", num1 * num2);
                Console.ReadLine();

                Console.WriteLine("quotient ={0}", num1 / num2);
                Console.ReadLine();

                Console.Write("Remaider = {0}", num1 % num2);
                Console.ReadKey();
      

}
    }
}
