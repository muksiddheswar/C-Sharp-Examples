using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords.Identifiers.Out
{
    internal class Out_Example
    {
        public static void OutMain()
        {
            double radiusValue = 3.92781;
            //Calculate the circumference and area of a circle, returning the results to Main().
            CalculateCircumferenceAndArea(radiusValue, out double circumferenceResult, out double areaResult);
            System.Console.WriteLine($"Circumference of a circle with a radius of {radiusValue} is {circumferenceResult}.");
            System.Console.WriteLine($"Are of a circle with a radius of {radiusValue} is {areaResult}.");
            Console.ReadLine();
        }

        //The calculation worker method.
        public static void CalculateCircumferenceAndArea(double radius, out double circumference, out double area)
        {
            circumference = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
        }
    }
}
