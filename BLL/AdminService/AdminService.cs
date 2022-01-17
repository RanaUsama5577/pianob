using DAL;
using DAL.Branches;
using DAL.Categories;
using DAL.Products;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        async public Task<ResponseDto> CreateAdmin()
        {
            try
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    Email = "superadmin@piano.com",
                    UserName = "superadmin@piano.com",
                    RegisteredAt = currentTime,
                    FullName = "Super Admin",
                    ExternalType = LoginProvider.WithEmail,
                    Status = UserStatus.Active,
                    Type = UserType.SuperAdmin,
                    ProfileImageUrl = "/user_icon.png",
                };
                var result = await userManager.CreateAsync(newUser, "1q2w3e4r");
                if (result.Succeeded)
                {
                    if (await roleManager.RoleExistsAsync("SuperAdmin"))
                    {
                        await userManager.AddToRoleAsync(newUser, "SuperAdmin");
                        return JsonResponse2(200, "success", null);
                    }
                    else
                    {
                        IdentityRole identityRole = new IdentityRole();
                        identityRole.Name = "SuperAdmin";
                        await roleManager.CreateAsync(identityRole);
                        await userManager.AddToRoleAsync(newUser, "SuperAdmin");
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
        public AdminDashboard DashboardStats()
        {
            AdminDashboard a = new AdminDashboard
            {
                TotalUsers = db.Users.Where(p => p.Status == UserStatus.Active && p.Type != UserType.SuperAdmin).Count(),
                TotalOrders = db.Orders.Where(p => p.Status != OrderType.Cancelled).Count(),
                TotalProducts = db.Products.Where(p => p.Status == EntityStatus.Active).Count(),
                TotalCategories = db.Categories.Where(p => p.Status == EntityStatus.Active).Count(),
            };
            return a;
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
            var contactus = db.ContentSettings.Where(p => p.contentType == ContentType.PrivacyPolicy).Select(n => new contentVms
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
        public ResponseDto UpdateTerms(contentVms modal)
        {
            if(modal.content == "" || modal.title == "")
            {
                return JsonResponse2(400, "content cannot be empty", null);
            }
            else
            {
                var content = db.ContentSettings.Where(p => p.contentType == ContentType.TermsAndConditions).FirstOrDefault();
                if(content == null)
                {
                    ContentSettings contentSettings = new ContentSettings
                    {
                        CreatedAt = currentTime,
                        UpdatedAt = currentTime,
                        content = modal.content,
                        title = modal.title,
                        contentType = ContentType.TermsAndConditions,
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
                var result = await userManager.CreateAsync(newUser, "1q2w3e4r");
                if (result.Succeeded)
                {
                    var role = nameof(modal.Role);
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
                }); ;
                return entities.ToList();
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
    }
}
