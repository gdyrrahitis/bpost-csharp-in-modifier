namespace CSharp._7_3.Features
{
    public readonly struct ImmutableStruct
    {
        public ImmutableStruct(double prop1, double prop2)
        {
            DoubleProperty1 = prop1;
            DoubleProperty2 = prop2;
        }

        public double DoubleProperty1 { get; }
        public double DoubleProperty2 { get; }
    }
}
