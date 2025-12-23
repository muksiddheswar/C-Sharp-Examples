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

            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }

        public static void AccessString()
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            //string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}
