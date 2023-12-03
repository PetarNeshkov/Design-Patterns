using System;
using System.Drawing;

namespace FlyweightLibrary.ForestExample
{
    /// <summary>
    /// The flyweight class contains a portion of the state of a <see cref="Tree"/>.
    /// These fields store values that are unique for each particular tree.
    /// For instance, you won't find here the tree coordinates, but the texture and colors shared between many trees are here.
    /// Since this data is usually BIG, you'd waste a lot of memory by keeping it in each tree object.
    /// Instead, we can extract name, color, texture and other repeating data into a
    /// separate object which lots of individual tree objects can reference.
    /// </summary>
    public class TreeType
    {
        private readonly string name;
        private readonly KnownColor color;
        private readonly string texture;

        public TreeType(string name, KnownColor color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }
        
        public void Render(double latitude, double longitude) =>
            Console.WriteLine(
                $"{name} tree with {color} color and {texture} is rendered " +
                $"at coordinates ({latitude}, {longitude})");
    }
}