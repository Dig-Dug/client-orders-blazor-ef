using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientOrders.Core;
using Microsoft.EntityFrameworkCore;
namespace ClientOrders.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;
        public ClientService(AppDbContext context)
        {
            _context = context;
        }
        public List<Client> GetClients()
        {
            return _context.Clients
                .Include (c => c.Orders)
                .ToList ();
        }
        public async Task<Client?> GetClientByAsync(int id)
        {
            return await _context.Clients
                .Include(c => c.Orders.OrderByDescending(o=>o.CreatedAt))
                .FirstOrDefaultAsync(c => c.Id == id);


        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
