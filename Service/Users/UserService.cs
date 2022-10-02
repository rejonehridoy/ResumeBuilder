using Data.Users;
using OA.Repo;
using Service.Caching;
using Service.Users.Interfaces;
using System.Web.Helpers;

namespace Service.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<UserPassword> userPasswordRepository;
        private readonly IStaticCacheManager staticCacheManager;

        public UserService(IRepository<User> userRepository,
            IRepository<UserPassword> userPasswordRepository,
            IStaticCacheManager staticCacheManager)
        {
            this.userRepository = userRepository;
            this.userPasswordRepository = userPasswordRepository;
            this.staticCacheManager = staticCacheManager;
        }
        #region Methods
        #region User
        public async Task<List<User>> GetAllUsersAsync()
        {
            string cacheKey = staticCacheManager.PrepareCacheKey(UserDefaults.AllUsersKey);
            var allUsers = staticCacheManager.Get(cacheKey, async () =>
                {
                    return await userRepository.GetAllAsync();
                }
            );
            return await allUsers;
        }
        public async Task<int> CreateNewUserAsync(User user)
        {
            await userRepository.InsertAsync(user);
            return user.Id;
        }
        public async Task<bool> IsUserExistByEmailAsync(string email)
        {
            var existUser = (await userRepository.GetAllAsync()).Where(u => u.Email == email);
            return existUser.Any();
        }
        #endregion

        #region User Password
        public async Task<bool> CreateUserHashedPasswordAsync(int userId, string plainPassword)
        {
            try
            {
                string salt = Crypto.GenerateSalt(); // salt key
                plainPassword = plainPassword + salt;
                string hashedPassword = Crypto.HashPassword(plainPassword);

                var userPassword = new UserPassword
                {
                    UserId = userId,
                    Password = hashedPassword,
                    PasswordSalt = salt,
                    PasswordFormatId = 0
                };
                await userPasswordRepository.InsertAsync(userPassword);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> AuthenticateUserPasswordAsync(int userId, string plainPassword)
        {
            var userPassword = (await userPasswordRepository.GetAllAsync()).Where(up => up.UserId == userId).FirstOrDefault();
            if(userPassword != null)
            {
                try
                {
                    plainPassword = plainPassword + userPassword.PasswordSalt; // append salt key
                    bool result = Crypto.VerifyHashedPassword(userPassword.Password, plainPassword); //verify password
                    return result;
                }catch(Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        #endregion
        #endregion
    }
}
