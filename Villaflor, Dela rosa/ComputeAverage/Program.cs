using System;

namespace ComputeAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double  n, sum = 0 ;

            Console.Write("Enter 5 Grades: \n");
            for (int i = 1; i <= 5; i++)
            {

                n = Convert.ToDouble(Console.ReadLine());
                sum += n;
            }
            Console.Write("The Average is : {0:0.0}", sum /5 + "\n");
        }
    }
}
