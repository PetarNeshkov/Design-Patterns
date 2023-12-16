using System.Collections.Generic;
using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample
{
    public class SortablePersons
    {
        private readonly List<Person> persons;

        public SortablePersons(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
            persons = new List<Person>();
        }

        public ISortStrategy SortStrategy { get; set; }
        
        public void Add(Person person) => persons.Add(person);

        public void Clear() => persons.Clear();
        
        public IReadOnlyCollection<Person> Sort()
        {
            var sortedPersons = SortStrategy.Sort(persons);
            return sortedPersons;
        }
    }
}