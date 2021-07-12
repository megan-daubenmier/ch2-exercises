using System;

namespace FuelEfficiency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string input1 = Console.ReadLine();
            Console.WriteLine("How many gallons of gas has your car used?");
            string input2 = Console.ReadLine();
            double milesDriven = double.Parse(input1);
            double gallonsGuzzled = double.Parse(input2);
            double mpg = milesDriven / gallonsGuzzled;
            Console.WriteLine("Your car's fuel efficiency is " + mpg + " miles per gallon.");
        }
    }
}
