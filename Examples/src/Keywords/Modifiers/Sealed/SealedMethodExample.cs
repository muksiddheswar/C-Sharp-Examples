namespace C_Sharp_Examples.src.Keywords.Modifiers.Sealed
{
    class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        public virtual void F2() { Console.WriteLine("X.F2"); }
    }

    class Y : X
    {
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        public override void F2() { Console.WriteLine("Y.F2"); }
    }

    class Z : Y
    {
        // Attempting to override F causes compiler error CS0239.
        // protected override void F() { Console.WriteLine("Z.F"); }

        // Overriding F2 is allowed.
        public override void F2() { Console.WriteLine("Z.F2"); F(); } // Sealed method can be executed.
    }
}