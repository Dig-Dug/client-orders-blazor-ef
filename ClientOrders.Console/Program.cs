using ClientOrders.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ClientOrders.Core;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer(
        "Server=(localdb)\\MSSQLLocalDB;Database=ClientOrdersDb;Trusted_Connection=True;"
    )
    .Options;

using var context = new AppDbContext(options);

// ✅ Add a Client
var client = new Client
{
    Name = "66666"
};
context.Clients.Add(client);
context.SaveChanges();

// ✅ Add an Order linked to that Client
var order = new Order
{
    Description = "Test Order 1",
    ClientId = client.Id
};
context.Orders.Add(order);
context.SaveChanges();

// ✅ Query and display
var clientsWithOrders = context.Clients
    .Include(c => c.Orders);

foreach (var c in clientsWithOrders)
{
    Console.WriteLine($"Client: {c.Name}, Orders: {c.Orders.Count}");
    foreach (var o in c.Orders)
    {
        Console.WriteLine($" - Order: {o.Description}");
    }
}

Console.WriteLine("Done");
Console.WriteLine("Seeding complete. Press any key to exit.");
Console.ReadKey();