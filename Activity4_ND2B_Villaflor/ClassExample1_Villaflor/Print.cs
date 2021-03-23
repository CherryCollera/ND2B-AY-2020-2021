using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();
            a.AcceptDetails();
            System.Console.Write("Hello " + a.firstname + " " + a.lastname + "!!!\nYou have created classes in OOP");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
        }
    }
}
