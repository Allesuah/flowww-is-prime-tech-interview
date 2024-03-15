using Flowww.WebApi.Features.Number;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGetNumberEndpoint();

app.Run();
