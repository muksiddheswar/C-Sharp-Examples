using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Examples.src.DataTypes
{
    internal class CollectionsAndArrays
    {
        public static void ArrayExample()
        {
            int[] myNumbers = { 4, 6, 2, 7, 1, 7, 2, 2, 7, 8, 9, 10 }; // Do not change this line

            // Loop through the array and sum the numbers, then print the sum
            int sum = 0;
            for (int i = 0; i < myNumbers.Length; i++)
            {
                sum += myNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
