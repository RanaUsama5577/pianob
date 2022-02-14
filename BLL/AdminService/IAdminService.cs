﻿using DAL;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        Task<ResponseDto> ForgotPassword([FromForm] ForgotPasswordVMS model);
        Task<ResponseDto> ResetPassword([FromForm] ResetPasswordVMS model);
        List<ProfileDtos> GetStaffUsers(UserType userType, string userid);
        List<ProfileDtos> GetAllStaffUsers(string userid);
        List<StaffOrderReports> GetOrderStaffReports(int Id);
        Task<ResponseDto> CreateAdmin();
        Task<ResponseDto> AddStaff(AddStaffDtos modal);
        Task<ResponseDto> Login(LoginViewModel LoginUser);
        Task<ResponseDto> Register(LoginViewModel LoginUser);
        AdminDashboard DashboardStats(string UserId);
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
        List<CategoryVms> GetStaffCategories(string userId);
        ResponseDto AddOrUpdateCategory(CategoryAddVms modal);
        ResponseDto DeleteCategory(int Id);
        ResponseDto UnBlockCategory(int Id);
        ResponseDto BlockCategory(int Id);
        List<ProductDtos> GetProducts();
        List<ProductDtos> GetStaffProducts(string userId);
        ProductAndIngredientDtos ProductDetail(int Id,string BranchName,string CategoryName,string userId);
        ResponseDto AddProducts(ProductDtos modal);
        ResponseDto DeleteProduct(int Id);
        ResponseDto UnBlockProduct(int Id);
        ResponseDto BlockProduct(int Id);
        ResponseDto DeleteProductImage(int Id);
        ResponseDto AddIngredients(IngredientAddVms modal);
        List<IngredientListVms> GetIngredient();
        List<IngredientListVms> GetStaffIngredient(string userId);
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
        ResponseDto SaveOrder(SaveOrderData modal,string userId);
        List<GetOrderdetails> GetOrderdetails(string userId);
        List<AllProducts> GetOrderProducts(int Id);
        GetStaffDashboardStats GetStaffOrderdetails(string userId);
        ResponseDto StartFirstOrder(string userId);
        ResponseDto MarkOrderAsCooked(int orderId,string userId);
        ResponseDto MarkOrderAsPacked(int orderId,string userId);
        ResponseDto AssignPerson(int orderId,string userId);
        List<GetOrderdetails> StaffCompletedOrders(string userId);
        ResponseDto StartDeliveringOrder(string userId, int orderId);
        ResponseDto MarkOrderAsDelivered(int orderId, string userId);
        /////// Customer Apis
        ResponseDto AddToCart(AddToCart modal, string userId);
        List<MyCarts> MyCarts(string userId);
        ResponseDto RemoveFromCart(int Id);
        ResponseDto GetCart(int Id);
        ResponseDto UpdateCart(UpdateCart modal, string userId);
        ResponseDto SaveOrderCustomer(PlaceOrderCustomer modal, string userId);
        List<GetOrderdetails> GetCurrentOrderdetails(string userId);
        GetSingleOrderdetails GetSingleOrderdetails(int orderId);
        List<GetOrderdetails> GetOrderHistorydetails(string userId);
    }
}
