
using Mediator.Application.Absractions;
using Mediator.Application.Features.CreateOrder;
using Mediator.Application.Features.GetOrder;
using Microsoft.AspNetCore.Http.HttpResults;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<ICommandHandler<CreateOrderCommand, CreateOrderResponse>, CreateOrderHandler>()
    .AddScoped<IQueryHandler<GetOrderQuery, GetOrderResponse>, GetOrderHandler>();

WebApplication app = builder.Build();

app.MapGet("/", () => "Hello from Mediator!");

app.MapGet(pattern: "/order/{id:guid}",
    handler: async Task<Results<NotFound, Ok<GetOrderResponse>>> (Guid id, IQueryHandler<GetOrderQuery,
    GetOrderResponse> handler) =>
    {
        GetOrderQuery query = new(id);
        return TypedResults.Ok(await handler.HandleAsync(query));
    });

app.MapPost(pattern: "/order",
    handler: async Task<Results<BadRequest, Created<CreateOrderResponse>>> (CreateOrderCommand command,
    ICommandHandler<CreateOrderCommand, CreateOrderResponse> handler) =>
    {
        _ = await handler.HandleAsync(command);
        return TypedResults.Created<CreateOrderResponse>("", null);
    });

app.Run();
