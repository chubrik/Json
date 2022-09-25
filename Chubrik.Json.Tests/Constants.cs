using System.Text.Json;

namespace Chubrik.Json.Tests;

public static class Constants
{
    public static readonly JsonSerializerOptions KebabLowerCaseJsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.KebabLowerCase,
        WriteIndented = true
    };

    public static readonly JsonSerializerOptions KebabUpperCaseJsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.KebabUpperCase,
        WriteIndented = true
    };

    public static readonly JsonSerializerOptions SnakeLowerCaseJsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.SnakeLowerCase,
        WriteIndented = true
    };

    public static readonly JsonSerializerOptions SnakeUpperCaseJsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.SnakeUpperCase,
        WriteIndented = true
    };

    public static readonly Serializable TestObject = new()
    {
        Prop = 1,
        UPPER = 2,
        lower = 3,
        PascalProp = 4,
        camelProp = 5,
        Snake_Prop = 6,
        SNAKE_UPPER = 7,
        snake_lower = 8,
        Snake__Long = 9,
        SEMIUpper = 10,
        _Underlined_ = 11,
        __MoreLines__ = 12,
        Version1 = 13,
        Version1_0 = 14,
        Version1__1 = 15,
        Version_1_2 = 16,
        Version__1_3 = 17,
        Version2Alpha = 18,
        Version3beta = 19,
        Version4_Gamma = 20,
        Version5_delta = 21,
        Version6__Zeta = 22,
        Version7__eta = 23,
        Hex1_0xa1b23c = 24,
        Hex2_0xA1B23C = 25
    };

    public static readonly string SnakeLowerJson =
@"{
  ""prop"": 1,
  ""upper"": 2,
  ""lower"": 3,
  ""pascal_prop"": 4,
  ""camel_prop"": 5,
  ""snake_prop"": 6,
  ""snake_upper"": 7,
  ""snake_lower"": 8,
  ""snake__long"": 9,
  ""semi_upper"": 10,
  ""_underlined_"": 11,
  ""__more_lines__"": 12,
  ""version1"": 13,
  ""version1_0"": 14,
  ""version1__1"": 15,
  ""version_1_2"": 16,
  ""version__1_3"": 17,
  ""version2_alpha"": 18,
  ""version3beta"": 19,
  ""version4_gamma"": 20,
  ""version5_delta"": 21,
  ""version6__zeta"": 22,
  ""version7__eta"": 23,
  ""hex1_0xa1b23c"": 24,
  ""hex2_0x_a1_b23_c"": 25
}";

    public static readonly string SnakeUpperJson = SnakeLowerJson.ToUpper();

    public static readonly string KebabLowerJson = SnakeLowerJson.Replace('_', '-');

    public static readonly string KebabUpperJson = KebabLowerJson.ToUpper();
}
