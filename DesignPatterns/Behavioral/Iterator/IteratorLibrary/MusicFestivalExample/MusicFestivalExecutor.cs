using System;
using IteratorLibrary.MusicFestivalExample.Collections;
using IteratorLibrary.MusicFestivalExample.Iterators;
using IteratorLibrary.MusicFestivalExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalExample;

public static class MusicFestivalExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Music festival example");

        var collection = new FestivalCollection();
        
        collection.Add(new MusicFestival("EXIT", "Serbia"));
        collection.Add(new MusicFestival("Tomorrowland", "Belgium"));
        collection.Add(new MusicFestival("Glastonbury", "UK"));
        collection.Add(new MusicFestival("Coachella", "USA"));
        collection.Add(new MusicFestival("Woodstock", "USA"));
        
        var iterator = collection.CreateIterator();
        
        Console.WriteLine("Initial traversal.");
        Traverse(iterator);

        iterator.Reset();
        iterator.Step = 2;

        Console.WriteLine("\nThe second traversal that should skip every other element.");
        Traverse(iterator);
    }
    
    private static void Traverse(IIterator iterator)
    {
        while (iterator.MoveNext())
        {
            var festival = iterator.Current();
            Console.WriteLine($"Music festival {festival.Name} takes place in {festival.Country}.");
        }
    }
}