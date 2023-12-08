using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;
using ICommand = CommandLibrary.ShoppingCartExample.Commands.Common.ICommand;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class RemoveFromCartCommand : ICommand
    {
        private readonly Product product;
        private readonly IProductRepository productRepository;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public RemoveFromCartCommand(Product product, IProductRepository productRepository, IShoppingCartRepository shoppingCartRepository)
        {
            this.product = product;
            this.productRepository = productRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public bool CanExecute() => shoppingCartRepository.GetById(product.ProductId).Quantity > 0;

        public void Execute()
        {
            var lineItem = shoppingCartRepository.GetById(product.ProductId);

            productRepository.IncreaseStock(product.ProductId, lineItem.Quantity);
            shoppingCartRepository.Remove(product.ProductId);
        }

        public void Undo()
        {
            shoppingCartRepository.Add(product);

            productRepository.DecreaseStock(product.ProductId, 1);

        }
    }
}