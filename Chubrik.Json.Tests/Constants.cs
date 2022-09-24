using System.Text.Json;
using static System.Environment;

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

    public static readonly Serializable TestObject =
        new()
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

    public static readonly string KebabLowerJson =
        "{" +
        NewLine + "  \"prop\": 1," +
        NewLine + "  \"upper\": 2," +
        NewLine + "  \"lower\": 3," +
        NewLine + "  \"pascal-prop\": 4," +
        NewLine + "  \"camel-prop\": 5," +
        NewLine + "  \"snake-prop\": 6," +
        NewLine + "  \"snake-upper\": 7," +
        NewLine + "  \"snake-lower\": 8," +
        NewLine + "  \"snake--long\": 9," +
        NewLine + "  \"semi-upper\": 10," +
        NewLine + "  \"-underlined-\": 11," +
        NewLine + "  \"--more-underlined--\": 12," +
        NewLine + "  \"version1\": 13," +
        NewLine + "  \"version1-0\": 14," +
        NewLine + "  \"version1--1\": 15," +
        NewLine + "  \"version-1-2\": 16," +
        NewLine + "  \"version--1-3\": 17," +
        NewLine + "  \"version2-alpha\": 18," +
        NewLine + "  \"version3beta\": 19," +
        NewLine + "  \"version4-gamma\": 20," +
        NewLine + "  \"version5-delta\": 21," +
        NewLine + "  \"version6--epsilon\": 22," +
        NewLine + "  \"version7--zeta\": 23," +
        NewLine + "  \"hex1-0xa1b23cd4\": 24," +
        NewLine + "  \"hex2-0x-a1-b23-cd4\": 25" +
        NewLine + "}";

    public static readonly string KebabUpperJson = KebabLowerJson.ToUpper();

    public static readonly string SnakeLowerJson = KebabLowerJson.Replace('-', '_');

    public static readonly string SnakeUpperJson = SnakeLowerJson.ToUpper();
}
