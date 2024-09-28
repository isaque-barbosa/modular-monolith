using System.Text.Json.Serialization;

namespace User.Module.Models;

[JsonSerializable(typeof(UserViewModel))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}

public record UserViewModel(string Name, string Email);
