﻿using System.Text;
using Markdown.Tags;

namespace Markdown.Parsers
{
    public class DoubleUnderliningParser : IParser
    {
        public IToken TryGetToken(ref int i, ref StringBuilder stringBuilder, ref string line, char currentSymbol)
        {
            i++;
            return new TagBold();
        }
    }
}
