using ECommerceDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Business.Engines.Models
{
    public class OrderModel : BaseModel
    {
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public UserModel User { get; set; }
        public ICollection<OrderDetailModel> OrderDetails { get; set; }
    }
}
