using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedAPI.Func
{
    internal class FuncExampleImplicitDelegate
    {
        public static void FuncExampleImplicitDelegateMethod()
        {
            // Instantiate delegate to reference UppercaseString method
            Func<string, string> convertMethod = UppercaseString;
            string name = "Dakota";
            // Use delegate instance to call UppercaseString method
            Console.WriteLine(convertMethod(name));

            string UppercaseString(string inputString)
            {
                return inputString.ToUpper();
            }

        }


        // This code example produces the following output:
        //
        //    DAKOTA
    }
}
