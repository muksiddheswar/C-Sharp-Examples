//using HTTPListenerExample;
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
using C_Sharp_Examples.src.HelloWorld;
using C_Sharp_Examples.src.UserInput;
using C_Sharp_Examples.src.OperatorsAndExpressions;
using C_Sharp_Examples.src.DataTypes;
using C_Sharp_Examples.src.Statements;
using C_Sharp_Examples.src.Classes.Methods;

namespace C_Sharp_Examples
{
    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("Hi");

            // Hello World
            //HelloWorld.printHelloWorld();

            // Data Types and Variables
            //DataTypes.DataTypes.data_type_func();
            //BuiltInTypes.data_type_integer();
            //BuiltInTypes.data_type_typecast();

            // String Example
            //Strings.concatenateStrings();
            //Strings.AccessString();
            //Strings.SpecialCharacters();

            // UserInput Example
            //UserInput.InputUserName();

            // Operators Example
            //Operators.additionExample();
            //Operators.GreaterThan();

            // Statement Example
            //int inputTemperature = 10; // Change this value to test different temperatures
            //SelectionStatements.TemperatureAdvice(inputTemperature);
            //IterationStatements.LoopExample();

            // Collection Example
            //CollectionsAndArrays.ArrayExample();


            // Methods Example
            Console.WriteLine(Methods.Multiply(3, 5));


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
            //Out_Example.OutMain();

        }
    }
}

