using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle's length?");
            string input1 = Console.ReadLine();
            int length = int.Parse(input1);
            Console.WriteLine("What is the rectangle's width?");
            string input2 = Console.ReadLine();
            int width = int.Parse(input2);
            int area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
