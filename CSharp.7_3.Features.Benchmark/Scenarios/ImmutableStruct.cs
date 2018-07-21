namespace CSharp._7_3.Features.Benchmark.Scenarios
{
    public readonly struct ImmutableStruct
    {
        public ImmutableStruct(decimal prop1) : this() => DecimalProperty1 = prop1;

        public decimal DecimalProperty1 { get; }
        private readonly long a, b, c, d, e, f;
        private readonly double h, i, j, k;
        private readonly decimal l, m, n, o;
    }
}
