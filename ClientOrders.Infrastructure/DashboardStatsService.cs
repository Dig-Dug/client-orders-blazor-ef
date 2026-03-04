using ClientOrders.Core;
using ClientOrders.Core;
using ClientOrders.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DashboardStatsService : IDashboardStatsService
{
    private readonly AppDbContext _context;

    public DashboardStatsService(AppDbContext context)
    {
        _context = context;
    }

    public (int totalClients, int totalOrders) GetStats()
    {
        var totalClients = _context.Clients.Count();
        var totalOrders = _context.Orders.Count();

        return (totalClients, totalOrders);
    }
}

