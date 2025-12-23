using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Examples.src.DataTypes
{
    class Strings
    {
        public static void concatenateStrings()
        {
            string firstName = "John ";
            string lastName = "Doe";

            // Concatenate the strings then uppercase the result, and print it
            string fullName = firstName.ToUpper() + lastName.ToUpper();
            Console.WriteLine(fullName);
            Console.WriteLine(string.Concat(firstName.ToUpper() + lastName.ToUpper()));
            Console.WriteLine(fullName.Length);
        }
    }
}
