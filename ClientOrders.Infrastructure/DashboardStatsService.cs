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

    public (int totalClients, int totalOrders,int ordersThisMonth) GetStats()
    {
        var now = DateTime.Now;
        var totalClients = _context.Clients.Count();
        var totalOrders = _context.Orders.Count();
        var ordersThisMonth = _context.Orders.Count(o => o.CreatedAt.Month == now.Month &&
        o.CreatedAt.Year == now.Year);      

        return (totalClients, totalOrders, ordersThisMonth);
    }
}

