# [![Chubrik.Json project](https://raw.githubusercontent.com/chubrik/Json/main/icon.png)](#) Chubrik.Json
[![NuGet package](https://img.shields.io/nuget/v/Chubrik.Json)](https://www.nuget.org/packages/Chubrik.Json/)
[![MIT license](https://img.shields.io/github/license/chubrik/Json)](https://github.com/chubrik/Json/blob/main/LICENSE)
[![NuGet downloads](https://img.shields.io/nuget/dt/Chubrik.Json)](https://www.nuget.org/packages/Chubrik.Json/)

Tiny .NET library based on `System.Text.Json` and provides *snake_case* &amp; *kebab-case*
property name serialization policies. Designed for maximum performance.
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
| Prop            | prop             | PROP             | prop             | PROP             |
| UPPER           | upper            | UPPER            | upper            | UPPER            |
| lower           | lower            | LOWER            | lower            | LOWER            |
| PascalProp      | pascal_prop      | PASCAL_PROP      | pascal-prop      | PASCAL-PROP      |
| camelProp       | camel_prop       | CAMEL_PROP       | camel-prop       | CAMEL-PROP       |
| Snake_Prop      | snake_prop       | SNAKE_PROP       | snake-prop       | SNAKE-PROP       |
| SNAKE_UPPER     | snake_upper      | SNAKE_UPPER      | snake-upper      | SNAKE-UPPER      |
| snake_lower     | snake_lower      | SNAKE_LOWER      | snake-lower      | SNAKE-LOWER      |
| Snake__Long     | snake__long      | SNAKE__LONG      | snake--long      | SNAKE--LONG      |
| SEMIUpper       | semi_upper       | SEMI_UPPER       | semi-upper       | SEMI-UPPER       |
| \_Underlined_   | \_underlined_    | \_UNDERLINED_    | -underlined-     | -UNDERLINED-     |
| \_\_MoreLines__ | \_\_more_lines__ | \_\_MORE_LINES__ | --more-lines--   | --MORE-LINES--   |
| Version1        | version1         | VERSION1         | version1         | VERSION1         |
| Version1_0      | version1_0       | VERSION1_0       | version1-0       | VERSION1-0       |
| Version1__1     | version1__1      | VERSION1__1      | version1--1      | VERSION1--1      |
| Version_1_2     | version_1_2      | VERSION_1_2      | version-1-2      | VERSION-1-2      |
| Version__1_3    | version__1_3     | VERSION__1_3     | version--1-3     | VERSION--1-3     |
| Version2Alpha   | version2_alpha   | VERSION2_ALPHA   | version2-alpha   | VERSION2-ALPHA   |
| Version3beta    | version3beta     | VERSION3BETA     | version3beta     | VERSION3BETA     |
| Version4_Gamma  | version4_gamma   | VERSION4_GAMMA   | version4-gamma   | VERSION4-GAMMA   |
| Version5_delta  | version5_delta   | VERSION5_DELTA   | version5-delta   | VERSION5-DELTA   |
| Version6__Zeta  | version6__zeta   | VERSION6__ZETA   | version6--zeta   | VERSION6--ZETA   |
| Version7__eta   | version7__eta    | VERSION7__ETA    | version7--eta    | VERSION7--ETA    |
| Hex1_0xa1b23c   | hex1_0xa1b23c    | HEX1_0XA1B23C    | hex1-0xa1b23c    | HEX1-0XA1B23C    |
| Hex2_0xA1B23C   | hex2_0x_a1_b23_c | HEX2_0X_A1_B23_C | hex2-0x-a1-b23-c | HEX2-0X-A1-B23-C |
| ΞένοΌνομα       | ξένο_όνομα       | ΞΈΝΟ_ΌΝΟΜΑ       | ξένο-όνομα       | ΞΈΝΟ-ΌΝΟΜΑ       |
<br>

## <a name="license"></a>License
The Chubrik.Json is licensed under the [MIT license](https://github.com/chubrik/Json/blob/main/LICENSE).
<br><br>
