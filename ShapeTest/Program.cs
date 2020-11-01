using System;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            double num2 = double.Parse(Console.ReadLine());



            Rectangle rectangle = new Rectangle(0.0, 0.0, num1, num2);
            Triangle triangle = new Triangle(0.0, 0.0, num1, num2);
            Squar squar = new Squar(0.0, 0.0, num1, num2);
            // Cube cube = new Cube(0.0, num1, num2);

            Console.WriteLine($"The area of rectangle is {rectangle.Area()}");
            Console.WriteLine($"The area of triangle is {triangle.Area()}");
            Console.WriteLine($"The area of squar is {squar.Area()}");
            // Console.WriteLine($"The area of cube is {Cube.Area()}");




        }
    }
}
