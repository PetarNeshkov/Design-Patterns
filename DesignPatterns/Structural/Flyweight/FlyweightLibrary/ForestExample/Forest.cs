using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace FlyweightLibrary.ForestExample
{
    public class Forest
    {
        private readonly TreeFactory treeFactory;
        private readonly ICollection<Tree> trees;

        public Forest(TreeFactory treeFactory)
        {
            this.treeFactory = treeFactory;
            trees = new List<Tree>();
        }

        public void PlantTree(string name, KnownColor color, string texture, double latitude, double longitude)
        {
            var treeType = treeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(latitude, longitude, treeType);
            
            trees.Add(tree);
        }
        
        public void Render()
        {
            foreach (var tree in trees)
            {
                tree.Render();
            }
        }
    }
}