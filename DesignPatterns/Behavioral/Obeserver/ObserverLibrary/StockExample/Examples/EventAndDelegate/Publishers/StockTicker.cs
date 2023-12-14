using System;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;

public class StockTicker
{
    private Stock lastChangedStock = Stock.Default();
    
    public event EventHandler<StockChangeEventArgs>? StockChange;

    public void ProcessNewStockChange(Stock stock)
    {
        lastChangedStock = stock;
        OnStockChange(new StockChangeEventArgs(lastChangedStock));
    }

    private void OnStockChange(StockChangeEventArgs e) 
        => StockChange?.Invoke(this, e);
}