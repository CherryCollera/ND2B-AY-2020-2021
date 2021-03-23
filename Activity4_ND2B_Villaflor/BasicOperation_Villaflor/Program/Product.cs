using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Product
    {
        public void ComputeProduct()
        {
            DeclareVar.Product = DeclareVar.First * DeclareVar.Second;
            //System.Console.WriteLine("\tThe Computation for Product is " + DeclareVar.Product);
        }
    }
}
