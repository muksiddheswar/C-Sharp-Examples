// C# code to show restrictions
// of a Sealed Class
using System;

namespace Modifiers.Sealed
{ 
    class Bird
    {

    }

    // Creating a sealed class
    sealed class Test : Bird
    {
    }

    // Inheriting the Sealed Class
    /*
    class Example : Test // Failure
    {
    }

    // Driver Class
    class Program
    {
        public static void MainMethod()
        {
        }
    }
    */
}