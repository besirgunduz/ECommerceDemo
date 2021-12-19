using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.App.API.Controllers
{
    public class OrdersController : BaseController<OrderModel, Order>
    {
        public OrdersController(IOrderService orderService) : base(orderService)
        {

        }

    }
}
