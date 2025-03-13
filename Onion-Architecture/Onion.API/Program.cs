using Onion.Infrastructure; 
using Onion.Infrastructure.ServiceExtensions;
using Onion.Application.interfaces;
using Onion.Application.Mappings;
using Onion.Application.Services;
using System.Reflection;


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

builder.Services.AddApplicationServiceExtensions(config);
builder.Services.AddAutoMapper(typeof (BlogProfile));
builder.Services.AddScoped<IBloggerService, IBlogService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.MapControllers();

app.Run();


