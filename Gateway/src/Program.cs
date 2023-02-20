var builder = WebApplication.CreateBuilder(args);

const string Products = "products";
const string Reviews = "reviews";

builder.Services.AddHttpClient(Products, c => c.BaseAddress = new Uri("http://localhost:5210/graphql"));
builder.Services.AddHttpClient(Reviews, c => c.BaseAddress = new Uri("http://localhost:5220/graphql"));

// setup  HotChocolate schema Stitching
builder.Services
    .AddGraphQLServer()
    .AddRemoteSchema(Products)
    .AddRemoteSchema(Reviews);


var app = builder.Build();

app.MapGraphQL();

app.Run();