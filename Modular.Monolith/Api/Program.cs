using Api.Configuration;
using System.Text.Json.Serialization;
using User.Contract.IService;
using User.Module.Service;

var builder = WebApplication.CreateSlimBuilder(args);

builder
    .Services
    .AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder
    .Services
    .AddModules();

builder
    .Services
    .AddScoped<IUserService, UserService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllers();
});

app.Run();
