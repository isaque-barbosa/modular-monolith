using System.Text.Json.Serialization;

namespace Payment.Module.Models;

[JsonSerializable(typeof(UserViewModel))]
[JsonSerializable(typeof(ProductViewModel[]))]
[JsonSerializable(typeof(ProductViewModel))]
[JsonSerializable(typeof(CartViewModel))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}

public record CartViewModel(int Id, ProductViewModel[] Products, UserViewModel User);

public record ProductViewModel(int Id, string Name, decimal Price, int Quantity);

public record UserViewModel(int Id);
