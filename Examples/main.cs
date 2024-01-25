//using HTTPListenerExample;
using ExtensionMethodExamples;
using System.Net;

namespace C_Sharp_Examples
{
    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("Hi");

            //DataTypes.DataTypes.data_type_func();

            //PolymorphismExample
            //PolymorphismExample.PolymorphismExample.PolymorphismDriverFunction();
            //OverrideExample.OverrideExample.OverrideExampleDriver();

            // Type Example
            //TypeExample.GetMemberExample.GetMemberExampleMain();
            //TypeExample.GetMemberNullExample.GetMemberNullExampleMain();

            //TextWriterTraceListenerExample.TraceListenerExample();


            //-- HttpListener Examples --
            ////HTTPListenerExample.SimpleListener.StartServer();
            //HTTPListenerExample.ListenerResponseText.StartServerWithTextResponse();

            //-- String Manipulation --
            //var ret = StringManipulation.StringManipulation.LeftOfChar("www.fff.com", '.');
            //Console.WriteLine(ret);

            //ret = StringManipulation.StringManipulation.RightOfChar("www.fff.com", '.');
            //Console.WriteLine(ret);

            //-- Extension examples --
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);
            Console.WriteLine(s.LeftOfChar('o'));
        }
    }
}

