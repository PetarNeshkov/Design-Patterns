namespace CompositeLibrary.GiftExample.Common;

public abstract class Gift
{
    protected readonly string description;
    protected decimal price;

    protected Gift(string description, decimal price)
    {
        this.description = description;
        this.price = price;
    }

    public abstract decimal CalculatePrice();
}