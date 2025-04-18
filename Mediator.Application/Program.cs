
using Mediator.Application.Absractions;
using Mediator.Application.Features.CreateOrder;
using Mediator.Application.Features.GetOrder;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<ICommandHandler<CreateOrderCommand, CreateOrderResponse>, CreateOrderHandler>()
    .AddScoped<IQueryHandler<GetOrderQuery, GetOrderResponse>, GetOrderHandler>();

WebApplication app = builder.Build();

app.MapGet("/", () => "Hello from Mediator!");

app.Run();
