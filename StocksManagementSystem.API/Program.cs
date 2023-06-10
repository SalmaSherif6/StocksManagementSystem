using Microsoft.EntityFrameworkCore;
using StocksManagementSystem.API.Hubs;
using StocksManagementSystem.API.Interfaces;
using StocksManagementSystem.API.Services;
using StocksManagementSystem.Infrastucture.DbContexts;
using StocksManagementSystem.Infrastucture.Repositories;
using StocksManagementSystem.Services.Interfaces;
using StocksManagementSystem.Services.Repositories;
using StocksManagementSystem.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors();
builder.Services.AddSignalR();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IHubService, HubService>();
builder.Services.AddScoped<ISignalRService, SignalRService>();

var app = builder.Build();

app.UseCors(x =>
{
    x.AllowAnyHeader()
     .AllowAnyMethod()
     .WithOrigins("http://localhost:4200")
     .AllowCredentials();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<NotificationHub>("/notification");

app.Run();

app.UseRouting();