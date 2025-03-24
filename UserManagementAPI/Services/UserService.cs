using Microsoft.AspNetCore.Identity;
using UserManagementAPI.Data;
using UserManagementAPI.DTO;
using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService (AppDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }  
        public async Task<User> RegisterUserAsync(UserRegisterDto dto)
        {
            var user = new User
            {
                Email = dto.Email,
            };
            user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
  
