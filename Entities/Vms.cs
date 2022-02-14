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
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string GoogleUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal ServiceCharges { get; set; }
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
        public int PendingOrders { get; set; }
        public int InProcessOrders { get; set; }
        public int CompletedOrders { get; set; }
        public int CancelledOrders { get; set; }
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
    public class ProductAndIngredientDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<ProductsImagesVms> ProductsImages { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public decimal Price { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        public int BranchId { get; set; }
        public bool AddedToCart { get; set; }
        public string CategoryName { get; set; }
        public string BranchName { get; set; }
        public EntityStatus Status { get; set; }
        public List<IngredientListVms> IngredientLists { get; set; }
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
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int? ProductId { get; set; }
        public string BranchName { get; set; }
        public int BranchId { get; set; }
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
        public string email { get; set; }
        public string telephone { get; set; }
        public decimal delivery_modal { get; set; }
        public decimal services_modal { get; set; }
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
    public class CategoryAndProductsVms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public List<ProductDtos> ProductList { get; set; }
    }
    public class SaveOrderData
    {
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_phone { get; set; }
        public string table_num { get; set; }
        public decimal price { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public OrderType orderType { get; set; }
        public List<AllProducts> AllProducts { get; set; }
    }
    public class AddToCart
    {
        public int productId { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public bool BranchBool { get; set; }
        public List<ingredientList> AllIngredients { get; set; }
    }
    public class StaffOrderReports
    {
        public string staffEmail { get; set; }
        public string staffImage { get; set; }
        public string minutesSpent { get; set; }
        public string endTime { get; set; }
        public string startTime { get; set; }
        public string orderId { get; set; }
    }
    public class AllProducts
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public int quantity { get; set; }
        public decimal total_price { get; set; }
        public List<ingredientList> ingredientList { get; set; }
    }
    public class ingredientList
    {
        public int Id { get; set; }
        public string ingredientName { get; set; }
        public int quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class GetOrderdetails
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotal { get; set; }
        public OrderStatus Status { get; set; }
        public string UserId { get; set; }
        public string AssigneeId { get; set; }
        public string AssigneeName { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string CreatedAt { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ElaspedTime { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class GetStaffOrderdetails
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
        public string UserId { get; set; }
        public string AssigneeId { get; set; }
        public string AssigneeName { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public string CreatedAt { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public WorkerStatus WorkerStatus { get; set; }
        public DateTime? StartTime { get; set; }

    }
    public class GetStaffDashboardStats
    {
        public int TotalOrders { get; set; }
        public int InProcessOrder { get; set; }
        public int Completed { get; set; }
        public List<GetStaffOrderdetails> OrderDetails { get; set; }
    }
    public class MyCarts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<ProductsImagesVms> ProductsImages { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public CartStatus CartStatus { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        public int BranchId { get; set; }
        public bool AddedToCart { get; set; }
        public string CategoryName { get; set; }
        public string BranchName { get; set; }
        public EntityStatus Status { get; set; }
        public List<CartIngredientListVms> IngredientLists { get; set; }
    }
    public class CartIngredientListVms
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int? ProductId { get; set; }
        public string BranchName { get; set; }
        public int BranchId { get; set; }
        public int Quantity { get; set; }
        public bool AddedInCart { get; set; }
        public EntityStatus Status { get; set; }
    }
    public class ProductAndIngredientDtos2
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public List<IngredientListVms2> IngredientLists { get; set; }
    }
    public class IngredientListVms2
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public class UpdateCart
    {
        public int cartId { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public List<ingredientList> AllIngredients { get; set; }
    }

    public class PlaceOrderCustomer
    {
        [Required]
        public string cardNumber { get; set; }
        [Required]
        public int month { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public decimal amount { get; set; }
        [Required]
        public decimal sub_total { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_phone { get; set; }
        public string customer_note { get; set; }
        public string customer_address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public OrderType orderType { get; set; }
    }
    public class GetSingleOrderdetails
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotal { get; set; }
        public OrderStatus Status { get; set; }
        public string UserId { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string CreatedAt { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ElaspedTime { get; set; }
        public decimal DeliveryCharges { get; set; }
        public OrderType Type { get; set; }
        public decimal ServiceCharges { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<AllProducts> AllProducts { get; set; }
    }
}
