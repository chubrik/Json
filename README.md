## [DEPRECATED]
_Use the `System.Text.Json` package version 8.0+ instead. It fully matches the functionality of the current package._
<br><br><br>

# [![Chubrik.Json project](https://raw.githubusercontent.com/chubrik/Json/main/img/icon.png)](#) Chubrik.Json
[![NuGet package](https://img.shields.io/nuget/v/Chubrik.Json)](https://www.nuget.org/packages/Chubrik.Json/)
[![MIT license](https://img.shields.io/github/license/chubrik/Json)](https://github.com/chubrik/Json/blob/main/LICENSE)
[![NuGet downloads](https://img.shields.io/nuget/dt/Chubrik.Json)](https://www.nuget.org/packages/Chubrik.Json/)

Provides `snake_case` &amp; `kebab-case` property name serialization.
Tiny and high-performance .NET library based on System.Text.Json.

Here is the benchmark summary:

![Benchmark summary](https://raw.githubusercontent.com/chubrik/Json/main/img/benchmark.png)
<br><br>

## Install
```
PM> Install-Package Chubrik.Json
```

## Usage
```csharp
using Chubrik.Json;
using System.Text.Json;

var myObj = new { FirstName = "John", LastName = "Smith" };
var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicies.SnakeLowerCase };
var json = JsonSerializer.Serialize(value: myObj, options: options);

Console.WriteLine(json); // {"first_name":"John","last_name":"Smith"}
```
<br>

## Examples
The following table shows the serialization rules for different JSON naming policies:
| Original name   | SnakeLowerCase   | SnakeUpperCase   | KebabLowerCase   | KebabUpperCase   |
| --------------- | ---------------- | ---------------- | ---------------- | ---------------- |
| PascalProp      | pascal_prop      | PASCAL_PROP      | pascal-prop      | PASCAL-PROP      |
| camelProp       | camel_prop       | CAMEL_PROP       | camel-prop       | CAMEL-PROP       |
| Snake_Prop      | snake_prop       | SNAKE_PROP       | snake-prop       | SNAKE-PROP       |
| SEMIUpper       | semi_upper       | SEMI_UPPER       | semi-upper       | SEMI-UPPER       |
| \_Underlined_   | \_underlined_    | \_UNDERLINED_    | -underlined-     | -UNDERLINED-     |
| Version1        | version1         | VERSION1         | version1         | VERSION1         |
| Version2Alpha   | version2_alpha   | VERSION2_ALPHA   | version2-alpha   | VERSION2-ALPHA   |
| Version3beta    | version3beta     | VERSION3BETA     | version3beta     | VERSION3BETA     |
| Version4_Gamma  | version4_gamma   | VERSION4_GAMMA   | version4-gamma   | VERSION4-GAMMA   |
| Hex1_0xa1b23c   | hex1_0xa1b23c    | HEX1_0XA1B23C    | hex1-0xa1b23c    | HEX1-0XA1B23C    |
| ΞένοΌνομα       | ξένο_όνομα       | ΞΈΝΟ_ΌΝΟΜΑ       | ξένο-όνομα       | ΞΈΝΟ-ΌΝΟΜΑ       |
<br>

## <a name="license"></a>License
The Chubrik.Json is licensed under the [MIT license](https://github.com/chubrik/Json/blob/main/LICENSE).
<br><br>
