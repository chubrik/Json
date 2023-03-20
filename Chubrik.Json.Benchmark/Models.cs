namespace Chubrik.Json.Benchmark;

public sealed class ModelNoAttrs
{
    public string? Name { get; set; }

    public double? DefaultValue { get; set; }

    public int? MaxValueCount { get; set; }

    public bool Equals(ModelNoAttrs? other)
    {
        if (other == null) return false;
        if (other.Name != Name) return false;
        if (other.DefaultValue != DefaultValue) return false;
        if (other.MaxValueCount != MaxValueCount) return false;
        return true;
    }
}

public sealed class ModelSystemAttrs
{
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("default_value")]
    public double? DefaultValue { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("max_value_count")]
    public int? MaxValueCount { get; set; }

    public bool Equals(ModelSystemAttrs? other)
    {
        if (other == null) return false;
        if (other.Name != Name) return false;
        if (other.DefaultValue != DefaultValue) return false;
        if (other.MaxValueCount != MaxValueCount) return false;
        return true;
    }
}

[Newtonsoft.Json.JsonObject]
public sealed class ModelNewtonsoftAttrs
{
    [Newtonsoft.Json.JsonProperty("name")]
    public string? Name { get; set; }

    [Newtonsoft.Json.JsonProperty("default_value")]
    public double? DefaultValue { get; set; }

    [Newtonsoft.Json.JsonProperty("max_value_count")]
    public int? MaxValueCount { get; set; }

    public bool Equals(ModelNewtonsoftAttrs? other)
    {
        if (other == null) return false;
        if (other.Name != Name) return false;
        if (other.DefaultValue != DefaultValue) return false;
        if (other.MaxValueCount != MaxValueCount) return false;
        return true;
    }
}
