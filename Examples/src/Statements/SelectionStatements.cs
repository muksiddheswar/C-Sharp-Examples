using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Examples.src.Statements
{
    class SelectionStatements
    {

        public void SwitchExample(string day)
        {
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the work week.");
                    break;
                case "friday":
                    Console.WriteLine("End of the work week.");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("Midweek day.");
                    break;
            }
        }

        public static void TemperatureAdvice(int inputTemperature)
        {
            int temperature = inputTemperature; // Do not change this line

            // Write your code here
            if (temperature < 0)
            {
                Console.WriteLine("Wear a heavy coat");
            }
            else if (temperature >= 0 && temperature < 15)
            {
                Console.WriteLine("Wear a jacket");
            }
            else if (temperature >= 15 && temperature < 25)
            {
                Console.WriteLine("Wear a t-shirt");
            }
            else // temperature > 25
            {
                Console.WriteLine("Wear shorts");

            }
        }
    }
}
