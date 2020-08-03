using System;
using System.Runtime.InteropServices.ComTypes;

namespace BernardLab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Circle Tester");

            int circleCount = 0;
            while (Circle.UserContinueSelection == true)
            {
                circleCount++;
                
                                    Console.Write("Enter radius: ");

                try
                {
                    var userRadius = Double.Parse(Console.ReadLine());
                
                    var circle = new Circle(userRadius);

                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                    Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                        //exception message
                }

                Circle.UserContinue();
                

             }
            Console.WriteLine($"Goodbye. You created {circleCount} Circle object(s).");
        }
    }
}