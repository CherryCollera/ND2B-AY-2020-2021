using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tBasic Operation\n-------------------");
            Console.WriteLine("\tSum\t\t[ a ]");
            Console.WriteLine("\tDifference\t[ b ]");
            Console.WriteLine("\tProduct\t\t[ c ]");
            Console.WriteLine("\tQuotient\t[ d ]");
            Console.WriteLine("\tRemainder\t[ e ]");
            Console.WriteLine("Choose: ");
            char enter = Convert.ToChar(Console.ReadLine());

            Input p = new Input();
            p.InputData();
            Sum a = new Sum();
            a.ComputeSum();
            Difference b = new Difference();
            b.ComputeDifference();
            Product c = new Product();
            c.ComputeProduct();
            Quotient d = new Quotient();
            d.ComputeQuotient();
            Remainder e = new Remainder();
            e.ComputeRemainder();
            Console.ReadLine();

            if (enter == ('a'))
            {
                Console.WriteLine("\tThe Computation for Sum is " + DeclareVar.Sum);
            }
            else if (enter == ('b'))
            {
                System.Console.WriteLine("\tThe Computation for Difference is " + DeclareVar.Difference);
            }
            else if (enter == ('c'))
            {
                Console.WriteLine("\tThe Computation for Product is " + DeclareVar.Product);
            }
            else if (enter == ('d'))
            {
                Console.WriteLine("\tThe Computation for Quotient is " + DeclareVar.Quotient);
            }
            else if (enter == ('e'))
            {
                Console.WriteLine("\tThe Computation for Remainder is " + DeclareVar.Remainder);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
