using DAL;
using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace BLL.AdminService
{
    public interface IAdminService
    {
        List<BranchVms> GetBranches();
        ResponseDto AddBranch(BranchAddVms modal);
        List<ProfileDtos> GetUsers(UserType userType);
        Task<ResponseDto> CreateAdmin();
        Task<ResponseDto> AddStaff(AddStaffDtos modal);
        Task<ResponseDto> Login(LoginViewModel LoginUser);
        AdminDashboard DashboardStats();
        contentVms GetTerms();
        contentVms GetPrivacyPolicy();
        contentVms GetCookiePolicy();
        List<contactUs> GetContactUs();
        ResponseDto ResolveQuery(int Id);
        ResponseDto UpdatePrivacyPolicy(contentVms modal);
        ResponseDto UpdateCookiePolicy(contentVms modal);
        contentVms GetAboutApp();
        ResponseDto UpdateAboutApp(contentVms modal);
        contentVms GetAboutUs();
        ResponseDto UpdateAboutUs(contentVms modal);
        ApplicationUser getLoginUser(string Id);
        ApplicationUser UpdateProfileImage(string ImageUrl, string Id);
        ApplicationUser UpdateProfile(string Name, string Id);
        Task<ResponseDto> ChangePassword(UpdatePasswordVms model, string Id);
        Task<ResponseDto> Logout();
        ResponseDto BlockUser(string Id);
        ResponseDto UnBlockUser(string Id);
        ResponseDto DeleteUser(string Id);
        ResponseDto BlockBranch(int Id);
        ResponseDto UnBlockBranch(int Id);
        ResponseDto LeftUser(string Id);
        List<CategoryVms> GetCategories();
        ResponseDto AddOrUpdateCategory(CategoryAddVms modal);
        ResponseDto DeleteCategory(int Id);
        ResponseDto UnBlockCategory(int Id);
        ResponseDto BlockCategory(int Id);
        List<ProductDtos> GetProducts();
        ResponseDto AddProducts(ProductDtos modal);
        ResponseDto DeleteProduct(int Id);
        ResponseDto UnBlockProduct(int Id);
        ResponseDto BlockProduct(int Id);
        ResponseDto DeleteProductImage(int Id);
        ResponseDto AddIngredients(IngredientAddVms modal);
        List<IngredientListVms> GetIngredient();
        ResponseDto UnBlockIngredient(int Id);
        ResponseDto BlockIngredient(int Id);
        ResponseDto DeleteIngredient(int Id);
        ResponseDto UpdateIngredient(IngredientListVms modal);
        ResponseDto UpdateFcm(string Fcm, string Id);
        ResponseDto GetNotifications(string Id);
        ResponseDto DeleteSingleNotification(int Id, string userId);
        ResponseDto ReadSingleNotification(int Id, string userId);
        ResponseDto GetAndReadAllNotifications(string userId);
        List<CategoryAndProductsVms> GetCategoriesAndProducts(string BranchName);
        AppInfoVms GetAppInfo();
        ResponseDto SaveAboutAppInfo(aboutappVms modal);
    }
}
