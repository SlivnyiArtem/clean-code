﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown.Parsers
{
    public class SingleUnderliningParser : IParser
    {
        public IToken TryGetToken(int i, string line, StringBuilder builder, char currentSymbol)
        {
            if (i < line.Length - 1 && char.IsDigit(line[i + 1]) ||
                i > 0 && char.IsDigit(line[i - 1]))
            {
                builder.Append(currentSymbol);
                //break;
                return null;
            }

            return new TagItalic();
        }
        
        public IToken TryGetToken()
        {
            throw new NotImplementedException();
        }
    }
}
