using IteratorLibrary.MusicFestivalExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalExample.Collections.Common;

public interface IIterableCollection
{
    IIterator CreateIterator();
}