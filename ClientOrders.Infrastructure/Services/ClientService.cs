using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClientOrders.Core;
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
    }
}
