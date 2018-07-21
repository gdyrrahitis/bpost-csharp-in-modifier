namespace CSharp._7_3.Features
{
    public struct MutableStruct
    {
        public decimal DecimalProperty1 { get; set; }
        public decimal DecimalProperty2 { get; set; }
        public double DoubleForChange { get; set; }
    }

    public class InModifierTester
    {
        public static void ByValue(MutableStruct value)
        {
            // A copy of the MutableStruct value has been created

            // this is allowed. I am modifying the copy
            value.DecimalProperty1 = 10;
        }

        public static void ByRef(ref MutableStruct reference)
        {
            // Value is passed by reference.

            // This change will reflect in the calling code
            reference.DecimalProperty1 = 100;
        }

        public static void WithIn(in MutableStruct readOnly)
        {
            // Value is passed by reference but it is readonly

            // This is not allowed, compiler will error it
            // readOnly.DecimalProperty1 = 1000;
            System.Console.WriteLine(readOnly.DecimalProperty1);
        }
    }
}
