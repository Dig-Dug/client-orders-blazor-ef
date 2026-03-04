using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IDashboardStatsService
{
    (int totalClients, int totalOrders) GetStats();
}
