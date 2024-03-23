// C# code to define
// a Sealed Class
using System;

namespace C_Sharp_Examples.src.Keywords.Modifiers.Sealed
{
    // Sealed class
    sealed class SealedClass
    {

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {

        // Main Method
        public static void UseSealedClass()
        {
            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}