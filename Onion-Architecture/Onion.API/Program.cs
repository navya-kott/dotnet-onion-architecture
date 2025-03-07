using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Onion.Infrastructure;
using Microsoft.Extensions.Configuration;
using Onion.Application.interfaces;


var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Configure MongoDB settings
var mongoDbSettings = new MongoDbSettings
{
    ConnectionString = config["MongoDbSettings:ConnectionString"],
    DatabaseName = config["MongoDbSettings:DatabaseName"]
};

// Register MongoDB services
builder.Services.AddSingleton(mongoDbSettings);

builder.Services.AddScoped<IBloggerService,BlogRepository>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.MapControllers();

app.Run();


