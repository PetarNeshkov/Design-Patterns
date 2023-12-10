using System.Collections.Generic;
using IteratorLibrary.MusicFestivalExample.Collections.Common;
using IteratorLibrary.MusicFestivalExample.Iterators;
using IteratorLibrary.MusicFestivalExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalExample.Collections;

public class FestivalCollection : IIterableCollection
{
    private readonly List<MusicFestival> festivals = new();
    
    public int Count => festivals.Count;

    public void Add(MusicFestival festival) => festivals.Add(festival);

    public MusicFestival Get(int index) => festivals[index];

    public IIterator CreateIterator() => new FestivalIterator(this);
}