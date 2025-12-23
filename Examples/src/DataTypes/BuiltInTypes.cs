//using System;

using System;

namespace DataTypes

{
	class BuiltInTypes
	{
		public static void data_type_func()
		{
			int myNum = 5;               // integer (whole number)
			double myDoubleNum = 5.99D;  // floating point number
			float myFloatNum = 5.99F;
			char myLetter = 'D';         // character
			bool myBool = true;          // boolean
			//string myText = "Hello";     // string
			Console.WriteLine(myNum);
			Console.WriteLine(myDoubleNum);
            Console.WriteLine(myFloatNum);
            Console.WriteLine(myLetter);
			Console.WriteLine(myBool);
			//Console.WriteLine(myText);
        }

		// Declare an integer variable named 'number'
        // Initialize the variable with the value 42
        // Print the value of the variable 'number' to the console
		public static void data_type_integer()
		{ 
			int number = 42;             
			Console.WriteLine(number);

        }

        public static void data_type_typecast()
        {
            // Convert myDouble to an Int and print it to the console
            double myDouble = 42.65;
			int myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine(Convert.ToInt32(myDouble));

        }

		




    }
}