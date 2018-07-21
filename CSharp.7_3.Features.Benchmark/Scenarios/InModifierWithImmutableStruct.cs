namespace CSharp._7_3.Features.Benchmark.Scenarios
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using BenchmarkDotNet.Attributes.Exporters;
    using BenchmarkDotNet.Attributes.Jobs;

    [CoreJob]
    [RPlotExporter, RankColumn]
    public class InModifierWithImmutableStruct
    {
        private const int Thousand = 1_000;
        private const int TenThousand = 10_000;
        private const int HundrendThousand = 100_000;

        [Params(Thousand, TenThousand, HundrendThousand)]
        public int N;

        [Benchmark]
        public decimal TestWithoutInModifier()
        {
            var mutableStruct = new MutableStruct(10);
            return ReceivingValueByValue(mutableStruct);

            decimal ReceivingValueByValue(MutableStruct value)
            {
                decimal total = 0;
                for (var i = 0; i < HundrendThousand; i++)
                    total += value.DecimalProperty1;

                return total;
            }
        }

        [Benchmark]
        public decimal TestWithInModifier()
        {
            var immutableStruct = new ImmutableStruct(10);
            return ReceivingValueByRefWithIn(immutableStruct);

            decimal ReceivingValueByRefWithIn(in ImmutableStruct value)
            {
                var x = new ImmutableStruct(10);
                
                decimal total = 0;
                for (var i = 0; i < HundrendThousand; i++)
                    total += value.DecimalProperty1;

                return total;
            }
        }
    }
}
