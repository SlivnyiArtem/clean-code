﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown.Parsers
{
    public class EndLinkParser : IParser
    {
        public IToken TryGetToken(ref string line, int i)
        {
            var substring = line.Substring(i + 1, line.Length - i - 1);
            string address;
            if (line[i + 1] == '(' && substring.Contains(')'))
            {

                var start = substring.IndexOf('(');
                var finish = substring.IndexOf(')');
                address = line.Substring(i + start + 2, finish - 1 - start);
                line = line.Remove(start, finish - start + 1);
            }
            else
            {
                address = null;
            }

            return new TagLink(address);
        }

        public IToken TryGetToken()
        {
            throw new NotImplementedException();
        }
    }
}
