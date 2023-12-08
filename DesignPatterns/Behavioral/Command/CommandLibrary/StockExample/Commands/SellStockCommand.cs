using CommandLibrary.StockExample.Common;

namespace CommandLibrary.StockExample.Commands;

public class SellStockCommand : IOrderCommand
{
    private readonly Stock stock;

    public SellStockCommand(Stock stock)
    {
        this.stock = stock;
    }
    
    public void Execute() => stock.Sell();
}