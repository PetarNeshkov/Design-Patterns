using CompositeLibrary.FileSystemExample.Common;

namespace CompositeLibrary.FileSystemExample;

public class File : FileSystemEntry
{
    public File(string name, double size) 
        : base(name)
    {
    }

    public double Size { get;}

    public override double GetSizeInMB()
        => Size;
}