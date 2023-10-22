using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeExample
{
    // C# program to demonstrate the 
    // Type.GetMember(String) Method 

    class GetMemberExample
    {

        // Main Method 
        public static void GetMemberExampleMain()
        {
            // Declaring and initializing object of Type 
            Type objType = typeof(Student);

            // try-catch block for handling Exception 
            try
            {

                MemberInfo[] info = objType.GetMember("Name");

                // Display the Result 
                Console.WriteLine("Members of current type is as Follow: ");
                for (int i = 0; i < info.Length; i++)
                    Console.WriteLine(" {0}", info[i]);
            }

            // catch ArgumentNullException here 
            catch (ArgumentNullException e)
            {
                Console.Write("name is null.");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
        }
    }

    // Defining class Student 
    public class Student
    {
        public string Name = "Rahul";
        public string Dept = "Electrical";
        public int Roll = 10;
        public static int id = 02;
    }

}
