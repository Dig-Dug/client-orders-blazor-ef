using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOrders.Core
{
    public interface IOrderService
    {
        Task AddOrderAsync(Client client, string title, string description, string? imageUrl);
    }
}
