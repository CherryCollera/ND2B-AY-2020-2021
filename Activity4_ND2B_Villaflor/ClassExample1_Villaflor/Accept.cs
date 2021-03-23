using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter your firstname and lastname:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }
    }
}
