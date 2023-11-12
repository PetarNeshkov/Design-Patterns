using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents;

public class TermPaper : Document
{
    public TermPaper(IFormatter formatter) 
        : base(formatter)
    {
    }
    
    public string Class { get; set; } = string.Empty;
    
    public string Student { get; set; } = string.Empty;
    
    public string Text { get; set; } = string.Empty;
    
    public string References { get; set; } = string.Empty;

    public override void Print()
    {
        Console.WriteLine(formatter.Format("Class", Class));
        Console.WriteLine(formatter.Format("Student", Student));
        Console.WriteLine(formatter.Format("Text", Text));
        Console.WriteLine(formatter.Format("References", References));
        Console.WriteLine();
    }
}