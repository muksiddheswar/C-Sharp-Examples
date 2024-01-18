using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeExample
{

    class GetMemberNullExample
    {

        // Main Method 
        public static void GetMemberNullExampleMain()
        {
            // Declaring and initializing object of Type 
            Type objType = typeof(Student);

            // try-catch block for handling Exception 
            try
            {

                MemberInfo[] info = objType.GetMember(null);

                // Display the Result 
                Console.WriteLine("Members of current type is as Follow: ");
                for (int i = 0; i < info.Length; i++)
                    Console.WriteLine(" {0}", info[i]);
            }

            // catch ArgumentNullException here 
            catch (ArgumentNullException e)
            {
                Console.WriteLine("name is null.");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
        }
    }
}
