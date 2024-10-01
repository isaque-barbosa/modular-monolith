using User.Contract.Models;

namespace User.Contract.IService;

public interface IUserService
{
    public Task<UserDTO> GetUser(int id);
}
