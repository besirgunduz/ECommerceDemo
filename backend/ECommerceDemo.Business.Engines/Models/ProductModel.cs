using ECommerceDemo.Core.Entities;

namespace ECommerceDemo.Business.Engines.Models
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Picture { get; set; }
        public CategoryModel Category { get; set; }
    }
}
