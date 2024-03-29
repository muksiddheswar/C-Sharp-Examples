﻿//using HTTPListenerExample;
using ExtensionMethod;
using System.Diagnostics;
using System;
using System.Net;
using System.Reflection.Emit;
using LINQ;
using Expressions;
using C_Sharp_Examples.src.Keywords.Modifiers.Sealed;
using C_Sharp_Examples.src.Keywords.Modifiers.AccessModifiers.Protected;
using ManagedAPI.Func;
using Keywords.Identifiers.Out;

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

            //ret = StringManipulation.StringManipulation.LeftOfRightmostOf("D:\\Codes\\Simple-WebServer\\ConsoleWebServer\\bin\\Debug\\net6.0\\ConsoleWebServer.dll", '\\');
            //Console.WriteLine(ret);

            //-- Extension examples --
            //string s = "Hello Extension Methods";
            //int i = s.WordCount();
            //Console.WriteLine(i);
            //Console.WriteLine(s.LeftOfChar('o'));

            //string s = " D:\\Codes\\Simple - WebServer\\ConsoleWebServer\\bin\\Debug\\net6.0\\ConsoleWebServer.dll";
            //string g = s.LeftOfRightmostOf('\\').LeftOfRightmostOf('\\').LeftOfRightmostOf('\\').LeftOfRightmostOf('\\') + "\\Website";
            //Console.WriteLine(g);   

            // -- LINQ Examples --
            //QueryOperation queryOperation = new QueryOperation();
            //queryOperation.Operation();

            // -- Lambda Examples --
            //LambdaExpressions.LambdaExample();
            //LambdaExpressions.LambdaWithLinq();
            //LambdaExpressions.StatementLambdaExample();
            //LambdaExpressions.ExpressionLambdaExample();


            // -- Sealed class and method examples --
            //Program.UseSealedClass();
            //Z z = new Z();
            //z.F2();



            // -- Access Modifier Examples --
            // -- PROTECTED -- 
            //B.ProtectedClassExample();


            // -- FUNC Example --
            //FuncExample.FuncExampleOneInput();
            //FuncExampleDelegate.FuncExampleDelegateMethod();
            //FuncExampleImplicitDelegate.FuncExampleImplicitDelegateMethod();


            // -- OUT EXAMPLE --
            Out_Example.OutMain();
        
        }
    }
}

