﻿namespace Chubrik.Json;

using System.Text;
using System.Text.Json;
using static Chubrik.Json.CharType;

internal sealed class JsonSnakeLowerCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new InvalidOperationException();

        var sb = new StringBuilder();
        var lastIndex = name.Length - 1;
        var typeMap = Constants.CharTypeMap;
        var prevType = None;
        char ch;
        CharType type;

        for (var i = 0; i <= lastIndex; i++)
        {
            ch = name[i];

            if (ch > 'z')
                throw new InvalidOperationException();

            type = typeMap[ch];

            switch (type)
            {
                case LetterL:
                    sb.Append(ch);
                    break;

                case LetterU:

                    if (prevType == LetterU)
                    {
                        if (i < lastIndex && typeMap[name[i + 1]] == LetterL)
                            sb.Append('_');
                    }
                    else if (prevType == LetterL || prevType == Number)
                        sb.Append('_');

                    sb.Append(char.ToLower(ch));
                    break;

                case Number:
                case Underln:
                    sb.Append(ch);
                    break;

                default:
                    throw new InvalidOperationException();
            }

            prevType = type;
        }

        return sb.ToString();
    }
}