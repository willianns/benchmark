////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: Pogram.cs
//FileType: Visual C# Source file
//Copy Rights : see license in README
//Description : Entrypoint for running BenchmarkDotNet
////////////////////////////////////////////////////////////////////////////////////////////////////////

using BenchmarkDotNet.Running;

namespace benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringBenchmark = BenchmarkRunner.Run<StringManipulationBenchmark>();
        }
    }
}
