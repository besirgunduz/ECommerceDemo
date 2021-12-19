using ECommerceDemo.Core.Entities;
using System;
using System.Collections.Generic;

namespace ECommerceDemo.Data.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
