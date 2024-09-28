using System.Text.Json.Serialization;

namespace Product.Module.Models;

[JsonSerializable(typeof(ProductViewModel))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}

public record ProductViewModel(string Name, decimal Price);
