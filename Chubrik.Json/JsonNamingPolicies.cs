namespace Chubrik.Json;

using System.Text.Json;

public static class JsonNamingPolicies
{
    public static JsonNamingPolicy CamelCase { get; } = JsonNamingPolicy.CamelCase;
    public static JsonNamingPolicy SnakeLowerCase { get; } = new JsonSnakeLowerCaseNamingPolicy();
    public static JsonNamingPolicy SnakeUpperCase { get; } = new JsonSnakeUpperCaseNamingPolicy();
}
