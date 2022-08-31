using System.Collections.Generic;

namespace WebApplication2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
