using System;
using System.Collections;
using System.Collections.Generic;
using IteratorLibrary.ConceptualExample.Collections.Common;
using IteratorLibrary.ConceptualExample.Iterators;

namespace IteratorLibrary.ConceptualExample.Collections
{
    public class WordsCollection : IterableCollection
    {
        private readonly List<string> collection = new();
        private bool isDirectionReversed;

        public int Count => collection.Count;

        public void Add(string word) => collection.Add(word);

        public void ReverseDirection() => isDirectionReversed = !isDirectionReversed;
        
        public string this[int index] 
            => index >= 0 && index < collection.Count
                ? collection[index]
                : throw new ArgumentOutOfRangeException(nameof(index));
        
        public override IEnumerator GetEnumerator()
            =>  new AlphabeticalOrderIterator(this, isDirectionReversed);
    }
}