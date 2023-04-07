using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
