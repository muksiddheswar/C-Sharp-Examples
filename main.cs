using C_Sharp_Examples.src.HTTPListenerExample;
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
            //SimpleListener.StartServer();
            ListenerResponseText.StartServerWithTextResponse();

        }
    }
}

