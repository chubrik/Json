namespace Chubrik.Json.Tests;

using System.Text.Json;

public class Program
{
    private static void Main()
    {
        var testObj = new TestObject
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
            __MoreUnderlined__ = 12,
            Version1 = 13,
            Version1_0 = 14,
            Version1__1 = 15,
            Version_1_2 = 16,
            Version__1_3 = 17,
            Version2Alpha = 18,
            Version3beta = 19,
            Version4_Gamma = 20,
            Version5_delta = 21,
            Version6__Epsilon = 22,
            Version7__zeta = 23,
            Hex1_0xa1b23cd4 = 24,
            Hex2_0xA1B23CD4 = 25
        };

        var snakeLowerJson = JsonSerializer.Serialize(testObj, _jsonOptionsLower);
        var snakeUpperJson = JsonSerializer.Serialize(testObj, _jsonOptionsUpper);

        var expectedJson = "{" +
            NL + "  \"prop\": 1," +
            NL + "  \"upper\": 2," +
            NL + "  \"lower\": 3," +
            NL + "  \"pascal_prop\": 4," +
            NL + "  \"camel_prop\": 5," +
            NL + "  \"snake_prop\": 6," +
            NL + "  \"snake_upper\": 7," +
            NL + "  \"snake_lower\": 8," +
            NL + "  \"snake__long\": 9," +
            NL + "  \"semi_upper\": 10," +
            NL + "  \"_underlined_\": 11," +
            NL + "  \"__more_underlined__\": 12," +
            NL + "  \"version1\": 13," +
            NL + "  \"version1_0\": 14," +
            NL + "  \"version1__1\": 15," +
            NL + "  \"version_1_2\": 16," +
            NL + "  \"version__1_3\": 17," +
            NL + "  \"version2_alpha\": 18," +
            NL + "  \"version3beta\": 19," +
            NL + "  \"version4_gamma\": 20," +
            NL + "  \"version5_delta\": 21," +
            NL + "  \"version6__epsilon\": 22," +
            NL + "  \"version7__zeta\": 23," +
            NL + "  \"hex1_0xa1b23cd4\": 24," +
            NL + "  \"hex2_0x_a1_b23_cd4\": 25" +
            NL + "}";

        if (snakeLowerJson != expectedJson)
            throw new InvalidOperationException();

        if (snakeUpperJson != expectedJson.ToUpper())
            throw new InvalidOperationException();

        var deserializedLowerObj = JsonSerializer.Deserialize<TestObject>(snakeLowerJson, _jsonOptionsLower);

        if (deserializedLowerObj == null)
            throw new InvalidOperationException();

        if (!IsEquals(deserializedLowerObj, testObj))
            throw new InvalidOperationException();

        var deserializedUpperObj = JsonSerializer.Deserialize<TestObject>(snakeUpperJson, _jsonOptionsUpper);

        if (deserializedUpperObj == null)
            throw new InvalidOperationException();

        if (!IsEquals(deserializedUpperObj, testObj))
            throw new InvalidOperationException();

        Console.WriteLine("G`Test passed!");
    }

    private static bool IsEquals(TestObject a, TestObject b)
    {
        if (a.Prop != b.Prop) return false;
        if (a.UPPER != b.UPPER) return false;
        if (a.lower != b.lower) return false;
        if (a.PascalProp != b.PascalProp) return false;
        if (a.camelProp != b.camelProp) return false;
        if (a.Snake_Prop != b.Snake_Prop) return false;
        if (a.SNAKE_UPPER != b.SNAKE_UPPER) return false;
        if (a.snake_lower != b.snake_lower) return false;
        if (a.Snake__Long != b.Snake__Long) return false;
        if (a.SEMIUpper != b.SEMIUpper) return false;
        if (a._Underlined_ != b._Underlined_) return false;
        if (a.__MoreUnderlined__ != b.__MoreUnderlined__) return false;
        if (a.Version1 != b.Version1) return false;
        if (a.Version1_0 != b.Version1_0) return false;
        if (a.Version1__1 != b.Version1__1) return false;
        if (a.Version_1_2 != b.Version_1_2) return false;
        if (a.Version__1_3 != b.Version__1_3) return false;
        if (a.Version2Alpha != b.Version2Alpha) return false;
        if (a.Version3beta != b.Version3beta) return false;
        if (a.Version4_Gamma != b.Version4_Gamma) return false;
        if (a.Version5_delta != b.Version5_delta) return false;
        if (a.Version6__Epsilon != b.Version6__Epsilon) return false;
        if (a.Version7__zeta != b.Version7__zeta) return false;
        if (a.Hex1_0xa1b23cd4 != b.Hex1_0xa1b23cd4) return false;
        if (a.Hex2_0xA1B23CD4 != b.Hex2_0xA1B23CD4) return false;
        return true;
    }

    private static readonly string NL = Environment.NewLine;

    private static readonly JsonSerializerOptions _jsonOptionsLower = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.SnakeLowerCase,
        WriteIndented = true
    };

    private static readonly JsonSerializerOptions _jsonOptionsUpper = new()
    {
        PropertyNamingPolicy = JsonNamingPolicies.SnakeUpperCase,
        WriteIndented = true
    };
}
