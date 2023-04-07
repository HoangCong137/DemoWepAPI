using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public int Category_ID { set; get; }
    }
}
