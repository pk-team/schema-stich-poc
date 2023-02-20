

var builder = WebApplication.CreateBuilder(args);

// add ReviewService to DI
builder.Services.AddScoped<ReviewService>();

// AddGraphqlServer adds the GraphQL services to the DI container
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
