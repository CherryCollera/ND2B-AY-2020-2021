using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations_Villanueva
{
    class Product
    {
        public void ComputeProduct()
        {
            DeclareVar.product = DeclareVar.num1 * DeclareVar.num2;
            Console.WriteLine("\n\tThe Product is " + DeclareVar.product);

        }
    }
}
