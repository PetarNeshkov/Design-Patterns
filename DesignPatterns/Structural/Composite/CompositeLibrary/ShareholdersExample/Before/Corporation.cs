namespace CompositeLibrary.ShareholdersExample.Before;

public class Corporation
{
    public string Name { get; set; }
    
    public List<Person> Shareholders { get; set; } = new();
}