﻿using System.Collections.Generic;

namespace Markdown
{
    public interface ITag : IToken
    {
        bool IsClosed
        { get; set; }

        bool IsStartTag
        { get; set; }

        bool IsAtTheBeginning
        { get; set; }

        bool IsNotToPairTag
        { get; set; }

        string HtmlTagAnalog
        { get; }

        void FindPairToken(LinkedListNode<IToken> currentToken);
    }
}
