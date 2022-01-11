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
        Task<ResponseDto> Login(LoginViewModel LoginUser);
        AdminDashboard DashboardStats();
        contentVms GetTerms();
        contentVms GetPrivacyPolicy();
        ResponseDto UpdatePrivacyPolicy(contentVms modal);
        ResponseDto UpdateTerms(contentVms modal);
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
        ResponseDto BlockBranch(int Id);
        ResponseDto UnBlockBranch(int Id);
        ResponseDto LeftUser(string Id);
    }
}
