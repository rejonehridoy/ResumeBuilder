using Data.Users;
using OA.Repo;
using Service.Users.Interfaces;

namespace Service.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        #region Methods
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await userRepository.GetAllAsync();
        }
        #endregion
    }
}
