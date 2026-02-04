using ClientOrders.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// ✅ Register AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        "Server=(localdb)\\MSSQLLocalDB;Database=ClientOrdersDb;Trusted_Connection=True;"
    )
);
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", context =>
{
    context.Response.Redirect("/clients");
    return Task.CompletedTask;
});

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
