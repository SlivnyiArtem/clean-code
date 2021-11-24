﻿using System;
using System.Collections.Generic;

namespace Markdown
{
    public class TagHeader : ITag
    {
        public bool IsClosed { get; set; }
        public bool IsStartTag { get; set; }
        public bool IsAtTheBeginning { get; set; }
        public bool IsNotToPairToken { get; set; }

        public string HtmlTagAnalog => (IsStartTag) ? "<h1>" : "</h1>";

        public string Content => "#";

        public void FindPairToken(LinkedListNode<IToken> currentToken)
        {
            while (currentToken != null)
            {
                if (currentToken.Value is TagHeader
                    && !currentToken.Value.IsNotToPairToken)
                {
                    HtmlTokenAnalyzer.MakePair(currentToken.Value as ITag, this);
                }
                currentToken = currentToken.Previous;
            }
        }
    }
}