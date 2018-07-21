namespace CSharp._7_3.Features.Benchmark.Scenarios
{
    public struct MutableStruct
    {
        public MutableStruct(decimal prop1) : this() => DecimalProperty1 = prop1;

        public decimal DecimalProperty1 { get; }
        private long a, b, c, d, e, f;
        private double h, i, j, k;
        private decimal l, m, n, o;
    }
}
