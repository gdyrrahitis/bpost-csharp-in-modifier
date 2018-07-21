namespace CSharp._7_3.Features.Benchmark.Scenarios
{
    using BenchmarkDotNet.Running;
    using Xunit;

    public class BenchmarkTester
    {
        [Fact]
        public void ShouldRunBenchmarksOnMutableStruct() => BenchmarkRunner.Run<InModifierWithMutableStruct>();

        [Fact]
        public void ShouldRunBenchmarksOnImmutableStruct() => BenchmarkRunner.Run<InModifierWithImmutableStruct>();
    }
}
