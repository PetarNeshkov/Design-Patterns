using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents;

public class Book : Document
{
    public Book(IFormatter formatter)
        : base(formatter)
    {
    }
    
    public string Title { get; set; } = string.Empty;
    
    public string Author { get; set; } = string.Empty;
    
    public string Text { get; set; } = string.Empty;

    public override void Print()
    {
        Console.WriteLine(formatter.Format("Title", Title));
        Console.WriteLine(formatter.Format("Author", Author));
        Console.WriteLine(formatter.Format("Text", Text));
        Console.WriteLine();
    }
}