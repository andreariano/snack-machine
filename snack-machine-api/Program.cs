using System.Reflection;
using MediatR;
using snack_machine_shared.Bus;
using snack_machine_infra.Config;
using snack_machine_infra.Bus;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddInMemoryConfigurationProvider();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddInMemoryMessageQueue();
builder.Services.AddTransient<ISnackMachineBus, InMemoryBus>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
