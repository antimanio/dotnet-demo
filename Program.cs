using dotnet_demo;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGamesEndPoints();

app.Run();
