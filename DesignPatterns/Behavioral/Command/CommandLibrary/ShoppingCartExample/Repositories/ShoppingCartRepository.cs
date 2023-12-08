using System.Collections.Generic;
using System.Linq;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Dictionary<string, (Product Product, int Quantity)> lineItems;

        public ShoppingCartRepository()
        {
            lineItems = new Dictionary<string, (Product Product, int Quantity)>();
        }

        public IEnumerable<(Product Product, int Quantity)> GetAll()
            => lineItems.Values.ToList();

        public (Product Product, int Quantity) GetById(string productId)
        {
            if (!lineItems.TryGetValue(productId, out var lineItem))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            return lineItem;
        }

        public bool IsEmpty()
           => !lineItems.Any();

        public void Add(Product product)
        {
            if (lineItems.ContainsKey(product.ProductId))
            {
                IncreaseQuantity(product.ProductId);
                return;
            }

            lineItems[product.ProductId] = (product, 1);
        }

        public void Remove(string productId)
        {
            if (!lineItems.ContainsKey(productId))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            lineItems.Remove(productId);
        }

        public void IncreaseQuantity(string productId)
        {
            if (!lineItems.TryGetValue(productId, out var lineItem))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            lineItems[productId] = (lineItem.Product, lineItem.Quantity++);
        }

        public void DecreaseQuantity(string productId)
        {
            if (!lineItems.TryGetValue(productId, out var lineItem))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            lineItems[productId] = (lineItem.Product, lineItem.Quantity--);
        }
    }
}