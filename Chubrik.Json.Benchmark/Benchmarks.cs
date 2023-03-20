#pragma warning disable CA1822 // Mark members as static

namespace Chubrik.Json.Benchmark;

using BenchmarkDotNet.Attributes;
using System;

[MemoryDiagnoser]
public class Benchmarks
{
    [GlobalSetup]
    public void Setup()
    {
        if (Constants.ModelJson != SerializeSystemOptions()) throw new InvalidOperationException();
        if (Constants.ModelJson != SerializeSystemAttrs()) throw new InvalidOperationException();
        if (Constants.ModelJson != SerializeNewtonsoftOptions()) throw new InvalidOperationException();
        if (Constants.ModelJson != SerializeNewtonsoftAttrs()) throw new InvalidOperationException();
        if (!Constants.ModelNoAttrs.Equals(DeserializeSystemOptions())) throw new InvalidOperationException();
        if (!Constants.ModelSystemAttrs.Equals(DeserializeSystemAttrs())) throw new InvalidOperationException();
        if (!Constants.ModelNoAttrs.Equals(DeserializeNewtonsoftOptions())) throw new InvalidOperationException();
        if (!Constants.ModelNewtonsoftAttrs.Equals(DeserializeNewtonsoftAttrs())) throw new InvalidOperationException();
    }

    [Benchmark(Description = "Serialize with options (Chubrik.Json)        ")]
    public string SerializeSystemOptions()
    {
        return System.Text.Json.JsonSerializer
            .Serialize(Constants.ModelNoAttrs, Constants.JsonSystemOptions);
    }

    [Benchmark(Description = "Serialize with property attributes           ")]
    public string SerializeSystemAttrs()
    {
        return System.Text.Json.JsonSerializer
            .Serialize(Constants.ModelSystemAttrs);
    }

    [Benchmark(Description = "Serialize with options (Newtonsoft.Json)     ")]
    public string SerializeNewtonsoftOptions()
    {
        return Newtonsoft.Json.JsonConvert
            .SerializeObject(Constants.ModelNoAttrs, Constants.JsonNewtonsoftOptions);
    }

    [Benchmark(Description = "Serialize with attributes (Newtonsoft.Json)  ")]
    public string SerializeNewtonsoftAttrs()
    {
        return Newtonsoft.Json.JsonConvert
            .SerializeObject(Constants.ModelNewtonsoftAttrs);
    }

    [Benchmark(Description = "Deserialize with options (Chubrik.Json)      ")]
    public ModelNoAttrs? DeserializeSystemOptions()
    {
        return System.Text.Json.JsonSerializer
            .Deserialize<ModelNoAttrs>(Constants.ModelJson, Constants.JsonSystemOptions);
    }

    [Benchmark(Description = "Deserialize with property attributes         ")]
    public ModelSystemAttrs? DeserializeSystemAttrs()
    {
        return System.Text.Json.JsonSerializer
            .Deserialize<ModelSystemAttrs>(Constants.ModelJson);
    }

    [Benchmark(Description = "Deserialize with options (Newtonsoft.Json)   ")]
    public ModelNoAttrs? DeserializeNewtonsoftOptions()
    {
        return Newtonsoft.Json.JsonConvert
            .DeserializeObject<ModelNoAttrs>(Constants.ModelJson, Constants.JsonNewtonsoftOptions);
    }

    [Benchmark(Description = "Deserialize with attributes (Newtonsoft.Json)")]
    public ModelNewtonsoftAttrs? DeserializeNewtonsoftAttrs()
    {
        return Newtonsoft.Json.JsonConvert
            .DeserializeObject<ModelNewtonsoftAttrs>(Constants.ModelJson);
    }
}
