using CompositeLibrary.FileSystemExample.Common;

namespace CompositeLibrary.FileSystemExample;

public class Folder : FileSystemEntry
{
    private readonly List<FileSystemEntry> items;

    public Folder(string name) 
        : base(name)
    {
        items = new List<FileSystemEntry>();
    }
    
    public void Add(FileSystemEntry entry) => items.Add(entry);

    public void Remove(FileSystemEntry entry) => items.Remove(entry);

    public override double GetSizeInMB()
     => items.Sum(item => item.GetSizeInMB());
}