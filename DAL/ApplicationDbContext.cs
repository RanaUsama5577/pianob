using DAL.Branches;
using DAL.Products;
using DAL.Orders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<ContentSettings> ContentSettings { get; set; }
        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<Branches.Branch> Branches { get; set; }
        public DbSet<BranchImages>  BranchImages { get; set; }
        public DbSet<Categories.Categories> Categories { get; set; }
        public DbSet<Products.Products> Products { get; set; }
        public DbSet<ProductsImages> ProductsImages { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Orders.Orders> Orders { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartIngredients> CartIngredients { get; set; }
        public DbSet<AssigneesList> AssigneesLists { get; set; }
    }
}
