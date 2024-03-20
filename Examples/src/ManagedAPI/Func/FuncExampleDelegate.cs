using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedAPI.Func
{
    internal class FuncExampleDelegate
    {

        delegate string ConvertMethod(string inString);

        public static void FuncExampleDelegateMethod()
        {
            // Instantiate delegate to reference UppercaseString method
            ConvertMethod convertMeth = UppercaseString;
            string name = "Dakota";
            // Use delegate instance to call UppercaseString method
            Console.WriteLine(convertMeth(name));
        }

        private static string UppercaseString(string inputString)
        {
            return inputString.ToUpper();
        }

    }
}
