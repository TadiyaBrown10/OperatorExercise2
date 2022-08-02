using System;

namespace OperatorExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = Math.PI * (radius * radius);

            Console.WriteLine($"The area of a circle with {radius} is {areaOfCircle}");


        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
        
    }
}