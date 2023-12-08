using System.Collections.Generic;
using System.Linq;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Dictionary<string, (Product Product, int Stock)> products;

        public ProductRepository()
        {
            products = new Dictionary<string, (Product Product, int Stock)>();
            
            AddToWarehouse(new Product("SAM-ZFOLD", "Samsung Galaxy Z Fold 2", 2000), 3);
            AddToWarehouse(new Product("SAM-S20", "Samsung Galaxy S20", 1000), 4);
            AddToWarehouse(new Product("OP-8PRO", "OnePlus 8 Pro", 955), 10);
            AddToWarehouse(new Product("XI-NOTE10", "Xiaomi Mi Note 10", 500), 10);
            AddToWarehouse(new Product("SN-XPERIA5", "Sony Xperia 5 II", 950), 10);
        }
        

        public IEnumerable<Product> GetAll()
            => products.Select(product => product.Value.Product);

        public Product GetById(string productId)
            => products.TryGetValue(productId, out var productInfo) ? productInfo.Product : null;

        public int GetStock(string productId)
            => products.TryGetValue(productId, out var productInfo) ? productInfo.Stock : 0;

        public void IncreaseStock(string productId, int amount)
        {
            if (!products.TryGetValue(productId, out var productInfo))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in the warehouse.");
            }

            products[productId] = (productInfo.Product, productInfo.Stock + amount);
        }

        public void DecreaseStock(string productId, int amount)
        {
            if (!products.TryGetValue(productId, out var productInfo))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in the warehouse.");
            }

            products[productId] = (productInfo.Product, productInfo.Stock - amount);
        }
        
        private void AddToWarehouse(Product product, int stock) 
            => products[product.ProductId] = (product, stock);
    }
}