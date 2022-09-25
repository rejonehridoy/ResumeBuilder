using Web.Areas.Admin.ViewModels;

namespace Web.Areas.Admin.Factory
{
    public interface IUserModelFactory
    {
        Task<UserListModel> PrepareUserViewModelAsync(UserSearchModel searchModel);
    }
}
