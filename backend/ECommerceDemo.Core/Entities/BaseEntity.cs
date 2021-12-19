using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        private bool status;
        private DateTime createdDate;

        public DateTime? CreateDate
        {
            get
            {
                return createdDate;
            }
            set
            {
                createdDate = value ?? DateTime.UtcNow;
            }
        }

        public bool? Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value ?? true;
            }
        }
    }
}
