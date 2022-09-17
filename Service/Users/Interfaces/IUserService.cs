using Data.Users;

namespace Service.Users.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
    }
}
