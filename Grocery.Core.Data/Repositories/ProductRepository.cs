using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            // Initialiseer de lijst met 4 producten
             products = new List<Product>
    {
        new Product(1, "Melk", 300),
        new Product(2, "Kaas", 100),
        new Product(3, "Brood", 400),
        new Product(4, "Cornflakes", 0)
    };
        }

        public List<Product> GetAll()
        {
            // Geef de volledige lijst terug
            return products;
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            products.Add(item);
            return item;
        }

        public Product? Delete(Product item)
        {
            if (products.Remove(item))
                return item;
            return null;
        }

        public Product? Update(Product item)
        {
            var existing = products.FirstOrDefault(p => p.Id == item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Stock = item.Stock;
            }
            return existing;
        }
    }
}