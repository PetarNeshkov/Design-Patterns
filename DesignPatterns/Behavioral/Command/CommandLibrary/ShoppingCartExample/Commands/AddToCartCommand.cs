using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly Product product;
        private readonly IProductRepository productRepository;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public AddToCartCommand(Product product, IProductRepository productRepository, IShoppingCartRepository shoppingCartRepository)
        {
            this.product = product;
            this.productRepository = productRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }
        
        public bool CanExecute() => productRepository.GetStock(product.ProductId) > 0;


        public void Execute()
        {
            productRepository.DecreaseStock(product.ProductId, 1);
            shoppingCartRepository.Add(product);
        }

        public void Undo()
        {
            var lineItem = shoppingCartRepository.GetById(product.ProductId);

            productRepository.IncreaseStock(product.ProductId, lineItem.Quantity);
            shoppingCartRepository.Remove(product.ProductId);
        }
    }
}