using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static Entities.Enum;

namespace Entities
{
    public class QueryVms
    {
        public string Subject { get; set; }
        public string Review { get; set; }
    }

    public class AppInfoVms
    {
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
    }
    public class ContentVms
    {
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }
    public class ContentSettingsVms
    {
        public AppInfoVms Appinfo { get; set; }
        public List<ContentVms> content { get; set; }
    }
    public class AdminDashboard
    {
        public int TotalUsers { get; set; }
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public int TotalCategories { get; set; }
    }
    public class ProfileDtos
    {
        public string Id { get; set; }
        public string Phone { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Role { get; set; }
        public UserStatus Status { get; set; }
        public LoginProvider ExternalType { get; set; }
        public string ExternalId { get; set; }
        public string FcmToken { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string JoiningDate { get; set; }
        public string Gender { get; set; }
        public string BranchName { get; set; }
        public int? BranchId { get; set; }
    }
    public class AddStaffDtos
    {
        public string Phone { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public UserType Role { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Gender { get; set; }
        public int? BranchId { get; set; }
    }

    public class ProductDtos
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<ProductsImagesVms> ProductsImages { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile[] Gallery { get; set; }
        public decimal Price { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        public int BranchId { get; set; }
        public string CategoryName { get; set; }
        public string BranchName { get; set; }
        public EntityStatus Status { get; set; }
    }
    public class ProductsImagesVms
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }

    public class IngredientAddVms
    {
        public int BranchId { get; set; }
        public int CategoryId { get; set; }
        public int? ProductId { get; set; }
        public List<IngredientListVms> Items { get; set; }
    }

    public class IngredientListVms
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string CategoryName { get; set; }
        public string BranchName { get; set; }
        public EntityStatus Status { get; set; }
    }
    public class CategoryVms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public EntityStatus Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
    public class CategoryAddVms
    {
        public int? catId { get; set; }
        public int? BranchId { get; set; }
        public string Name { get; set; }
    }
    public class BranchVms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Address { get; set; }
        public EntityStatus Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
    public class BranchAddVms
    {
        public int? branchId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Address { get; set; }
    }
    public class ChangePasswordVMS
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }
    }
    public class ForgotPasswordVMS
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    public class ForgotPasswordLink
    {
        [Required]
        public string Link { get; set; }
    }


    public class ContactUsVms
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public QueryStatus Status { get; set; }
        public string StringCreatedAt { get; set; }
        public string StringUpdatedAt { get; set; }
    }
    
    public class UserProfileDtos
    {
        public string Id { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public EntityStatus Status { get; set; }
        public string CreatedAt { get; set; }
    }

    public class contentVms
    {
        public string content { get; set; }
        public string title { get; set; }
    }

    public class aboutappVms
    {
        public string twitter_link { get; set; }
        public string google_link { get; set; }
        public string instagram_link { get; set; }
        public string facebook_link { get; set; }
        public string website { get; set; }
        public string version { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }

    public class contactUs
    {
        public int Id { get; set; }
        public string subject { get; set; }
        public string review { get; set; }
        public string userImage { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string createdAt { get; set; }
        public QueryStatus Status { get; set; }
    }

}
