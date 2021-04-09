using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScentShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this._appDbContext = appDbContext;
            this._shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            order.OrderDetails = new List<OrderDetail>();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            foreach (var item in shoppingCartItems)
            {
                var orderDetails = new OrderDetail
                {
                    OrderId = order.OrderId,
                    Price = item.Perfume.Price,
                    PerfumeId = item.Perfume.Id,
                    Amount = item.Amount
                };
                order.OrderDetails.Add(orderDetails);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }
    }
}
