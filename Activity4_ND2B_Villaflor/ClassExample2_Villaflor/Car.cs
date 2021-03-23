using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample2
{
    class Car
    {
        private string color;
        public Car(string color)
        {
            this.color = color;
        }
        public string Describe()
        {
            return "This car is " + color;
        }
    }
}
