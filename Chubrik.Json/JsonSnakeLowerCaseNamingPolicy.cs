namespace Chubrik.Json;

using System;
using System.Text;
using System.Text.Json;
using static Chubrik.Json.CharType;

internal sealed class JsonSnakeLowerCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string? name)
    {
        if (string.IsNullOrEmpty(name))
            throw new InvalidOperationException();

        var sb = new StringBuilder();
        var lastIndex = name!.Length - 1;
        var typeMap = Constants.CharTypeMap;
        var prevType = ULine;
        char ch;
        CharType type;

        for (var i = 0; i <= lastIndex; i++)
        {
            ch = name[i];

            if (ch <= '\x7f')
            {
                type = typeMap[ch];

                switch (type)
                {
                    case Lower:
                        sb.Append(ch);
                        break;

                    case Upper:

                        if (prevType == Upper)
                        {
                            if (i < lastIndex)
                            {
                                var nextCh = name[i + 1];

                                if (nextCh <= '\x7f')
                                {
                                    if (typeMap[nextCh] == Lower)
                                        sb.Append('_');
                                }
                                else if (char.IsLower(nextCh))
                                    sb.Append('_');
                            }
                        }
                        else if (prevType != ULine)
                            sb.Append('_');

                        sb.Append((char)(ch + 32));
                        break;

                    case ULine:
                        sb.Append('_');
                        break;

                    default:
                        sb.Append(ch);
                        break;
                }

                prevType = type;
            }
            else if (char.IsLower(ch))
            {
                sb.Append(ch);
                prevType = Lower;
            }
            else if (char.IsUpper(ch))
            {
                if (prevType == Upper)
                {
                    if (i < lastIndex && char.IsLower(name[i + 1]))
                        sb.Append('_');
                }
                else if (prevType != ULine)
                    sb.Append('_');

                sb.Append(char.ToLowerInvariant(ch));
                prevType = Upper;
            }
            else
            {
                sb.Append(ch);
                prevType = Other;
            }
        }

        return sb.ToString();
    }
}
