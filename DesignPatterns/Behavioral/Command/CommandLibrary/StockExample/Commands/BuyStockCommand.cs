using CommandLibrary.StockExample.Common;

namespace CommandLibrary.StockExample.Commands;

public class BuyStockCommand : IOrderCommand
{
    private readonly Stock stock;

    public BuyStockCommand(Stock stock)
    {
        this.stock = stock;
    }

    public void Execute() => stock.Buy();

}