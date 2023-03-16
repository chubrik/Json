namespace Chubrik.Json;

using System.Text.Json;

/// <summary>
/// Determines the naming policies used to convert a string-based name to another format,
/// such as camelCasing, snake_casing and kebab-casing formats.
/// </summary>
public static class JsonNamingPolicies
{
    /// <summary>
    /// Gets the naming policy for camelCasing.
    /// </summary>
    /// <returns>The naming policy for camelCasing.</returns>
    public static JsonNamingPolicy CamelCase { get; } = JsonNamingPolicy.CamelCase;

    /// <summary>
    /// Gets the naming policy for kebab-lower-casing.
    /// </summary>
    /// <returns>The naming policy for kebab-lower-casing.</returns>
    public static JsonNamingPolicy KebabLowerCase { get; } = new JsonKebabLowerCaseNamingPolicy();

    /// <summary>
    /// Gets the naming policy for KEBAB-UPPER-CASING.
    /// </summary>
    /// <returns>The naming policy for KEBAB-UPPER-CASING.</returns>
    public static JsonNamingPolicy KebabUpperCase { get; } = new JsonKebabUpperCaseNamingPolicy();

    /// <summary>
    /// Gets the naming policy for snake_lower_casing.
    /// </summary>
    /// <returns>The naming policy for snake_lower_casing.</returns>
    public static JsonNamingPolicy SnakeLowerCase { get; } = new JsonSnakeLowerCaseNamingPolicy();

    /// <summary>
    /// Gets the naming policy for SNAKE_UPPER_CASING.
    /// </summary>
    /// <returns>The naming policy for SNAKE_UPPER_CASING.</returns>
    public static JsonNamingPolicy SnakeUpperCase { get; } = new JsonSnakeUpperCaseNamingPolicy();
}
