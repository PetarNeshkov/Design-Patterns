using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

public abstract class Document
{
    protected readonly IFormatter formatter;

    protected Document(IFormatter formatter)
    {
        this.formatter = formatter;
    }

    public abstract void Print();
}