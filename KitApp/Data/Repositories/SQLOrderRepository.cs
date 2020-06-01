using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitApp.Data.Interfaces;
using KitApp.Models;

namespace KitApp.Data.Repositories
{
    public class SQLOrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public SQLOrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }



        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    BookId = item.Book.Id,
                    Quantity = item.Quantity,
                    OrderId = order.OrderId,
                    Price = item.Book.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();

        }
    }
}
