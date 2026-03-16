using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientOrders.Core;

namespace ClientOrders.Core
{
    public interface IClientService
    {
        List<Client> GetClients();
    }
}
