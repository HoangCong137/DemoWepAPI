using ProductMicroservice.DBContexts;
using ProductMicroservice.Models;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;
        public ProductRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int Product_ID)
        {
            var product = _dbContext.Products.Find(Product_ID);
            _dbContext.Products.Remove(product);
            Save();
        }

        public Product GetProductByID(int Product_ID)
        {
            return _dbContext.Products.Find(Product_ID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
