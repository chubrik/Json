namespace Chubrik.Json;

using System;
using System.Text.Json;
using static Chubrik.Json.CharType;

internal sealed class JsonSnakeUpperCaseNamingPolicy : JsonNamingPolicy
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
        var inputLastIndex = name!.Length - 1;
        var typeMap = Constants.CharTypeMap;
        var prevType = ULine;
        char ch;
        CharType type;

        for (var inputIndex = 0; inputIndex <= inputLastIndex; inputIndex++)
        {
            ch = name[inputIndex];

            if (ch <= '\x7f')
            {
                type = typeMap[ch];

                switch (type)
                {
                    case Lower:
                        output[outputIndex++] = (char)(ch - 32);
                        break;

                    case Upper:

                        if (prevType == Upper)
                        {
                            if (inputIndex < inputLastIndex)
                            {
                                var nextCh = name[inputIndex + 1];

                                if (nextCh <= '\x7f')
                                {
                                    if (typeMap[nextCh] == Lower)
                                        output[outputIndex++] = '_';
                                }
                                else if (char.IsLower(nextCh))
                                    output[outputIndex++] = '_';
                            }
                        }
                        else if (prevType != ULine)
                            output[outputIndex++] = '_';

                        output[outputIndex++] = ch;
                        break;

                    case ULine:
                        output[outputIndex++] = '_';
                        break;

                    default:
                        output[outputIndex++] = ch;
                        break;
                }

                prevType = type;
            }
            else if (char.IsLower(ch))
            {
                output[outputIndex++] = char.ToUpperInvariant(ch);
                prevType = Lower;
            }
            else if (char.IsUpper(ch))
            {
                if (prevType == Upper)
                {
                    if (inputIndex < inputLastIndex && char.IsLower(name[inputIndex + 1]))
                        output[outputIndex++] = '_';
                }
                else if (prevType != ULine)
                    output[outputIndex++] = '_';

                output[outputIndex++] = ch;
                prevType = Upper;
            }
            else
            {
                output[outputIndex++] = ch;
                prevType = Other;
            }
        }

#if NET
        return new string(output[..outputIndex]);
#else
        return new string(output, 0, outputIndex);
#endif
    }
}
