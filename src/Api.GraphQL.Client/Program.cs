using Api.GraphQL.Client.Graphql.Consumer;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region GraphQL
builder.Services.AddScoped<IGraphQLClient>(s => 
    new GraphQLHttpClient(builder.Configuration["GraphqlURL"], new SystemTextJsonSerializer())
);
builder.Services.AddScoped<ProdutoConsumer>();
#endregion

builder.Services.AddSwaggerGen();

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
