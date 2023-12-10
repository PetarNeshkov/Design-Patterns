using System;
using IteratorLibrary.MusicFestivalExample.Collections;
using IteratorLibrary.MusicFestivalExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalExample.Iterators;

public class FestivalIterator : IIterator
{
    private readonly FestivalCollection collection;
    private int position;
    private int step;

    public FestivalIterator(FestivalCollection collection)
    {
        this.collection = collection;
        position = -1;
        step = 1;
    }
    
    // It's probably more logical to have a method for changing the step.
    // However, for demo purposes the idea was to show that iterator interface can contain properties too.
    public int Step
    {
        get => step;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "The step can be only positive value. The current iterator doesn't support going backward.");
            }

            step = value;
        }
    }

    public MusicFestival First()
    {
        position = 0;
        return Current();
    }

    public MusicFestival Current() => collection.Get(position);


    public bool MoveNext()
    {
        var updatedPosition = position + step;

        if (updatedPosition < collection.Count)
        {
            position = updatedPosition;
            return true;
        }

        return false;
    }

    public void Reset() => position = -1;

}