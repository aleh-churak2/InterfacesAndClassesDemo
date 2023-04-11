namespace InterfacesAndClassesDemo
{
    internal static class SampleStaticClass
    {
        static SampleStaticClass()
        {
            SampleString = "321test";
        }

        public const string SampleConst = "It's a constant value";

        public static string SampleString = "test123";

        public static string ExtendString(this string initialValue, string value)
        {
            return initialValue + value;
        }
    }
}
