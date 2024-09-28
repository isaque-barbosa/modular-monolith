using Api.Configuration;

var builder = WebApplication.CreateSlimBuilder(args);

builder
    .Services
    .AddControllers();

builder
    .Services
    .AddModules();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllers();
});

app.Run();
