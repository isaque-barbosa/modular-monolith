namespace Payment.Module.Models;

public record CartViewModel(int Id, ProductViewModel[] Products, UserViewModel User);

public record ProductViewModel(int Id, string Name, decimal Price, int Quantity);

public record UserViewModel(string Name);
