using System.Collections.Generic;
using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands;

public class EmptyCartCommand : ICommand
{
    private readonly IProductRepository productRepository;
    private readonly IShoppingCartRepository shoppingCartRepository;
    private readonly Dictionary<string, int> removedItems;

    public EmptyCartCommand(IProductRepository productRepository, IShoppingCartRepository shoppingCartRepository)
    {
        this.productRepository = productRepository;
        this.shoppingCartRepository = shoppingCartRepository;
        removedItems = new Dictionary<string, int>();
    }

    public bool CanExecute() => !shoppingCartRepository.IsEmpty();

    public void Execute()
    {
        var items = shoppingCartRepository.GetAll();
        removedItems.Clear();

        foreach (var (product, quantity) in items)
        {
            // An alternative approach would be to call RemoveFromCartCommand instead of doing the work manually.
            productRepository.IncreaseStock(product.ProductId, quantity);
            shoppingCartRepository.Remove(product.ProductId);

            removedItems.Add(product.ProductId, quantity);
        }
    }

    public void Undo()
    {
        foreach (var item in removedItems)
        {
            var product = productRepository.GetById(item.Key);

            productRepository.DecreaseStock(item.Key, item.Value);

            for (int i = 0; i < item.Value; i++)
            {
                shoppingCartRepository.Add(product);
            }
        }
    }
}