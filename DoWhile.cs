using System;


namespace DoWhile
{

    public class Program 
    {
        public static void Main()
        {
		int [] ETM09_nms = new int[] {9, 11, 13, 15, 17 };
		int ETM09_sum = 0;
		int ivan = 0;
		
		do
		{
			ETM09_sum += ETM09_nms [ivan];
			ivan++;
		} while(ivan < 5);
		
		Console.WriteLine(ETM09_sum);
		Console.ReadKey();
        }
    }
}