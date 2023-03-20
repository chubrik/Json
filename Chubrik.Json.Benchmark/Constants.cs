namespace Chubrik.Json.Benchmark;

public static class Constants
{
    public static readonly ModelNoAttrs ModelNoAttrs = new()
    {
        Name = "Model Name",
        DefaultValue = 123.45,
        MaxValueCount = 15
    };

    public static readonly ModelSystemAttrs ModelSystemAttrs = new()
    {
        Name = "Model Name",
        DefaultValue = 123.45,
        MaxValueCount = 15
    };

    public static readonly ModelNewtonsoftAttrs ModelNewtonsoftAttrs = new()
    {
        Name = "Model Name",
        DefaultValue = 123.45,
        MaxValueCount = 15
    };

    public const string ModelJson = @"{""name"":""Model Name"",""default_value"":123.45,""max_value_count"":15}";

    public static readonly System.Text.Json.JsonSerializerOptions JsonSystemOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.SnakeLowerCase
    };

    public static readonly Newtonsoft.Json.JsonSerializerSettings JsonNewtonsoftOptions = new()
    {
        ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver
        {
            NamingStrategy = new Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy()
        }
    };
}
