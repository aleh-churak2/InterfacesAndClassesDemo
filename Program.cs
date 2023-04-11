using InterfacesAndClassesDemo;

internal class Program
{
    static void Main(string[] args)
    {

        var c1 = new SampleClass("1");

        var c2 = new SampleClass("1");

        var a = "123";

        var b = "123";

        Console.WriteLine(Object.ReferenceEquals(c1, c2));

        c1.DoWork(new SampleClass2());

        Console.WriteLine(a.ExtendString(b));


        //c.MyProperty = c1;
        //Console.WriteLine(c.MyProperty.TestProperty);

        //c.MyProperty = c2;
        //Console.WriteLine(c.MyProperty.TestProperty);

        //Object.ReferenceEquals(a, b);

        ////Console.WriteLine(SampleStaticClass.SampleConst);
        ////Console.WriteLine(SampleStaticClass.SampleString);


        var exampleWithStruct = new ExampleWithStruct();

        exampleWithStruct.Run();
        Console.ReadKey();
    }
}