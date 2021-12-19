using ECommerceDemo.Core.Entities;
using System.Collections.Generic;

namespace ECommerceDemo.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
