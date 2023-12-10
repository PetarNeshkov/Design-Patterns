namespace IteratorLibrary.MusicFestivalExample.Iterators.Common;

public interface IIterator
{
    int Step { get; set; }

    MusicFestival First();
    
    MusicFestival Current();
    
    bool MoveNext();
    
    void Reset();
}