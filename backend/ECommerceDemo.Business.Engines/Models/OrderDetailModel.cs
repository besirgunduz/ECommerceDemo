using ECommerceDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Business.Engines.Models
{
    public class OrderDetailModel : BaseModel
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public ProductModel Product { get; set; }
    }
}
