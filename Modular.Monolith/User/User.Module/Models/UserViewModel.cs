using System.Text.Json.Serialization;

namespace User.Module.Models;

[JsonSerializable(typeof(UserViewModel))]
public partial class MyJsonContext : JsonSerializerContext
{
}

public struct UserViewModel(int Id);
