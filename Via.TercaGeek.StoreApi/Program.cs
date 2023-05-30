using Via.TercaGeek.StoreApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiServices();
var app = builder.Build();
app.UseRouting()
    .UseEndpoints(endpoints => endpoints.MapGraphQL());

app.Run();
