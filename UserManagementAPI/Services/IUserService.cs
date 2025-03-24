using UserManagementAPI.DTO;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(UserRegisterDto dto);
    }
}
