using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Do_While
{
    public static class Program
    {
       public static void Main()
        {
            int[] ETM09_nms = new int[] { 9, 11, 13, 15, 17 };
            int ETM09_sum = 0;
            int j = 0;

            do
            {
                ETM09_sum += ETM09_nms[j];
                j++;
            } while (j < 5);

            Console.WriteLine(ETM09_sum);
            Console.ReadKey();

        }
    }
}
