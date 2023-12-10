using IteratorLibrary.ConceptualExample.Collections;
using IteratorLibrary.ConceptualExample.Iterators.Common;

namespace IteratorLibrary.ConceptualExample.Iterators;

/// <summary>
/// Concrete iterators implement various traversal algorithms.
/// These classes store the current traversal position at all times.
/// </summary>
public class AlphabeticalOrderIterator : Iterator
{
    /// <summary>
    /// Stores the current traversal position.
    /// An iterator may have a lot of other fields for storing iteration state,
    /// especially when it is supposed to work with a particular kind of collection.
    /// </summary>
    private int position = -1;

    private readonly WordsCollection collection;
    private readonly bool isDirectionReversed;

    public AlphabeticalOrderIterator(WordsCollection collection, bool isDirectionReversed = false)
    {
        this.collection = collection;
        this.isDirectionReversed = isDirectionReversed;

        if (this.isDirectionReversed)
        {
            position = this.collection.Count;
        }
    }

    public override object Current()
        => collection[position];

    public override bool MoveNext()
    {
        var updatedPosition = position + (isDirectionReversed ? -1 : 1);

        if (updatedPosition >= 0 && updatedPosition < collection.Count)
        {
            position = updatedPosition;
            return true;
        }

        return false;
    }

    public override void Reset()
     => position = isDirectionReversed ? collection.Count : -1;
}