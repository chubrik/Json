namespace Chubrik.Json;

using System;
using System.Text.Json;

internal sealed class JsonSnakeLowerCaseNamingPolicy : JsonNamingPolicy
{
    public override unsafe string ConvertName(string? name)
    {
        if (string.IsNullOrEmpty(name))
            throw new InvalidOperationException();

#if NET
        Span<char> output = stackalloc char[name.Length * 3 / 2];
#else
        var output = stackalloc char[name!.Length * 3 / 2];
#endif
        var outputIndex = 0;
        var lastInputIndex = name!.Length - 1;
        var typeMap = Constants.CharTypeMap;
        var prevType = CharType.ULine;
        char @char;
        int charInt;
        CharType type;

        for (var inputIndex = 0; inputIndex <= lastInputIndex; inputIndex++)
        {
            charInt = @char = name[inputIndex];

            if (charInt < 128)
            {
                type = typeMap[charInt];

                if (type == CharType.Upper)
                {
                    if (prevType == CharType.Upper)
                    {
                        if (inputIndex < lastInputIndex)
                        {
                            var nextChar = name[inputIndex + 1];

                            if (nextChar < 128)
                            {
                                if (typeMap[nextChar] == CharType.Lower)
                                    output[outputIndex++] = '_';
                            }
                            else if (char.IsLower(nextChar))
                                output[outputIndex++] = '_';
                        }
                    }
                    else if (prevType != CharType.ULine)
                        output[outputIndex++] = '_';

                    output[outputIndex++] = unchecked((char)(charInt + 32));
                }
                else
                    output[outputIndex++] = @char;

                prevType = type;
            }
            else if (char.IsLower(@char))
            {
                output[outputIndex++] = @char;
                prevType = CharType.Lower;
            }
            else if (char.IsUpper(@char))
            {
                if (prevType == CharType.Upper)
                {
                    if (inputIndex < lastInputIndex && char.IsLower(name[inputIndex + 1]))
                        output[outputIndex++] = '_';
                }
                else if (prevType != CharType.ULine)
                    output[outputIndex++] = '_';

                output[outputIndex++] = char.ToLowerInvariant(@char);
                prevType = CharType.Upper;
            }
            else
            {
                output[outputIndex++] = @char;
                prevType = CharType.Other;
            }
        }

#if NET
        return new string(output[..outputIndex]);
#else
        return new string(output, 0, outputIndex);
#endif
    }
}
