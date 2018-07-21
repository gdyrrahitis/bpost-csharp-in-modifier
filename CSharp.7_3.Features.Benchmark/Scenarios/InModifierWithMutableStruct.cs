namespace CSharp._7_3.Features.Benchmark.Scenarios
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using BenchmarkDotNet.Attributes.Exporters;
    using BenchmarkDotNet.Attributes.Jobs;

    [CoreJob]
    [RPlotExporter, RankColumn]
    public class InModifierWithMutableStruct
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
        public decimal TestWithInModifier() {
            var mutableStruct = new MutableStruct(10);
            return ReceivingValueByRefWithIn(mutableStruct);

            decimal ReceivingValueByRefWithIn(in MutableStruct value)
            {
                decimal total = 0;
                for (var i = 0; i < HundrendThousand; i++)
                    total += value.DecimalProperty1;

                return total;
            }
        }
    }
}
