using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Business.Engines.Models.RequestModels
{
    public class ProductListRequestModel
    {
        public int CategoryId { get; set; }
        public OrderBy? OrderBy { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
    public enum OrderBy
    {
        PriceAsc,
        PriceDesc
    }
}
