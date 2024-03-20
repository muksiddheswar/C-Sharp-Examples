using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.AccessModifiers.Protected
{
    class A
    {
        protected int x = 123;
    }

    class B : A
    {
        public static void ProtectedClassExample()
        {
            var a = new A();
            var b = new B();

            // Error CS1540, because x can only be accessed by
            // classes derived from A.
            // a.x = 10;

            // OK, because this class derives from A.
            b.x = 10;
            Console.WriteLine(" -- Done -- ");
        }
    }
}
