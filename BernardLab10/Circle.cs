using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BernardLab10
{

    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateCircumference()
        {
            // 2 *pi*radius
            //Radius = radius;
            var circumference = (2 * Math.PI) * Radius;
            Circumference = circumference;
            return Circumference;
        }
        public string CalculateFormattedCircumference()
        {
            CalculateCircumference();
            string newFormatCircumference = FormatNumber(Circumference);
            return newFormatCircumference;
        }
        public double CalculateArea()
        {
            //    //formula for area of a circle 2 pie r squared
            //    // c squared / 4pi
            Area = ((Circumference * Circumference) / (4 * Math.PI));
            return Area;
        }
        public string CalculateFormattedArea()
        {
            CalculateArea();
            string newFormatArea = FormatNumber(Area);
            return newFormatArea;
        }
        private string FormatNumber(double x)
        {
            double twoDecimalPlace = Math.Round(x, 2);
            var correctFormat = twoDecimalPlace.ToString();
            CorrectFormat = correctFormat;
            return CorrectFormat;
        }

        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double Circumference { get; set; }
        public double Area { get; set; }
        public string CorrectFormat { get; set; }

        public static bool UserContinueSelection { get; set; } = true;
        public static void UserContinue()
        {
            Console.Write("Continue? (y/n): ");
            var userChoice = Console.ReadLine();

            if (userChoice.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }


    }
}
