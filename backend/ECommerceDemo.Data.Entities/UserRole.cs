using ECommerceDemo.Core.Entities;

namespace ECommerceDemo.Data.Entities
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
