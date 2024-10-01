using User.Contract.IService;
using User.Contract.Models;

namespace User.Module.Service;

public class UserService : IUserService
{
    public async Task<UserDTO> GetUser(int id)
    {
        var user = new UserDTO(Id: 1, Name: "Person 1");
        return await Task.FromResult(user);
    }
}
