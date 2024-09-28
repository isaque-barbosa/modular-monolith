using Microsoft.AspNetCore.Mvc.ApplicationParts;
using User.Module.Models;

var builder = WebApplication.CreateSlimBuilder(args);

builder
    .Services
    .AddControllers()
    .AddJsonOptions(options => 
    {
        options.JsonSerializerOptions.TypeInfoResolver<MyJsonContext>();
    })
    .PartManager.ApplicationParts
    .Add(new AssemblyPart(typeof(User.Module.Application.UserController).Assembly));

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => 
{
    endpoints.MapControllers();
});

app.Run();
