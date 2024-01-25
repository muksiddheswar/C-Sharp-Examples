using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExamples
{
    public static class ExtensionMethodExample
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string LeftOfChar(this string src, char c)
        {
            string ret = src;

            int index = src.IndexOf(c);

            if (index != -1)
            {
                ret = src[..index];
            }

            return ret;
        }
    }
}
