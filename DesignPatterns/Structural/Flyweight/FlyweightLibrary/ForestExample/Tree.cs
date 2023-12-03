namespace FlyweightLibrary.ForestExample
{
    public class Tree
    {
        private readonly double latitude;
        private readonly double longitude;
        private readonly TreeType treeType;
        
        public Tree(double latitude, double longitude, TreeType treeType)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.treeType = treeType;
        }
        
        public void Render() => treeType.Render(latitude, longitude);

    }
}