using SecondApi.Api.EndPoints;
using SecondApi.Api.Repositories;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IDataRepositries, InMemDataRepositries>();
var app = builder.Build();

app.MapDataEndPoints();
app.Run();