using System;


namespace Comparenumbers
{

    public class Program 
    {
        static void Main()
        {
			int IVAN_num1,
IVAN_num2,IVAN_num3;
			Console.Write("Enter first number: ");
						IVAN_num1 = Convert.ToInt32(Console.ReadLine());
									Console.Write("Enter second number: ");
												IVAN_num2 = Convert.ToInt32(Console.ReadLine());
															Console.Write("Enter third number: ");
																		IVAN_num3 = Convert.ToInt32(Console.ReadLine());
    if ((IVAN_num1 == IVAN_num2) && IVAN_num1>IVAN_num3)
             Console.Write("{0} and {1} are greater than {2}",IVAN_num1,IVAN_num2,IVAN_num3);
                 else if ((IVAN_num1 == IVAN_num3) && 
                     	IVAN_num1>IVAN_num2)
                     	         Console.Write("{0} and {2} are greater than {1}", IVAN_num1,IVAN_num2,IVAN_num3);
                     	             else if ((IVAN_num2 == IVAN_num3) && IVAN_num2>IVAN_num1);  	                          else if ((IVAN_num3 > IVAN_num2) && IVAN_num3>IVAN_num1)
                     	                                   Console.Write("{2} are greater than {0} and {1}",IVAN_num1,IVAN_num2,IVAN_num3);
                     	                                       else if ((IVAN_num2 > IVAN_num1) && IVAN_num2>IVAN_num3)
                     	                                                Console.Write("{1} are greater than {0} and {2}",IVAN_num1,IVAN_num2,IVAN_num3);
                     	                                                    else if ((IVAN_num1 > IVAN_num2) && IVAN_num1>IVAN_num3)
                     	                                                             Console.Write("{0} are greater than {1} and {2}",IVAN_num1,IVAN_num2,IVAN_num3);
                     	                                                                 else
                     	                                                                          Console.Write("{0}, {1} and {2} are equal",IVAN_num1,IVAN_num2,IVAN_num3);
        }
    }
}