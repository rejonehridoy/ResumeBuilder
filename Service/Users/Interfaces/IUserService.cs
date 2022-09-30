using Data.Users;

namespace Service.Users.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<int> CreateNewUserAsync(User user);
        Task<bool> IsUserExistByEmailAsync(string email);
        Task<bool> CreateUserHashedPasswordAsync(int userId, string plainPassword);
        Task<bool> AuthenticateUserPasswordAsync(int userId, string plainPassword);
    }
}
