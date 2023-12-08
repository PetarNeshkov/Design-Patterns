using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class ChangeCartQuantityCommand : ICommand
    {
        private readonly Product product;
        private readonly ChangeCartQuantityOperation operation;
        private readonly IProductRepository productRepository;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public ChangeCartQuantityCommand(
            Product product,
            ChangeCartQuantityOperation operation,
            IProductRepository productRepository,
            IShoppingCartRepository shoppingCartRepository)
        {
            this.product = product;
            this.operation = operation;
            this.productRepository = productRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public bool CanExecute()
            => operation switch
            {
                ChangeCartQuantityOperation.Increase => (productRepository.GetStock(product.ProductId) - 1) <= Product.ProductPurchaseLimit,
                ChangeCartQuantityOperation.Decrease => shoppingCartRepository.GetById(product.ProductId).Quantity > 0,
                _ => false,
            };

        public void Execute()
        {
            switch (operation)
            {
                case ChangeCartQuantityOperation.Increase:
                    productRepository.DecreaseStock(product.ProductId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ProductId);
                    break;
                case ChangeCartQuantityOperation.Decrease:
                    productRepository.IncreaseStock(product.ProductId, 1);
                    shoppingCartRepository.DecreaseQuantity(product.ProductId);
                    break;
            }
        }

        public void Undo()
        {
            switch (operation)
            {
                case ChangeCartQuantityOperation.Increase:
                    productRepository.IncreaseStock(product.ProductId, 1);
                    shoppingCartRepository.DecreaseQuantity(product.ProductId);
                    break;
                case ChangeCartQuantityOperation.Decrease:
                    productRepository.DecreaseStock(product.ProductId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ProductId);
                    break;
            }
        }
    }
}