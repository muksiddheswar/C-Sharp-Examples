﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class QueryOperation
    {
        public void Operation()
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81, 60 };


            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            // Output: 97 92 81
        }

    }
}
