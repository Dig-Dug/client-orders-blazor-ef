using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOrders.Core
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }
    }
}
