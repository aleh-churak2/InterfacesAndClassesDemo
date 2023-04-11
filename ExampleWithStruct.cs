namespace InterfacesAndClassesDemo
{
    internal class ExampleWithStruct
    {
        public void Run()
        {
            var s = new S();
            Console.WriteLine($"Initial value A is {s.M.A}");
            s.M.IncA();
            Console.WriteLine($"Result value A is {s.M.A}");

            Console.WriteLine($"Initial value B is {s.M.B}");
            s.M.IncB();
            Console.WriteLine($"Result value B is {s.M.B}");


            var ghCode1 = new M(11, 11).GetHashCode();
            Console.WriteLine($"GetHashCode version 1 {ghCode1}");

            var ghCode2 = new M(11, 11).GetHashCode();
            Console.WriteLine($"GetHashCode version 2 {ghCode2}");
        }

        class S
        {
            public S()
            {
                M = new M(10, 10);
            }
            public M M { get; private set; }
        }

        struct M 
        {
            public int A { get; private set; }
            public int B { get; set; }

            public M(int a, int b)
            {
                A = a;
                B = b;
            }

            public void IncA()
            {
                A++;
            }

            public void IncB()
            {
                B++;
            }
        }
    }


}
