using System;

namespace ClassExample2_Villanueva
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}
