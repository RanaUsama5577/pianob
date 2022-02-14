using DAL;
using DAL.Branches;
using DAL.Categories;
using DAL.Orders;
using DAL.Products;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Entities.Enum;

namespace BLL.AdminService
{
    public class AdminService : commonclass, IAdminService
    {
        private readonly ApplicationDbContext db;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IConfiguration Configuration { get; }

        public AdminService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager2, SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext database, IHostingEnvironment hostingEnvironment, IConfiguration configuration) : base(hostingEnvironment)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            db = database;
            this.roleManager = roleManager2;
            Configuration = configuration;
        }

        async Task<ResponseDto> IAdminService.ForgotPassword([FromForm] ForgotPasswordVMS model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Where(p => p.Email == model.Email).FirstOrDefault();
                if (user == null)
                {
                    return JsonResponse2(401, "User doesn't exists", null);
                }
                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                token = HttpUtility.UrlEncode(token);
                return JsonResponse2(200, token, null);
            }
            // If we got this far, something failed, redisplay form
            return JsonResponse2(400, "error", null);
        }
        async Task<ResponseDto> IAdminService.ResetPassword([FromForm] ResetPasswordVMS model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Where(p => p.Email == model.Email).FirstOrDefault();
                if (user == null)
                {
                    return JsonResponse2(401, "User doesn't exists", null);
                }
                //var token = await userManager.GeneratePasswordResetTokenAsync(user);
                var result = await userManager.ResetPasswordAsync(user, model.Code, model.NewPassword);
                if (result.Succeeded)
                {
                    return JsonResponse2(200, "Success , Password Changed Successfully", null);
                }
                else
                {
                    List<string> errorList = new List<string>();
                    foreach (var error in result.Errors)
                    {
                        errorList.Add(error.Description);
                    }
                    return JsonResponse2(401, "Validation Error", errorList);
                }
            }

            // If we got this far, something failed, redisplay form
            return JsonResponse2(400, "error", null);
        }
        async public Task<ResponseDto> CreateAdmin()
        {
            try
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    Email = "user@piano.com",
                    UserName = "user@piano.com",
                    RegisteredAt = currentTime,
                    FullName = "John Doe",
                    ExternalType = LoginProvider.WithEmail,
                    Status = UserStatus.Active,
                    Type = UserType.User,
                    ProfileImageUrl = "/user_icon.png",
                };
                var result = await userManager.CreateAsync(newUser, "1q2w3e4r");
                if (result.Succeeded)
                {
                    if (await roleManager.RoleExistsAsync("User"))
                    {
                        await userManager.AddToRoleAsync(newUser, "User");
                        return JsonResponse2(200, "success", null);
                    }
                    else
                    {
                        IdentityRole identityRole = new IdentityRole();
                        identityRole.Name = "User";
                        await roleManager.CreateAsync(identityRole);
                        await userManager.AddToRoleAsync(newUser, "User");
                        return JsonResponse2(200, "success", null);
                    }
                }
                else
                {
                    return JsonResponse2(400, "error", result);
                }
            }
            catch(Exception ex)
            {
                return JsonResponse2(504, ex.Message,null);
            }
        }
        List<ProfileDtos> IAdminService.GetUsers(UserType userType)
        {
            try
            {
                var users = db.Users.Where(p => p.Type == userType).OrderByDescending(p => p.CreatedAt).AsEnumerable().Select(n => new ProfileDtos {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    Email = n.Email,
                    FullName = n.FullName,
                    Phone = n.PhoneNumber,
                    Username = n.UserName,
                    Role = n.Type,
                    ProfileImageUrl = n.ProfileImageUrl,
                    Status = n.Status,
                    Id = n.Id,
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    JoiningDate = n.JoiningDate != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    BranchId = n.BranchId,
                    Gender = n.Gender,
                    BranchName = n.BranchId != null ? db.Branches.Find(n.BranchId).Name : "-",
                });
                return users.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        List<ProfileDtos> IAdminService.GetAllStaffUsers(string userid)
        {
            try
            {
                var staff = db.Users.Find(userid);
                var branch = db.Branches.Find(staff.BranchId);
                var users = db.Users.Where(p => (p.Type == UserType.Cook || p.Type == UserType.Driver || p.Type == UserType.Packer) && p.BranchId == branch.Id && p.Status == UserStatus.Active).OrderByDescending(p => p.CreatedAt).AsEnumerable().Select(n => new ProfileDtos
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    Email = n.Email,
                    FullName = n.FullName,
                    Phone = n.PhoneNumber,
                    Username = n.UserName,
                    Role = n.Type,
                    ProfileImageUrl = n.ProfileImageUrl,
                    Status = n.Status,
                    Id = n.Id,
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    JoiningDate = n.JoiningDate != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    BranchId = n.BranchId,
                    Gender = n.Gender,
                });
                return users.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        List<ProfileDtos> IAdminService.GetStaffUsers(UserType userType,string userid)
        {
            try
            {
                var staff = db.Users.Find(userid);
                var branch = db.Branches.Find(staff.BranchId);
                var users = db.Users.Where(p => p.Type == userType && p.BranchId == branch.Id).OrderByDescending(p => p.CreatedAt).AsEnumerable().Select(n => new ProfileDtos
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    Email = n.Email,
                    FullName = n.FullName,
                    Phone = n.PhoneNumber,
                    Username = n.UserName,
                    Role = n.Type,
                    ProfileImageUrl = n.ProfileImageUrl,
                    Status = n.Status,
                    Id = n.Id,
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    JoiningDate = n.JoiningDate != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    BranchId = n.BranchId,
                    Gender = n.Gender,
                    BranchName = n.BranchId != null ? db.Branches.Find(n.BranchId).Name : "-",
                });
                return users.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public AdminDashboard DashboardStats(string userId)
        {
            var user = db.Users.Find(userId);
            if(user.Type == UserType.SuperAdmin)
            {
                AdminDashboard a = new AdminDashboard
                {
                    TotalUsers = db.Users.Where(p => p.Status == UserStatus.Active && p.Type != UserType.SuperAdmin).Count(),
                    TotalOrders = db.Orders.Where(p => p.Status != OrderStatus.Cancelled).Count(),
                    TotalProducts = db.Products.Where(p => p.Status == EntityStatus.Active).Count(),
                    TotalCategories = db.Categories.Where(p => p.Status == EntityStatus.Active).Count(),
                };
                return a;
            }
            else
            {
                var branch = db.Branches.Find(user.BranchId);
                if (branch == null)
                {
                    throw new ValidationException("user is assigned to no branch");
                }
                AdminDashboard a = new AdminDashboard
                {
                    TotalOrders = db.Orders.Where(p => p.Status != OrderStatus.Cancelled).Count(),
                    TotalProducts = db.Products.Where(p => p.Status == EntityStatus.Active && p.CategoriesObject.BranchId == branch.Id).Count(),
                    TotalCategories = db.Categories.Where(p => p.Status == EntityStatus.Active && p.BranchId == branch.Id).Count(),
                    PendingOrders = db.Orders.Where(p=>p.Status == OrderStatus.Waiting && p.BranchId == branch.Id).Count(),
                    InProcessOrders = db.Orders.Where(p=>p.Status != OrderStatus.Waiting && p.Status != OrderStatus.Cancelled && p.Status != OrderStatus.Delivered).Where(p=> p.BranchId == branch.Id).Count(),
                    CompletedOrders = db.Orders.Where(p=>p.Status == OrderStatus.Delivered && p.BranchId == branch.Id).Count(),
                    CancelledOrders = db.Orders.Where(p=>p.Status == OrderStatus.Cancelled && p.BranchId == branch.Id).Count(),
                };
                return a;
            }
        }
        public contentVms GetTerms()
        {
            var contactus = db.ContentSettings.Where(p => p.contentType == ContentType.TermsAndConditions).Select(n => new contentVms{
                content = n.content,
                title = n.title,
            }).FirstOrDefault();
            return contactus;
        }
        public List<CategoryVms> GetCategories()
        {
            try
            {
                var entities = db.Categories.AsEnumerable().Select(n => new CategoryVms
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    UpdatedAt = n.UpdatedAt != null?n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt"):"-",
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    BranchName = db.Branches.Find(n.BranchId).Name,
                    BranchId = n.BranchId,
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public List<CategoryVms> GetStaffCategories(string userId)
        {
            try
            {
                var staff = db.Users.Find(userId);
                var branch = db.Branches.Find(staff.BranchId);
                var entities = db.Categories.Where(p=>p.BranchId == branch.Id && p.Status == EntityStatus.Active).AsEnumerable().Select(n => new CategoryVms
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    BranchName = db.Branches.Find(n.BranchId).Name,
                    BranchId = n.BranchId,
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public List<CategoryAndProductsVms> GetCategoriesAndProducts(string BranchName)
        {
            try
            {
                var branch = db.Branches.Where(p => p.Name == BranchName).FirstOrDefault();
                if(branch == null)
                {
                    return new List<CategoryAndProductsVms>();
                }
                var entities = db.Categories.Where(p=>p.Status == EntityStatus.Active && p.BranchId == branch.Id).AsEnumerable().Select(n => new CategoryAndProductsVms
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    Name = n.Name,
                    Id = n.Id,
                    BranchName = db.Branches.Find(n.BranchId).Name,
                    BranchId = n.BranchId,
                    ProductList = db.Products.Where(p=>p.CategoryId == n.Id && p.Status == EntityStatus.Active).AsEnumerable().Select(a=>new ProductDtos { 
                        CreatedAt = a.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                        BranchId = n.BranchId,
                        BranchName = db.Branches.Find(n.BranchId).Name,
                        CategoryId = n.Id,
                        CategoryName = db.Categories.Find(n.Id).Name,
                        Description = a.Description,
                        Id = a.Id,
                        Logo = a.Logo,
                        Name = a.Name,
                        Price = a.Price,
                        ProductsImages = db.ProductsImages.Where(p=>p.ProductId == a.Id).Select(i=> new ProductsImagesVms { 
                            Id = i.Id,
                            Url = i.Image,
                        }).ToList(),
                    }).ToList()
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ResponseDto AddOrUpdateCategory(CategoryAddVms modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            if (modal.catId == null)
            {
                var branch = db.Branches.Find(modal.BranchId);
                if(branch == null)
                {
                    return JsonResponse2(400, "branch not found", null);
                }
                Categories entity = new Categories
                {
                    CreatedAt = currentTime,
                    UpdatedAt = currentTime,
                    Name = modal.Name,
                    BranchId = branch.Id,
                    Status = EntityStatus.Active,
                };
                db.Categories.Add(entity);
                db.SaveChanges();
            }
            else
            {
                var entity = db.Categories.Find(modal.catId);
                entity.Name = modal.Name;
                entity.UpdatedAt = currentTime;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            return JsonResponse2(200, "success", null);
        }
        public ResponseDto BlockCategory(int Id)
        {
            try
            {
                var entity = db.Categories.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Blocked;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UnBlockCategory(int Id)
        {
            try
            {
                var entity = db.Categories.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Active;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteCategory(int Id)
        {
            try
            {
                var entity = db.Categories.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "group not found", null);
                }
                else
                {
                    db.Categories.Remove(entity);
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public contentVms GetAboutUs()
        {
            var contactus = db.ContentSettings.Where(p => p.contentType == ContentType.AboutUs).Select(n => new contentVms
            {
                content = n.content,
                title = n.title,
            }).FirstOrDefault();
            return contactus;
        }
        public contentVms GetAboutApp()
        {
            var contactus = db.ContentSettings.Where(p => p.contentType == ContentType.AboutApp).Select(n => new contentVms
            {
                content = n.content,
                title = n.title,
            }).FirstOrDefault();
            return contactus;
        }
        public contentVms GetPrivacyPolicy()
        {
            var contentVms = db.ContentSettings.Where(p => p.contentType == ContentType.PrivacyPolicy).Select(n => new contentVms
            {
                content = n.content,
                title = n.title,
            }).FirstOrDefault();
            return contentVms;
        }
        public contentVms GetCookiePolicy()
        {
            var contactus = db.ContentSettings.Where(p => p.contentType == ContentType.CookiePolicy).Select(n => new contentVms
            {
                content = n.content,
                title = n.title,
            }).FirstOrDefault();
            return contactus;
        }
        public ResponseDto UpdatePrivacyPolicy(contentVms modal)
        {
            if (modal.content == "" || modal.title == "")
            {
                return JsonResponse2(400, "content cannot be empty", null);
            }
            else
            {
                var content = db.ContentSettings.Where(p => p.contentType == ContentType.PrivacyPolicy).FirstOrDefault();
                if (content == null)
                {
                    ContentSettings contentSettings = new ContentSettings
                    {
                        CreatedAt = currentTime,
                        UpdatedAt = currentTime,
                        content = modal.content,
                        title = modal.title,
                        contentType = ContentType.PrivacyPolicy,
                    };
                    db.ContentSettings.Add(contentSettings);
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
                else
                {
                    content.content = modal.content;
                    content.title = modal.title;
                    db.Entry(content).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
            }
        }
        public ResponseDto UpdateCookiePolicy(contentVms modal)
        {
            if(modal.content == "" || modal.title == "")
            {
                return JsonResponse2(400, "content cannot be empty", null);
            }
            else
            {
                var content = db.ContentSettings.Where(p => p.contentType == ContentType.CookiePolicy).FirstOrDefault();
                if(content == null)
                {
                    ContentSettings contentSettings = new ContentSettings
                    {
                        CreatedAt = currentTime,
                        UpdatedAt = currentTime,
                        content = modal.content,
                        title = modal.title,
                        contentType = ContentType.CookiePolicy,
                    };
                    db.ContentSettings.Add(contentSettings);
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
                else
                {
                    content.content = modal.content;
                    content.title = modal.title;
                    db.Entry(content).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
            }
        }
        public ResponseDto UpdateAboutApp(contentVms modal)
        {
            if (modal.content == "" || modal.title == "")
            {
                return JsonResponse2(400, "content cannot be empty", null);
            }
            else
            {
                var content = db.ContentSettings.Where(p => p.contentType == ContentType.AboutApp).FirstOrDefault();
                if (content == null)
                {
                    ContentSettings contentSettings = new ContentSettings
                    {
                        CreatedAt = currentTime,
                        UpdatedAt = currentTime,
                        content = modal.content,
                        title = modal.title,
                        contentType = ContentType.AboutApp,
                    };
                    db.ContentSettings.Add(contentSettings);
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
                else
                {
                    content.content = modal.content;
                    content.title = modal.title;
                    db.Entry(content).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
            }
        }
        public ResponseDto UpdateAboutUs(contentVms modal)
        {
            if (modal.content == "" || modal.title == "")
            {
                return JsonResponse2(400, "content cannot be empty", null);
            }
            else
            {
                var content = db.ContentSettings.Where(p => p.contentType == ContentType.AboutUs).FirstOrDefault();
                if (content == null)
                {
                    ContentSettings contentSettings = new ContentSettings
                    {
                        CreatedAt = currentTime,
                        UpdatedAt = currentTime,
                        content = modal.content,
                        title = modal.title,
                        contentType = ContentType.AboutUs,
                    };
                    db.ContentSettings.Add(contentSettings);
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
                else
                {
                    content.content = modal.content;
                    content.title = modal.title;
                    db.Entry(content).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "content saved properly", null);
                }
            }
        }
        public ApplicationUser getLoginUser(string Id)
        {
            if (Id != null)
            {
                ApplicationUser LoginUser = db.Users.Find(Id);
                return LoginUser;
            }
            return null;
        }
        async Task<ResponseDto> IAdminService.Login(LoginViewModel LoginUser)
        {
            try
            {
                if (LoginUser.Email == null)
                {
                    return JsonResponse2(400, "Email is required!", null);
                }
                //Check Validations
                if (!ModelState.IsValid)
                {
                    var message = string.Join(" | ", ModelState.Values
                                    .SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage));
                    return JsonResponse2(400, message, null);
                }
                var RequestedUser = db.Users.Where(usr => usr.Email == LoginUser.Email).FirstOrDefault();
                if (RequestedUser != null)
                {
                    var result = await signInManager.PasswordSignInAsync(RequestedUser.UserName, LoginUser.Password, false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        var user = db.Users.Where(p => p.Email == LoginUser.Email).FirstOrDefault();

                        var ident = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("Id", RequestedUser.Id)
                        });
                        if (user.Type == UserType.SuperAdmin)
                        {
                            return JsonResponse2(201, "success", null);
                        }
                        else if (user.Type == UserType.Receptionist)
                        {
                            return JsonResponse2(202, "success", null);
                        }
                        else if (user.Type == UserType.Cook)
                        {
                            return JsonResponse2(203, "success", null);
                        }
                        else if (user.Type == UserType.Packer)
                        {
                            return JsonResponse2(204, "success", null);
                        }
                        else if (user.Type == UserType.Driver)
                        {
                            return JsonResponse2(205, "success", null);
                        }
                        else if (user.Type == UserType.User)
                        {
                            return JsonResponse2(206, "success", null);
                        }
                        else
                        {
                            return JsonResponse2(400, "Not allowed to sign in admin panel", null);
                        }
                    }
                    else
                    {
                        return JsonResponse2(400, "invalid password", null);
                    }
                }
                else
                {
                    return JsonResponse2(400, "Invalid user email or username!", null);
                }
            }
            catch (Exception ex)
            {
                return JsonResponse2(501, ex.GetBaseException().Message, null);
            }
        }
        async Task<ResponseDto> IAdminService.Register(LoginViewModel LoginUser)
        {
            try
            {
                if (LoginUser.Email == null)
                {
                    return JsonResponse2(400, "Email is required!", null);
                }
                //Check Validations
                if (!ModelState.IsValid)
                {
                    var message = string.Join(" | ", ModelState.Values
                                    .SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage));
                    return JsonResponse2(400, message, null);
                }
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Status = UserStatus.Active,
                    CreatedAt = currentTime,
                    Email = LoginUser.Email,
                    FullName = LoginUser.Name,
                    Type = UserType.User,
                    RegisteredAt = currentTime,
                    UserName = LoginUser.Username,
                    UpdatedAt = currentTime,
                    ProfileImageUrl = "default-user-icon-4.jpg",
                };
                var result = await userManager.CreateAsync(applicationUser, LoginUser.Password);
                if (result.Succeeded)
                {
                    return JsonResponse2(200, "Sucess! Account registered with " + applicationUser.Email + "!", null);
                }
                else
                {
                    List<string> errorList = new List<string>();
                    foreach (var error in result.Errors)
                    {
                        errorList.Add(error.Description);
                    }
                    return JsonResponse2(402, "Validation Error", errorList);
                }
            }
            catch (Exception ex)
            {
                return JsonResponse2(501, ex.GetBaseException().Message, null);
            }
        }
        public ApplicationUser UpdateProfileImage(string ImageUrl, string Id)
        {
            ApplicationUser LoginUser = db.Users.Find(Id);
            LoginUser.ProfileImageUrl = ImageUrl;
            db.Entry(LoginUser).State = EntityState.Modified;
            db.SaveChanges();
            return LoginUser;
        }
        async Task<ResponseDto> IAdminService.Logout()
        {
            try
            {
                await signInManager.SignOutAsync();
                return JsonResponse2(200, "success", null);
            }
            catch (Exception ex)
            {
                return JsonResponse2(501, ex.GetBaseException().Message, null);
            }
        }
        public ApplicationUser UpdateProfile(string name, string Id)
        {
            ApplicationUser LoginUser = db.Users.Find(Id);
            LoginUser.FullName = name;
            db.Entry(LoginUser).State = EntityState.Modified;
            db.SaveChanges();
            return LoginUser;
        }
        async Task<ResponseDto> IAdminService.ChangePassword(UpdatePasswordVms model, string Id)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            try
            {
                var loginUser = db.Users.Find(Id);
                var result = await userManager.ChangePasswordAsync(loginUser, model.current_password, model.new_password);
                if (result.Succeeded)
                {
                    return JsonResponse2(200, "Success , Password Changed Successfully", null);
                }
                else
                {
                    List<string> errorList = new List<string>();
                    foreach (var error in result.Errors)
                    {
                        errorList.Add(error.Description);
                    }
                    return JsonResponse2(401, "Validation Error", errorList);
                }
            }
            catch (Exception ex)
            {
                return JsonResponse2(501, ex.GetBaseException().Message, null);
            }
        }
        public ResponseDto BlockUser(string Id)
        {
            try
            {
                var entity = db.Users.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = UserStatus.Blocked;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    var title = "You are blocked";
                    var message = "Due to some reasons we have blocked your account.";
                    try
                    {
                        if (entity.FcmToken != "" && entity.FcmToken != null)
                        {
                            var sendNotification = SendMessageToClient(entity.FcmToken, message, title);
                        }
                    }
                    catch
                    {

                    }
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteUser(string Id)
        {
            try
            {
                var entity = db.Users.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    db.Users.Remove(entity);
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UnBlockUser(string Id)
        {
            try
            {
                var entity = db.Users.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = UserStatus.Active;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    var title = "You are unblocked";
                    var message = "Congratulations! Our admin team has decided to unblock your account.";
                    try
                    {
                        if (entity.FcmToken != "" && entity.FcmToken != null)
                        {
                            var sendNotification = SendMessageToClient(entity.FcmToken, message, title);
                        }
                    }
                    catch
                    {

                    }
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto LeftUser(string Id)
        {
            try
            {
                var entity = db.Users.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = UserStatus.Left;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    var title = "You are fired";
                    var message = "Oops! Our admin team has decided to fire you.";
                    try
                    {
                        if (entity.FcmToken != "" && entity.FcmToken != null)
                        {
                            var sendNotification = SendMessageToClient(entity.FcmToken, message, title);
                        }
                    }
                    catch
                    {

                    }
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto BlockBranch(int Id)
        {
            try
            {
                var entity = db.Branches.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Blocked;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UnBlockBranch(int Id)
        {
            try
            {
                var entity = db.Branches.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Active;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public List<BranchVms> GetBranches()
        {
            try
            {
                var entities = db.Branches.AsEnumerable().Select(n => new BranchVms
                {
                    CreatedAt = n.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                    UpdatedAt = n.UpdatedAt != null ? n.UpdatedAt.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") : "-",
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Address = n.Address,
                    Description = n.Description,
                    Email = n.Email,
                    Image = n.Image,
                    Latitude = n.Latitude,
                    Longitude = n.Longitude,
                    Phone = n.Phone,
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ResponseDto AddBranch(BranchAddVms modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            if (modal.branchId == null)
            {
                
                Branch entity = new Branch
                {
                    CreatedAt = currentTime,
                    UpdatedAt = currentTime,
                    Name = modal.Name,
                    Status = EntityStatus.Active,
                    Address = modal.Address,
                    Description = modal.Description,
                    Email= modal.Email,
                    Image = modal.ImageUrl,
                    Latitude = modal.Latitude,
                    Longitude = modal.Longitude,
                    Phone = modal.Phone,
                };
                db.Branches.Add(entity);
                db.SaveChanges();
            }
            else
            {
                var entity = db.Branches.Find(modal.branchId);
                entity.Name = modal.Name;
                entity.Latitude = modal.Latitude;
                entity.Longitude = modal.Longitude;
                entity.Description = modal.Description;
                entity.Phone = modal.Phone;
                entity.Email = modal.Email;
                entity.Image = modal.ImageUrl !=""?modal.ImageUrl:entity.Image;
                entity.Address = modal.Address;
                entity.UpdatedAt = currentTime;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
            return JsonResponse2(200, "success", null);
        }
        async public Task<ResponseDto> AddStaff(AddStaffDtos modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));
                return JsonResponse2(400, message, null);
            }
            try
            {
                var EmailRegistered = db.Users.Where(u => u.Email == modal.Email).FirstOrDefault();
                if (EmailRegistered != null)
                {
                    return JsonResponse2(401, "Email already registered!", null);
                }
                var imageUrl = "";
                var branch = db.Branches.Find(modal.BranchId);
                if (branch == null)
                {
                    return JsonResponse2(401, "Branch is not found!", null);
                }
                ApplicationUser newUser = new ApplicationUser
                {
                    Email = modal.Email,
                    UserName = modal.Email,
                    RegisteredAt = currentTime,
                    FullName = modal.FullName,
                    PhoneNumber = modal.Phone,
                    CreatedAt = currentTime,
                    JoiningDate = modal.JoiningDate,
                    Gender = modal.Gender,
                    ExternalType = LoginProvider.WithEmail,
                    Status = UserStatus.Active,
                    Type = modal.Role,
                    ProfileImageUrl = modal.ImageUrl,
                    BranchId = branch.Id,
                    UpdatedAt = currentTime,
                };
                var result = await userManager.CreateAsync(newUser,modal.Password);
                if (result.Succeeded)
                {
                    var role = "";
                    if (modal.Role == UserType.Receptionist)
                    {
                        role = nameof(UserType.Receptionist);
                    }
                    if (modal.Role == UserType.Cook)
                    {
                        role = nameof(UserType.Cook);
                    }
                    if (modal.Role == UserType.Packer)
                    {
                        role = nameof(UserType.Packer);
                    }
                    if (modal.Role == UserType.Driver)
                    {
                        role = nameof(UserType.Driver);
                    }
                    if (await roleManager.RoleExistsAsync(role))
                    {
                        await userManager.AddToRoleAsync(newUser, role);
                        return JsonResponse2(200, "success", null);
                    }
                    else
                    {
                        IdentityRole identityRole = new IdentityRole();
                        identityRole.Name = role;
                        await roleManager.CreateAsync(identityRole);
                        await userManager.AddToRoleAsync(newUser, role);
                        return JsonResponse2(200, "success", null);
                    }
                }
                else
                {
                    return JsonResponse2(400, "error", result);
                }
            }
            catch (Exception ex)
            {
                return JsonResponse2(504, ex.Message, null);
            }
        }
        public List<ProductDtos> GetProducts()
        {
            try
            {
                var entities = db.Products.Select(n => new ProductDtos
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Description = n.Description,
                    ImageUrls = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(p => p.Image).ToList(),
                    ProductsImages = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(n => new ProductsImagesVms
                    {
                        Id = n.Id,
                        Url = n.Image,
                    }).ToList(),
                    Logo = n.Logo,
                    Price = n.Price,
                    CategoryId = n.CategoryId,
                    BranchId = n.CategoriesObject.BranchId,
                    BranchName = n.CategoriesObject.BranchesObject.Name,
                    CategoryName = n.CategoriesObject.Name,
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public List<ProductDtos> GetStaffProducts(string userId)
        {
            try
            {
                var staff = db.Users.Find(userId);
                var branch = db.Branches.Find(staff.BranchId);
                var entities = db.Products.Where(p=>p.CategoriesObject.BranchId == branch.Id).Select(n => new ProductDtos
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Description = n.Description,
                    ImageUrls = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(p => p.Image).ToList(),
                    ProductsImages = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(n => new ProductsImagesVms
                    {
                        Id = n.Id,
                        Url = n.Image,
                    }).ToList(),
                    Logo = n.Logo,
                    Price = n.Price,
                    CategoryId = n.CategoryId,
                    BranchId = n.CategoriesObject.BranchId,
                    BranchName = n.CategoriesObject.BranchesObject.Name,
                    CategoryName = n.CategoriesObject.Name,
                }); ;
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ProductAndIngredientDtos ProductDetail(int Id, string BranchName, string CategoryName,string userId)
        {
            try
            {
                var n = db.Products.Find(Id);
                
                var category = db.Categories.Find(n.CategoryId);
                var branch = db.Branches.Find(category.BranchId);
                if(category.Name != CategoryName || branch.Name != BranchName)
                {
                    throw new ValidationException("Oops we are unable to match your search");
                }
                ProductAndIngredientDtos productDtos = new ProductAndIngredientDtos
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Description = n.Description,
                    ImageUrls = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(p => p.Image).ToList(),
                    ProductsImages = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(a => new ProductsImagesVms
                    {
                        Id = a.Id,
                        Url = a.Image,
                    }).ToList(),
                    Logo = n.Logo,
                    Price = n.Price,
                    CategoryId = n.CategoryId,
                    BranchId = category.BranchId,
                    AddedToCart = db.Carts.Where(p=>p.ProductId == n.Id && p.Status == CartStatus.Active && p.UserId == userId).Any(),
                    BranchName = branch.Name,
                    CategoryName = category.Name,
                    IngredientLists = db.Ingredients.Where(p => p.ProductId == n.Id || p.CategoryId == category.Id).Select(i => new IngredientListVms
                    {
                        Id = i.Id,
                        CreatedAt = i.CreatedAt.ToShortDateString(),
                        Status = i.Status,
                        Name = i.Name,
                        Price = i.Price,
                    }).ToList(),
                };
                return productDtos;
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ResponseDto AddProducts(ProductDtos modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            if (modal.ProductId == null)
            {

                Products entity = new Products
                {
                    CreatedAt = currentTime,
                    UpdatedAt = currentTime,
                    Name = modal.Name,
                    Status = EntityStatus.Active,
                    Description = modal.Description,
                    CategoryId = modal.CategoryId,
                    Logo = modal.Logo,
                    Price = modal.Price,
                };
                db.Products.Add(entity);
                foreach(var i in modal.ImageUrls)
                {
                    ProductsImages productsImages = new ProductsImages
                    {
                        Status = EntityStatus.Active,
                        CreatedAt = currentTime,
                        Image = i,
                        UpdatedAt = currentTime,
                        ProductsObject = entity,
                    };
                    db.ProductsImages.Add(productsImages);
                }
                db.SaveChanges();
            }
            else
            {
                var entity = db.Products.Find(modal.ProductId);
                entity.Name = modal.Name;
                entity.Description = modal.Description;
                entity.Price = modal.Price;
                entity.Logo = modal.Logo != "" ? modal.Logo : entity.Logo;
                entity.UpdatedAt = currentTime;
                db.Entry(entity).State = EntityState.Modified;

                foreach (var i in modal.ImageUrls)
                {
                    ProductsImages productsImages = new ProductsImages
                    {
                        Status = EntityStatus.Active,
                        CreatedAt = currentTime,
                        Image = i,
                        UpdatedAt = currentTime,
                        ProductsObject = entity,
                    };
                    db.ProductsImages.Add(productsImages);
                }
                db.SaveChanges();
            }
            return JsonResponse2(200, "success", null);
        }
        public ResponseDto BlockProduct(int Id)
        {
            try
            {
                var entity = db.Products.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Blocked;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UnBlockProduct(int Id)
        {
            try
            {
                var entity = db.Products.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Active;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteProduct(int Id)
        {
            try
            {
                var entity = db.Products.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    db.Products.Remove(entity);
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteProductImage(int Id)
        {
            try
            {
                var entity = db.ProductsImages.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    db.ProductsImages.Remove(entity);
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto AddIngredients(IngredientAddVms modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            foreach(var i in modal.Items)
            {
                var cat = db.Categories.Find(modal.CategoryId);
                if (cat == null)
                {
                    return JsonResponse2(400, "category not found", null);
                }
                var product = modal.ProductId == null;
                Ingredients ingredients = new Ingredients
                {
                    CreatedAt =currentTime,
                    Status = EntityStatus.Active,
                    CategoryId = modal.CategoryId,
                    Name = i.Name,
                    Price = i.Price,
                    ProductId = modal.ProductId,
                    Type = product != true ?IngredientType.CategoryType:IngredientType.ProductType,
                    UpdatedAt = currentTime,
                };
                db.Ingredients.Add(ingredients);
            }
            db.SaveChanges();
            return JsonResponse2(200, "success", null);
        }
        public List<IngredientListVms> GetIngredient()
        {
            try
            {
                var entities = db.Ingredients.Select(n => new IngredientListVms
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Price = n.Price,
                    BranchId = n.CategoriesObject.BranchId,
                    CategoryId = (int)n.CategoryId,
                    ProductId = n.ProductId,
                    BranchName = n.CategoriesObject.BranchesObject.Name,
                    CategoryName = n.CategoriesObject.Name,
                    ProductName = n.ProductId !=null?n.ProductsObject.Name:"-",
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public List<IngredientListVms> GetStaffIngredient(string userId)
        {
            try
            {
                var staff = db.Users.Find(userId);
                var branch = db.Branches.Find(staff.BranchId);
                var entities = db.Ingredients.Where(p => p.Status == EntityStatus.Active && p.CategoriesObject.BranchId == branch.Id).Select(n => new IngredientListVms
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    Name = n.Name,
                    Status = n.Status,
                    Id = n.Id,
                    Price = n.Price,
                    BranchId = n.CategoriesObject.BranchId,
                    CategoryId = (int)n.CategoryId,
                    ProductId = n.ProductId,
                    BranchName = n.CategoriesObject.BranchesObject.Name,
                    CategoryName = n.CategoriesObject.Name,
                    ProductName = n.ProductId != null ? n.ProductsObject.Name : "-",
                });
                return entities.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ResponseDto BlockIngredient(int Id)
        {
            try
            {
                var entity = db.Ingredients.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Blocked;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UnBlockIngredient(int Id)
        {
            try
            {
                var entity = db.Ingredients.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    entity.Status = EntityStatus.Active;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteIngredient(int Id)
        {
            try
            {
                var entity = db.Ingredients.Find(Id);
                if (entity == null)
                {
                    return JsonResponse2(400, "entity not found", null);
                }
                else
                {
                    db.Ingredients.Remove(entity);
                    db.SaveChanges();
                    return JsonResponse2(200, "success", null);
                }
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto UpdateIngredient(IngredientListVms modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                return JsonResponse2(400, message, null);
            }
            var entity = db.Ingredients.Find(modal.Id);
            entity.Name = modal.Name;
            entity.Price = modal.Price;
            entity.UpdatedAt = currentTime;
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
            return JsonResponse2(200, "success", null);
        }
        public List<contactUs> GetContactUs()
        {
            try
            {
                var contactUs = db.ContactUs.OrderByDescending(p => p.CreatedAt).Select(n => new contactUs
                {
                    Id = n.Id,
                    Status = n.Status,
                    review = n.Review,
                    userEmail = n.UserObject.Email,
                    userImage = n.UserObject.ProfileImageUrl,
                    subject = n.Subject,
                    userName = n.UserObject.FullName,
                    createdAt = n.CreatedAt.ToShortDateString(),
                });
                return contactUs.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }
        public ResponseDto ResolveQuery(int Id)
        {
            try
            {
                var query = db.ContactUs.Find(Id);
                if (query == null)
                {
                    return JsonResponse2(400, "query not found", null);
                }
                query.Status = QueryStatus.Resolved;
                db.Entry(query).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            catch (Exception ex)
            {
                return JsonResponse2(504, ex.Message, null);
            }
        }
        public ResponseDto UpdateFcm(string Fcm, string Id)
        {
            try
            {
                var loginUser = db.Users.Find(Id);
                if (loginUser == null)
                {
                    return JsonResponse2(401, "This is a secure Api", null);
                }
                loginUser.FcmToken = Fcm;
                db.Entry(loginUser).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto GetNotifications(string Id)
        {
            try
            {
                var loginUser = db.Users.Find(Id);
                if (loginUser == null)
                {
                    return JsonResponse2(401, "This is a secure Api", null);
                }
                List<NotificationsVms> notification = new List<NotificationsVms>();
                var notifications = db.Notifications.Where(p => p.NotifyTo == loginUser.Id);
                foreach (var i in notifications)
                {
                    NotificationsVms notificationsVms = new NotificationsVms
                    {
                        Id = i.Id,
                        CreatedAt = i.CreatedAt.ToString(),
                        Body = i.Body,
                        IsSeen = i.IsSeen,
                        NotifyByEmail = i.NotifyByObject.Email,
                        NotifyById = i.NotifyTo,
                        NotifyByImage = i.NotifyByObject.ProfileImageUrl,
                        NotifyByUserName = i.NotifyByObject.UserName,
                        NotifyToEmail = i.NotitfyToObject.Email,
                        NotifyToId = i.NotifyTo,
                        NotifyToImage = i.NotitfyToObject.ProfileImageUrl,
                        NotifyToUserName = i.NotitfyToObject.UserName,
                        Title = i.Title,
                        Type = i.Type,
                    };
                    notification.Add(notificationsVms);
                }
                return JsonResponse2(200, "success", notification);
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto DeleteSingleNotification(int Id, string userId)
        {
            try
            {
                var loginUser = db.Users.Find(userId);
                if (loginUser == null)
                {
                    return JsonResponse2(401, "This is a secure Api", null);
                }
                ///
                var notificatonSingle = db.Notifications.Find(Id);
                db.Notifications.Remove(notificatonSingle);
                db.SaveChanges();
                List<NotificationsVms> notification = new List<NotificationsVms>();
                var notifications = db.Notifications.Where(p => p.NotifyTo == loginUser.Id);
                foreach (var i in notifications)
                {
                    NotificationsVms notificationsVms = new NotificationsVms
                    {
                        Id = i.Id,
                        CreatedAt = i.CreatedAt.ToLongDateString(),
                        Body = i.Body,
                        IsSeen = i.IsSeen,
                        NotifyByEmail = i.NotifyByObject.Email,
                        NotifyById = i.NotifyTo,
                        NotifyByImage = i.NotifyByObject.ProfileImageUrl,
                        NotifyByUserName = i.NotifyByObject.UserName,
                        NotifyToEmail = i.NotitfyToObject.Email,
                        NotifyToId = i.NotifyTo,
                        NotifyToImage = i.NotitfyToObject.ProfileImageUrl,
                        NotifyToUserName = i.NotitfyToObject.UserName,
                        Title = i.Title,
                        Type = i.Type,
                    };
                    notification.Add(notificationsVms);
                }
                return JsonResponse2(200, "success", notification);
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto ReadSingleNotification(int Id, string userId)
        {
            try
            {
                var loginUser = db.Users.Find(userId);
                if (loginUser == null)
                {
                    return JsonResponse2(401, "This is a secure Api", null);
                }
                ///
                var notificatonSingle = db.Notifications.Find(Id);
                notificatonSingle.IsSeen = true;
                db.Entry(notificatonSingle).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public ResponseDto GetAndReadAllNotifications(string userId)
        {
            try
            {
                var loginUser = db.Users.Find(userId);
                if (loginUser == null)
                {
                    return JsonResponse2(401, "This is a secure Api", null);
                }
                ///
                List<NotificationsVms> notification = new List<NotificationsVms>();
                var notifications = db.Notifications.Where(p => p.NotifyTo == loginUser.Id);
                foreach (var i in notifications)
                {
                    if (i.IsSeen == false)
                    {
                        i.IsSeen = true;
                        db.Entry(i).State = EntityState.Modified;
                    }
                    NotificationsVms notificationsVms = new NotificationsVms
                    {
                        Id = i.Id,
                        CreatedAt = i.CreatedAt.ToLongDateString(),
                        Body = i.Body,
                        IsSeen = i.IsSeen,
                        NotifyByEmail = i.NotifyByObject.Email,
                        NotifyById = i.NotifyTo,
                        NotifyByImage = i.NotifyByObject.ProfileImageUrl,
                        NotifyByUserName = i.NotifyByObject.UserName,
                        NotifyToEmail = i.NotitfyToObject.Email,
                        NotifyToId = i.NotifyTo,
                        NotifyToImage = i.NotitfyToObject.ProfileImageUrl,
                        NotifyToUserName = i.NotitfyToObject.UserName,
                        Title = i.Title,
                        Type = i.Type,
                    };
                    notification.Add(notificationsVms);
                }
                db.SaveChanges();
                return JsonResponse2(200, "success", notification);
            }
            catch (Exception es)
            {
                return JsonResponse2(504, es.GetBaseException().Message, null);
            }
        }
        public AppInfoVms GetAppInfo()
        {
            var info2 = db.AppInfos.FirstOrDefault();
            if(info2 != null)
            {
                var info = db.AppInfos.FirstOrDefault();
                AppInfoVms appInfoVms2 = new AppInfoVms
                {
                    FacebookUrl = info.FacebookUrl,
                    GoogleUrl = info.GoogleUrl,
                    InstagramUrl = info.InstagramUrl,
                    TwitterUrl = info.TwitterUrl,
                    YoutubeUrl = info.YoutubeUrl,
                    Email = info.Email,
                    Address = info.Address,
                    ServiceCharges = info.ServiceCharges,
                    DeliveryCharges = info.DeliveryCharges,
                    TelephoneNumber = info.TelephoneNumber,
                };
                return appInfoVms2;
            }
            AppInfo appInfoVms = new AppInfo
            {
                FacebookUrl = "facebook.com",
                GoogleUrl = "google.com",
                InstagramUrl = "instagram.com",
                TwitterUrl = "twitter.com",
                YoutubeUrl = "youtube.com",
                Email = "piano.com",
                Address = "USA",
                ServiceCharges = 12.22m,
                DeliveryCharges = 12.23m,
                TelephoneNumber = "+924234234324",
            };
            db.AppInfos.Add(appInfoVms);
            db.SaveChanges();
            AppInfoVms appInfoVms3 = new AppInfoVms();
            return appInfoVms3;
        }
        public ResponseDto SaveAboutAppInfo(aboutappVms modal)
        {
            var info = db.AppInfos.FirstOrDefault();
            info.UpdatedAt = currentTime;
            info.GoogleUrl = modal.google_link;
            info.InstagramUrl = modal.instagram_link;
            info.FacebookUrl = modal.facebook_link;
            info.TwitterUrl = modal.twitter_link;
            info.Email = modal.email;
            info.TelephoneNumber = modal.telephone;
            info.ServiceCharges = modal.services_modal;
            info.DeliveryCharges = modal.delivery_modal;
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
            return JsonResponse2(200, "success", null);
        }
        public ResponseDto SaveOrder(SaveOrderData modal, string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var doc_id = unixTimestamp.ToString();

            var freeCook = db.Users.Where(p => p.Type == UserType.Cook && p.Status == UserStatus.Active && p.BranchId == branch.Id).Select(p=>p.Id).AsEnumerable();
            var s = db.AssigneesLists.Where(p => p.OrderObject.Status == OrderStatus.Cooking && p.OrderObject.BranchId == branch.Id).Select(p => p.UserId).AsEnumerable();
            var d = freeCook.Except(s);
            string CookDefault = null;
            var type = OrderStatus.Waiting;
            if (d.Count() > 0)
            {
                CookDefault = d.FirstOrDefault();
                type = OrderStatus.Cooking;
            }
            else if(freeCook.Count() > 0)
            {
                CookDefault = freeCook.FirstOrDefault();
                type = OrderStatus.Cooking;
            }
            decimal latitude = 0;
            decimal longitude = 0;
            if (modal.orderType == OrderType.Delivery)
            {
                latitude = modal.latitude;
                longitude = modal.longitude;
            }
            Orders orders = new Orders
            {
                Status = type,
                Type = modal.orderType,
                BranchId = branch.Id,
                CreatedAt = currentTime,
                TotalPrice = modal.price,
                UpdatedAt = currentTime,
                OrderId = "PB-" + doc_id,
                AssigneeId = CookDefault,
                CreatedBy = userId,
                PhoneNumber = modal.customer_phone,
                UserEmail = modal.customer_email,
                Username = modal.customer_name,
                Latitude = latitude,
                Longitude = longitude,
            };
            db.Orders.Add(orders);
            if(CookDefault != null)
            {
                var Cook = db.Users.Find(CookDefault);
                AssigneesList assigneesList = new AssigneesList
                {
                    StartTime = currentTime,
                    Status = WorkerStatus.Waiting,
                    CreatedAt = currentTime,
                    EndTime = currentTime,
                    OrderObject = orders,
                    UpdatedAt = currentTime,
                    UserId = Cook.Id,
                };
                db.AssigneesLists.Add(assigneesList);
            }

            foreach (var i in modal.AllProducts)
            {
                Carts carts = new Carts
                {
                    Status = CartStatus.OrderConfirmed,
                    CreatedAt = currentTime,
                    Price = i.total_price,
                    ProductId = i.productId,
                    Quantity = i.quantity,
                    UpdatedAt = currentTime,
                    OrdersObject = orders,
                };
                db.Carts.Add(carts);
                foreach(var a in i.ingredientList)
                {
                    CartIngredients cartIngredients = new CartIngredients
                    {
                        Status = CartStatus.OrderConfirmed,
                        CartsObject = carts,
                        CreatedAt = currentTime,
                        IngredientId = a.Id,
                        Price = a.Price,
                        UpdatedAt = currentTime,
                        Quantity = a.quantity,
                    };
                    db.CartIngredients.Add(cartIngredients);
                }
            }
            db.SaveChanges();
            return JsonResponse2(200, "PB-" + doc_id, null);
        }
        public List<GetOrderdetails> GetOrderdetails(string userId)
        {
            var sab = db.AssigneesLists.AsEnumerable();
            foreach(var i in sab)
            {
                var s = i.OrderObject;

            };
            var staff = db.Users.Find(userId);
            if(staff.Type == UserType.SuperAdmin)
            {
                var entities = db.Orders.Select(n => new GetOrderdetails
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    OrderId = n.OrderId,
                    UpdatedAt = n.UpdatedAt.Value,
                    Status = n.Status,
                    Id = n.Id,
                    TotalPrice = n.TotalPrice,
                    BranchId = n.BranchId,
                    BranchName = n.BranchesObject.Name,
                    AssigneeId = n.AssigneeId,
                    AssigneeName = n.AssigneeId != null ? n.AssignedObject.Email : "",
                    PhoneNumber = n.PhoneNumber,
                    UserEmail = n.UserEmail,
                    UserId = n.UserId,
                    Username = n.Username,
                });
                return entities.ToList();
            }
            else
            {
                var branch = db.Branches.Find(staff.BranchId);
                var entities = db.Orders.Where(p => p.BranchId == branch.Id).Select(n => new GetOrderdetails
                {
                    CreatedAt = n.CreatedAt.ToShortDateString(),
                    OrderId = n.OrderId,
                    Status = n.Status,
                    Id = n.Id,
                    TotalPrice = n.TotalPrice,
                    BranchId = n.BranchId,
                    BranchName = branch.Name,
                    AssigneeId = n.AssigneeId,
                    AssigneeName = n.AssigneeId != null ? n.AssignedObject.Email : "",
                    PhoneNumber = n.PhoneNumber,
                    UserEmail = n.UserEmail,
                    UserId = n.UserId,
                    Username = n.Username,
                });
                return entities.ToList();
            }
        }
        public List<AllProducts> GetOrderProducts(int Id)
        {
            var order = db.Orders.Find(Id);
            var entities = db.Carts.Where(p => p.OrderId == order.Id).Select(n => new AllProducts
            {
                productId = n.ProductId,
                productImage = n.ProductsObject.Logo,
                productName = n.ProductsObject.Name,
                quantity = n.Quantity,
                total_price = n.Price,
                ingredientList = db.CartIngredients.Where(a=>a.CartId == n.Id).Select(m=>new ingredientList { 
                    Id = m.Id,
                    ingredientName = m.IngredientObject.Name,
                    Price = m.Price,
                    quantity = m.Quantity,
                }).ToList(),
            });
            return entities.ToList();
        }
        public GetStaffDashboardStats GetStaffOrderdetails(string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var entities = db.Orders.Where(p => p.BranchId == branch.Id && p.AssigneeId == userId).Select(n => new GetStaffOrderdetails
            {
                CreatedAt = n.CreatedAt.ToShortDateString(),
                OrderId = n.OrderId,
                Status = n.Status,
                Id = n.Id,
                TotalPrice = n.TotalPrice,
                BranchId = n.BranchId,
                BranchName = branch.Name,
                AssigneeId = n.AssigneeId,
                AssigneeName = n.AssigneeId != null ? n.AssignedObject.Email : "",
                PhoneNumber = n.PhoneNumber,
                UserEmail = n.UserEmail,
                UserId = n.UserId,
                Username = n.Username,
                Latitude = n.Latitude,
                Longitude = n.Longitude,
                Address = n.Address,
                StartTime = db.AssigneesLists.Where(p => p.OrderId == n.Id && p.UserId == n.AssigneeId).FirstOrDefault().StartTime,
                WorkerStatus = db.AssigneesLists.Where(p=>p.OrderId == n.Id && p.UserId == n.AssigneeId).FirstOrDefault().Status,
            });

            GetStaffDashboardStats getStaffDashboardStats = new GetStaffDashboardStats
            {
                OrderDetails = entities.ToList(),
                TotalOrders = db.AssigneesLists.Where(p=>p.UserId == userId).Count(),
                Completed = db.AssigneesLists.Where(p => p.UserId == userId && p.Status == WorkerStatus.Completed).Count(),
                InProcessOrder = db.AssigneesLists.Where(p => p.UserId == userId && p.Status == WorkerStatus.Waiting || p.Status == WorkerStatus.Working).Count(),
            };
            return getStaffDashboardStats;
        }
        public ResponseDto StartFirstOrder(string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var order = db.Orders.Where(p => p.AssigneeId == userId).FirstOrDefault();
            if(order != null)
            {
                var assigny = db.AssigneesLists.Where(p => p.OrderId == order.Id && p.Status == WorkerStatus.Waiting).FirstOrDefault();
                if(assigny == null)
                {
                    return JsonResponse2(400, "There are no orders in queue", null);
                }
                assigny.Status = WorkerStatus.Working;
                assigny.StartTime = currentTime;
                db.Entry(assigny).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success",null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public ResponseDto MarkOrderAsCooked(int orderId,string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                var freePacker = db.Users.Where(p => p.Type == UserType.Packer && p.Status == UserStatus.Active && p.BranchId == branch.Id).Select(p => p.Id).AsEnumerable();
                var s = db.AssigneesLists.Where(p => p.OrderObject.Status == OrderStatus.Packing && p.OrderObject.BranchId == branch.Id).Select(p => p.UserId).AsEnumerable();
                var d = freePacker.Except(s);
                string PackerDefault = null;
                var type = OrderStatus.ReadyForPacking;
                if (d.Count() > 0)
                {
                    PackerDefault = d.FirstOrDefault();
                    type = OrderStatus.Packing;
                }
                else if (freePacker.Count() > 0)
                {
                    PackerDefault = freePacker.FirstOrDefault();
                    type = OrderStatus.Packing;
                }
                order.Status = type;
                order.AssigneeId = PackerDefault;
                db.Entry(order).State = EntityState.Modified;
                var assign = db.AssigneesLists.Where(p => p.OrderId == orderId && p.UserId == userId).FirstOrDefault();
                assign.Status = WorkerStatus.Completed;
                assign.EndTime = currentTime;
                db.Entry(assign).State = EntityState.Modified;
                if(type == OrderStatus.Packing)
                {
                    AssigneesList assigneesList = new AssigneesList
                    {
                        StartTime = currentTime,
                        Status = WorkerStatus.Waiting,
                        CreatedAt = currentTime,
                        EndTime = currentTime,
                        OrderId = order.Id,
                        UpdatedAt = currentTime,
                        UserId = PackerDefault,
                    };
                    db.AssigneesLists.Add(assigneesList);
                }
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public ResponseDto MarkOrderAsPacked(int orderId, string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                if(order.Type == OrderType.Delivery)
                {
                    var freeDriver = db.Users.Where(p => p.Type == UserType.Driver && p.Status == UserStatus.Active && p.BranchId == branch.Id).Select(p => p.Id).AsEnumerable();
                    var s = db.AssigneesLists.Where(p => p.OrderObject.BranchId == branch.Id).Where(p => p.OrderObject.Status == OrderStatus.ReadyToDeliver || p.OrderObject.Status == OrderStatus.OnTheWay).Select(p => p.UserId).AsEnumerable();
                    var d = freeDriver.Except(s);
                    string DriverDefault = null;
                    var type = OrderStatus.ReadyToDeliver;
                    if (d.Count() > 0)
                    {
                        DriverDefault = d.FirstOrDefault();
                    }
                    order.Status = type;
                    order.AssigneeId = DriverDefault;
                    db.Entry(order).State = EntityState.Modified;
                    var assign = db.AssigneesLists.Where(p => p.OrderId == orderId && p.UserId == userId).FirstOrDefault();
                    assign.Status = WorkerStatus.Completed;
                    assign.EndTime = currentTime;
                    db.Entry(assign).State = EntityState.Modified;
                    if (DriverDefault != null)
                    {
                        AssigneesList assigneesList = new AssigneesList
                        {
                            StartTime = currentTime,
                            Status = WorkerStatus.Waiting,
                            CreatedAt = currentTime,
                            EndTime = currentTime,
                            OrderId = order.Id,
                            UpdatedAt = currentTime,
                            UserId = DriverDefault,
                        };
                        db.AssigneesLists.Add(assigneesList);
                    }
                    db.SaveChanges();
                }
                else
                {
                    order.Status = OrderStatus.Delivered;
                    order.AssigneeId = null;
                    order.UpdatedAt = currentTime;
                    db.Entry(order).State = EntityState.Modified;
                    var assign = db.AssigneesLists.Where(p => p.OrderId == orderId && p.UserId == userId).FirstOrDefault();
                    assign.Status = WorkerStatus.Completed;
                    assign.EndTime = currentTime;
                    db.Entry(assign).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return JsonResponse2(200, "success", null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public ResponseDto AssignPerson(int orderId, string userId)
        {
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                var user = db.Users.Find(userId);
                
                var type = order.Status;
                if(type == OrderStatus.Waiting || type == OrderStatus.Cooking)
                {
                    order.Status = OrderStatus.Cooking;
                }
                else if (type == OrderStatus.ReadyForPacking || type == OrderStatus.Packing)
                {
                    order.Status = OrderStatus.Packing;
                }

                else if (type == OrderStatus.ReadyToDeliver)
                {
                    order.Status = OrderStatus.ReadyToDeliver;
                }
                if(type == OrderStatus.Packing || type == OrderStatus.Cooking)
                {
                    var previosAssign = db.AssigneesLists.Where(p => p.OrderId == orderId && p.Status != WorkerStatus.Completed && (p.OrderObject.Status == OrderStatus.Cooking || p.OrderObject.Status == OrderStatus.Packing)).FirstOrDefault();
                    if(previosAssign != null)
                    {
                        previosAssign.Status = WorkerStatus.Completed;
                        previosAssign.EndTime = currentTime;
                        db.Entry(previosAssign).State = EntityState.Modified;
                    }
                } 

                order.AssigneeId = userId;
                db.Entry(order).State = EntityState.Modified;

                AssigneesList assigneesList = new AssigneesList
                {
                    StartTime = currentTime,
                    Status = WorkerStatus.Waiting,
                    CreatedAt = currentTime,
                    EndTime = currentTime,
                    OrderId = order.Id,
                    UpdatedAt = currentTime,
                    UserId = userId,
                };
                db.AssigneesLists.Add(assigneesList);

                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public List<GetOrderdetails> StaffCompletedOrders(string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var s = db.AssigneesLists.Where(p => p.Status == WorkerStatus.Completed && p.UserId == userId).AsEnumerable().Select(n => new GetOrderdetails
            {
                CreatedAt = db.Orders.Find(n.OrderId).CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                OrderId = db.Orders.Find(n.OrderId).OrderId,
                Status = db.Orders.Find(n.OrderId).Status,
                Id = db.Orders.Find(n.OrderId).Id,
                TotalPrice = db.Orders.Find(n.OrderId).TotalPrice,
                BranchId = db.Orders.Find(n.OrderId).BranchId,
                BranchName = branch.Name,
                PhoneNumber = db.Orders.Find(n.OrderId).PhoneNumber,
                UserEmail = db.Orders.Find(n.OrderId).UserEmail,
                UserId = db.Orders.Find(n.OrderId).UserId,
                Username = db.Orders.Find(n.OrderId).Username,
                ElaspedTime = (n.EndTime.Value - n.StartTime).Hours + ":" + (n.EndTime.Value - n.StartTime).Minutes + ":" + (n.EndTime.Value - n.StartTime).Seconds,
                StartTime = n.StartTime.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                EndTime = n.EndTime.Value.ToString("dd-MMM-yyyy hh:mm:ss tt"),
            });
            return s.ToList();
        }
        public ResponseDto StartDeliveringOrder(string userId,int orderId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                var assigny = db.AssigneesLists.Where(p => p.OrderId == order.Id && p.Status == WorkerStatus.Waiting).FirstOrDefault();
                if (assigny == null)
                {
                    return JsonResponse2(400, "There are no orders in queue", null);
                }
                assigny.Status = WorkerStatus.Working;
                assigny.StartTime = currentTime;
                db.Entry(assigny).State = EntityState.Modified;
                order.Status = OrderStatus.OnTheWay;
                order.UpdatedAt = currentTime;
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public ResponseDto MarkOrderAsDelivered(int orderId, string userId)
        {
            var staff = db.Users.Find(userId);
            var branch = db.Branches.Find(staff.BranchId);
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                order.Status = OrderStatus.Delivered;
                order.UpdatedAt = currentTime;
                order.AssigneeId = null;
                db.Entry(order).State = EntityState.Modified;
                var assign = db.AssigneesLists.Where(p => p.OrderId == orderId && p.UserId == userId).FirstOrDefault();
                assign.Status = WorkerStatus.Completed;
                assign.EndTime = currentTime;
                db.Entry(assign).State = EntityState.Modified;
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            else
            {
                return JsonResponse2(400, "There are no orders in queue", null);
            }
        }
        public List<StaffOrderReports> GetOrderStaffReports(int Id)
        {
            var order = db.Orders.Find(Id);
            var entities = db.AssigneesLists.Where(p => p.OrderId == order.Id && p.Status == WorkerStatus.Completed).AsEnumerable().Select(n => new StaffOrderReports
            {
                staffEmail = db.Users.Find(n.UserId).Email,
                staffImage = db.Users.Find(n.UserId).ProfileImageUrl,
                orderId = db.Orders.Find(n.OrderId).OrderId,
                minutesSpent = (n.EndTime.Value - n.StartTime).Hours + ":" + (n.EndTime.Value - n.StartTime).Minutes + ":" + (n.EndTime.Value - n.StartTime).Seconds,
                startTime = n.StartTime.ToString("dd-MMM-yyyy hh:mm:ss tt"),
                endTime = n.EndTime.Value.ToString("dd-MMM-yyyy hh:mm:ss tt"),
            });
            return entities.ToList();
        }

        ///////////////////// Customer Apis ///////////////////////
        ///
        public ResponseDto AddToCart(AddToCart modal, string userId)
        {
            var cartscheck = db.Carts.Where(p => p.Status == CartStatus.Active && p.UserId == userId);
            var product = db.Products.Find(modal.productId);
            if (cartscheck.Count() > 0)
            {
                var productA = db.Products.Find(cartscheck.FirstOrDefault().ProductId);
                var categoryA = db.Categories.Find(productA.CategoryId);
                var category = db.Categories.Find(product.CategoryId);
                if (categoryA.BranchId != category.BranchId)
                {
                    if(modal.BranchBool == false)
                    {
                        return JsonResponse2(401, "There are already products added in your cart from another branch. If you are willing to continue you previos cart will be removed", null);
                    }
                    else
                    {
                        var Ids = cartscheck.Select(p => p.Id);
                        var cartIngredients = db.CartIngredients.Where(p => Ids.Contains(p.CartId));
                        db.CartIngredients.RemoveRange(cartIngredients);
                        db.Carts.RemoveRange(cartscheck);
                    }
                }
            }
            
            var cartPrice = product.Price * modal.quantity;
            Carts carts = new Carts
            {
                Status = CartStatus.Active,
                CreatedAt = currentTime,
                Price = cartPrice,
                ProductId = product.Id,
                Quantity = modal.quantity,
                UpdatedAt = currentTime,
                UserId = userId,
            };
            db.Carts.Add(carts);
            foreach (var a in modal.AllIngredients)
            {
                var ingredient = db.Ingredients.Find(a.Id);
                var ingredientPrice = ingredient.Price * modal.quantity;
                CartIngredients cartIngredients = new CartIngredients
                {
                    Status = CartStatus.OrderConfirmed,
                    CartsObject = carts,
                    CreatedAt = currentTime,
                    IngredientId = ingredient.Id,
                    Price = ingredientPrice,
                    UpdatedAt = currentTime,
                    Quantity = a.quantity,
                    UserId = userId,
                };
                db.CartIngredients.Add(cartIngredients);
            }
            db.SaveChanges();
            return JsonResponse2(200, "success", null);
        }

        public List<MyCarts> MyCarts(string userId)
        {
            try
            {
                var n = db.Carts.Where(p=>p.Status == CartStatus.Active && p.UserId == userId).Select(n => new MyCarts {
                    Name = n.ProductsObject.Name,
                    Status = n.ProductsObject.Status,
                    Id = n.Id,
                    Description = n.ProductsObject.Description,
                    ImageUrls = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(p => p.Image).ToList(),
                    ProductsImages = db.ProductsImages.Where(p => p.ProductId == n.Id).Select(a => new ProductsImagesVms
                    {
                        Id = a.Id,
                        Url = a.Image,
                    }).ToList(),
                    Logo = n.ProductsObject.Logo,
                    Price = n.Price,
                    CategoryId = n.ProductsObject.CategoryId,
                    BranchId = n.ProductsObject.CategoriesObject.BranchId,
                    AddedToCart = db.Carts.Where(p => p.ProductId == n.Id && p.Status == CartStatus.Active && p.UserId == userId).Any(),
                    BranchName = n.ProductsObject.CategoriesObject.BranchesObject.Name,
                    CategoryName = n.ProductsObject.CategoriesObject.Name,
                    CartStatus = n.Status,
                    Quantity = n.Quantity,
                    IngredientLists = db.Ingredients.Where(p => p.CategoryId == n.ProductsObject.CategoryId).Select(i => new CartIngredientListVms
                    {
                        Id = i.Id,
                        Status = i.Status,
                        Name = i.Name,
                        AddedInCart = db.CartIngredients.Where(p => p.CartId == n.Id && p.IngredientId == i.Id).Any(),
                        Quantity = db.CartIngredients.Where(p => p.CartId == n.Id && p.IngredientId == i.Id).FirstOrDefault() != null ? db.CartIngredients.Where(p => p.CartId == n.Id && p.IngredientId == i.Id).FirstOrDefault().Quantity : 0,
                        Price = i.Price,
                    }).ToList()
                });
                return n.ToList();
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }

        public ResponseDto RemoveFromCart(int Id)
        {
            try
            {
                var cart = db.Carts.Find(Id);
                if (cart == null)
                {
                    return JsonResponse2(401, "Item removed from cart, Refresh you page to see updated cart", null);
                }
                var cartIngredients = db.CartIngredients.Where(p => p.CartId == cart.Id);
                db.CartIngredients.RemoveRange(cartIngredients.ToList());
                db.Carts.Remove(cart);
                db.SaveChanges();
                return JsonResponse2(200, "success", null);
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }

        public ResponseDto GetCart(int Id)
        {
            try
            {
                var cart = db.Carts.Find(Id);
                var cartIngredients = db.CartIngredients.Where(p => p.CartId == cart.Id);
                var product = db.Products.Find(cart.ProductId);
                ProductAndIngredientDtos2 dtos = new ProductAndIngredientDtos2
                {
                    Id = product.Id,
                    IngredientLists = db.Ingredients.Where(p => p.CategoryId == product.CategoryId).Select(i => new IngredientListVms2
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Quantity = db.CartIngredients.Where(p=>p.CartId == cart.Id && p.IngredientId == i.Id).FirstOrDefault() != null? db.CartIngredients.Where(p => p.CartId == cart.Id && p.IngredientId == i.Id).FirstOrDefault().Quantity:0,
                        Price = i.Price,
                    }).ToList(),
                    Price = product.Price,
                    Quantity = cart.Quantity,
                };
                return JsonResponse2(200, "success", dtos);
            }
            catch (Exception es)
            {
                throw new ValidationException(es.GetBaseException().Message);
            }
        }

        public ResponseDto UpdateCart(UpdateCart modal, string userId)
        {
            var cart = db.Carts.Find(modal.cartId);
            if(cart == null)
            {
                return JsonResponse2(401, "Item removed from cart, Refresh you page to see updated cart", null);
            }
            var product = db.Products.Find(cart.ProductId);
            cart.Price = product.Price * modal.quantity;
            cart.Quantity = modal.quantity;
            var cartIngredients = db.CartIngredients.Where(p => p.CartId == cart.Id);
            db.CartIngredients.RemoveRange(cartIngredients.ToList());
            db.Entry(cart).State = EntityState.Modified;

            foreach (var a in modal.AllIngredients)
            {
                var ingredient = db.Ingredients.Find(a.Id);
                var ingredientPrice = ingredient.Price * modal.quantity;
                CartIngredients cartIngredients2 = new CartIngredients
                {
                    Status = CartStatus.OrderConfirmed,
                    CreatedAt = currentTime,
                    IngredientId = ingredient.Id,
                    Price = ingredientPrice,
                    UpdatedAt = currentTime,
                    Quantity = a.quantity,
                    UserId = userId,
                    CartId = cart.Id,
                };
                db.CartIngredients.Add(cartIngredients2);
            }
            db.SaveChanges();
            return JsonResponse2(200, "success", null);
        }

        public ResponseDto SaveOrderCustomer(PlaceOrderCustomer modal, string userId)
        {
            var user = db.Users.Find(userId);

            var carts = db.Carts.Where(p => p.UserId == userId && p.Status == CartStatus.Active);
            var branchId = 0;
            if(carts.Count() > 0)
            {
                var firstcart = carts.FirstOrDefault();
                var product = db.Products.Find(firstcart.ProductId);
                var category = db.Categories.Find(product.CategoryId);
                branchId = category.BranchId;
            }
            else
            {
                return JsonResponse2(401,"error", null);
            }

            var branch = db.Branches.Find(branchId);
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var doc_id = unixTimestamp.ToString();

            var freeCook = db.Users.Where(p => p.Type == UserType.Cook && p.Status == UserStatus.Active && p.BranchId == branch.Id).Select(p => p.Id).AsEnumerable();
            var s = db.AssigneesLists.Where(p => p.OrderObject.Status == OrderStatus.Cooking && p.OrderObject.BranchId == branch.Id).Select(p => p.UserId).AsEnumerable();
            var d = freeCook.Except(s);
            string CookDefault = null;
            var type = OrderStatus.Waiting;
            if (d.Count() > 0)
            {
                CookDefault = d.FirstOrDefault();
                type = OrderStatus.Cooking;
            }
            else if (freeCook.Count() > 0)
            {
                CookDefault = freeCook.FirstOrDefault();
                type = OrderStatus.Cooking;
            }
            decimal latitude = 0;
            decimal longitude = 0;
            if (modal.orderType == OrderType.Delivery)
            {
                latitude = modal.latitude;
                longitude = modal.longitude;
            }
            var appInfo = db.AppInfos.FirstOrDefault();
            Orders orders = new Orders
            {
                Status = type,
                Type = modal.orderType,
                BranchId = branch.Id,
                CreatedAt = currentTime,
                SubTotal = modal.sub_total,
                TotalPrice = modal.amount,
                UpdatedAt = currentTime,
                OrderId = "PB-" + doc_id,
                AssigneeId = CookDefault,
                CreatedBy = userId,
                PhoneNumber = modal.customer_phone,
                UserEmail = modal.customer_email,
                Username = modal.customer_name,
                Latitude = latitude,
                Longitude = longitude,
                UserId = userId,
                DeliveryCharges = appInfo.DeliveryCharges,
                ServiceCharges = appInfo.ServiceCharges,
                Address = modal.customer_address,
                Note = modal.customer_note,
            };
            db.Orders.Add(orders);
            if (CookDefault != null)
            {
                var Cook = db.Users.Find(CookDefault);
                AssigneesList assigneesList = new AssigneesList
                {
                    StartTime = currentTime,
                    Status = WorkerStatus.Waiting,
                    CreatedAt = currentTime,
                    EndTime = currentTime,
                    OrderObject = orders,
                    UpdatedAt = currentTime,
                    UserId = Cook.Id,
                };
                db.AssigneesLists.Add(assigneesList);
            }

            carts.ToList().ForEach(s => s.Status = CartStatus.OrderConfirmed);
            carts.ToList().ForEach(s => s.OrdersObject = orders);
            carts.ToList().ForEach(s => db.Entry(s).State = EntityState.Modified);
            db.SaveChanges();
            return JsonResponse2(200, "PB-" + doc_id, null);
        }

        public List<GetOrderdetails> GetCurrentOrderdetails(string userId)
        {
            var entities = db.Orders.Where(p=>p.UserId == userId && p.Status != OrderStatus.Delivered).Select(n => new GetOrderdetails
            {
                CreatedAt = n.CreatedAt.ToShortDateString(),
                OrderId = n.OrderId,
                UpdatedAt = n.UpdatedAt.Value,
                Status = n.Status,
                Id = n.Id,
                TotalPrice = n.TotalPrice,
                BranchId = n.BranchId,
                SubTotal = n.SubTotal,
                BranchName = n.BranchesObject.Name,
                PhoneNumber = n.PhoneNumber,
                UserEmail = n.UserEmail,
                UserId = n.UserId,
                Username = n.Username,
            });
            return entities.ToList();
        }

        public GetSingleOrderdetails GetSingleOrderdetails(int orderId)
        {
            var n = db.Orders.Find(orderId);
            GetSingleOrderdetails getSingleOrderdetails = new GetSingleOrderdetails
            {
                CreatedAt = n.CreatedAt.ToShortDateString(),
                OrderId = n.OrderId,
                UpdatedAt = n.UpdatedAt.Value,
                Status = n.Status,
                Id = n.Id,
                Note = n.Note??"",
                TotalPrice = n.TotalPrice,
                BranchId = n.BranchId,
                Address = n.Address??"",
                PhoneNumber = n.PhoneNumber,
                SubTotal = n.SubTotal,
                UserEmail = n.UserEmail,
                UserId = n.UserId,
                DeliveryCharges = n.DeliveryCharges,
                Type = n.Type,
                ServiceCharges = n.ServiceCharges,
                Username = n.Username,
                AllProducts = db.Carts.Where(p => p.OrderId == orderId).Select(p => new AllProducts
                {
                    productId = p.ProductId,
                    productImage = p.ProductsObject.Logo,
                    productName = p.ProductsObject.Name,
                    quantity = p.Quantity,
                    total_price = p.Price,
                    ingredientList = db.CartIngredients.Where(a => a.CartId == p.Id).Select(m => new ingredientList
                    {
                        Id = m.Id,
                        ingredientName = m.IngredientObject.Name,
                        Price = m.Price,
                        quantity = m.Quantity,
                    }).ToList(),
                }).ToList(),
            };
            return getSingleOrderdetails;
        }

        public List<GetOrderdetails> GetOrderHistorydetails(string userId)
        {
            var entities = db.Orders.Where(p => p.UserId == userId).Where(p=> p.Status == OrderStatus.Delivered || p.Status == OrderStatus.Cancelled).Select(n => new GetOrderdetails
            {
                CreatedAt = n.CreatedAt.ToShortDateString(),
                OrderId = n.OrderId,
                UpdatedAt = n.UpdatedAt.Value,
                Status = n.Status,
                Id = n.Id,
                SubTotal = n.SubTotal,
                TotalPrice = n.TotalPrice,
                BranchId = n.BranchId,
                BranchName = n.BranchesObject.Name,
                PhoneNumber = n.PhoneNumber,
                UserEmail = n.UserEmail,
                UserId = n.UserId,
                Username = n.Username,
            });
            return entities.ToList();
        }
    }
}
