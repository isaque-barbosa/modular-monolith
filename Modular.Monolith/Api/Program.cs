using Api.Configuration;
using System.Text.Json.Serialization;
using User.Contract.IService;
using User.Module.Service;

var builder = WebApplication.CreateSlimBuilder(args);

var services = builder.Services;
services
    .AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
services.AddEndpointsApiExplorer();

services
    .AddModules();

services
    .AddScoped<IUserService, UserService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllers();
});

app.Run();
