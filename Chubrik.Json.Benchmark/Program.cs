namespace Chubrik.Json.Benchmark;

using BenchmarkDotNet.Running;

public static class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Benchmarks>();
    }
}
