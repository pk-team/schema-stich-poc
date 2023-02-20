var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<ProductService>()
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
