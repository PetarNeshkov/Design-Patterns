using FlyweightLibrary.DotNetStringExample;
using FlyweightLibrary.ForestExample;

namespace FlyweightLibrary
{
    // Intent: Lets you fit more objects into the available amount of RAM by sharing
    // common parts of state between multiple objects, instead of keeping all of the
    // data in each object.
    internal class Program
    {
        // EN: The Flyweight stores a common portion of the state (also called
        // intrinsic state) that belongs to multiple real business entities. The
        // Flyweight accepts the rest of the state (extrinsic state, unique for each
        // entity) via its method parameters.
        public static void Main(string[] args)
        {
            DotNetStringExecutor.Execute();
            ForestExecutor.Execute();
        }
    }
}