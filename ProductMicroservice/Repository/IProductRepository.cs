using Microsoft.AspNetCore.Components.Forms;
using ProductMicroservice.Models;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int Product_ID);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Product_ID);
        void Save();

    }
}
