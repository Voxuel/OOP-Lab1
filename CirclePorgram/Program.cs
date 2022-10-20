using System;

namespace CirclePorgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle(5);
            Console.WriteLine(circle1.GetArea());
            var circle2 = new Circle(6);
            Console.WriteLine(circle2.GetArea());
            var circle3 = new Circle(5, 10);
            Console.WriteLine(circle3.GetVolume());
            Console.WriteLine(circle1.GetCircumference());
        }
    }
}
