using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Examples.src.OperatorsAndExpressions
{
    public class Operators
    {
        public static void additionExample()
        {
            int a = 5;
            int b = 10;
            int sum_ = a + b;
            Console.WriteLine("Sum: " + sum_);

            int x = 5;
            int y = 3;
            // Add int x and int y and print the result
            int sum = x + y;
            Console.WriteLine(sum);
        }
        public static void GreaterThan()
        {
            int x = 15;
            int y = 10;

            // Compare if x is greater than y and print the result
            bool result = x > y;
            Console.WriteLine(result);

        }
    }
}
