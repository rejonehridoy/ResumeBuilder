using Data.Users;
using Service.Common.Interfaces;
using Service.Users.Interfaces;
using Web.Areas.Admin.Models.Users;
using Web.Areas.Admin.ViewModels;

namespace Web.Areas.Admin.Factory
{
    public class UserModelFactory : IUserModelFactory
    {
        private readonly IUserService userService;
        private readonly IWorkContext workContext;
        #region Ctor
        public UserModelFactory(IUserService userService,
            IWorkContext workContext)
        {
            this.userService = userService;
            this.workContext = workContext;
        }
        #endregion

        #region Methods
        public async Task<UserListModel> PrepareUserViewModelAsync(UserSearchModel searchModel)
        {
            var userListModel = new UserListModel();
            
            var users = await userService.GetAllUsersAsync();
            if (!string.IsNullOrEmpty(searchModel.Name))
            {
                users = users.Where(u => u.Name.ToLower().Contains(searchModel.Name.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(searchModel.Email))
            {
                users = users.Where(u => u.Email.ToLower().Contains(searchModel.Email.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(searchModel.Username))
            {
                users = users.Where(u => u.Email.ToLower().Contains(searchModel.Username.ToLower())).ToList();
            }
            if (searchModel.UserRole != null && searchModel.UserRole != 0)
            {
                users = users.Where(u => u.UserRole == searchModel.UserRole).ToList();
            }
            var model = users.Select(u => new UserModel()
            {
                Id = u.Id,
                Uid = u.Uid,
                Name = u.Name,
                Email = u.Email,
                Username = u.Username,
                UserRole = u.UserRole,
                ExternalLogin = u.ExternalLogin,
                Guid = u.Guid,
                Active  = u.Active,
                Deleted = u.Deleted,
                Gender = u.Gender,
                DateOfBirth = u.DateOfBirth,
                LastIpAddress = u.LastIpAddress,
                CreatedDate = workContext.GetConvertedStoreTime(u.CreatedDate),
                LastActivityDate = u.LastActivityDate != null ? workContext.GetConvertedStoreTime(u.LastActivityDate.Value) : null,
                LastLoginDate = u.LastLoginDate != null ? workContext.GetConvertedStoreTime(u.LastLoginDate.Value) : null,
                PictureId = u.PictureId
            }).ToList();

            if(searchModel.CurrentPage < 1)
            {
                searchModel.CurrentPage = 1;
            }
            const int pageSize = 10;
            int resultCount = model.Count();
            userListModel.InitializePager(resultCount, searchModel.CurrentPage, pageSize);
            int resultSkipCount = (searchModel.CurrentPage - 1) * pageSize;
            model = model.Skip(resultSkipCount).Take(userListModel.PageSize).ToList();
            userListModel.Data = model;
            return userListModel;
        }

        public User PrepareUserFromUserModel(UserModel userModel)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
