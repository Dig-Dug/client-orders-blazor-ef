using ClientOrders.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClientOrders.Infrastructure;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

   // public DbSet<Client> Clients => Set<Client>();
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    //public DbSet<Order> Orders => Set<Order>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ClientOrdersDb;Trusted_Connection=True;");
        }
    }

}
