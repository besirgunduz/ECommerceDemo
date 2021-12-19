using ECommerceDemo.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceDemo.Data.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
