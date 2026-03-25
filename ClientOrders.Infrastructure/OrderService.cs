using ClientOrders.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOrders.Infrastructure
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;
        public OrderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddOrderAsync(Client client, string title, string description, string? imageUrl)
        {


            client.Orders.Add(new Order
            {
                Title = title,
                Description = description,
                ImageUrl = imageUrl,
                CreatedAt = DateTime.Now,
            });
            await _context.SaveChangesAsync();
        }
    }
}
