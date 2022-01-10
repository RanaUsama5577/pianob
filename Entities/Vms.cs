using Microsoft.AspNetCore.Http;
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
        public string Token { get; set; }
        public LoginProvider ExternalType { get; set; }
        public string ExternalId { get; set; }
        public string DateOfBirth { get; set; }
        public string FcmToken { get; set; }
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
