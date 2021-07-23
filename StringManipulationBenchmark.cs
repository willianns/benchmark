
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace benchmark
{    
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    public class StringManipulationBenchmark
    {
        private string[] fruits = new []{ "watermelon", "apple" }; 

        [Benchmark]
        public string StringFormat() => string.Format("I have some {0} and {1}", fruits[0], fruits[1]);

        [Benchmark]
        public string StringConcat() => string.Concat("I have some ", fruits[0] ," and ", fruits[1]);

        [Benchmark]
        public string PoorManConcatenation() => "I have some " + fruits[0] + " and " + fruits[1];

        [Benchmark]
        public string StringInterpolation() => $"I have some {fruits[0]}  and {fruits[1]}";          
    }
}