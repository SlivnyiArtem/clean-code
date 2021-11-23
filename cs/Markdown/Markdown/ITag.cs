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

        new bool IsNotToPairToken
        { get; set; }

        void FindPairToken(LinkedListNode<IToken> currentToken);
    }
}
