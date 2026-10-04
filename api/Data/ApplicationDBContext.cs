using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoffeeShop> CoffeeShops { get; set; }

        // DB population with dummy data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 001, Email = "emailniSeungmin@gmail.com", Address = "Korea", Password = "BiasKoSiSeungmin32", Username = "Seungmin" },
                new User { Id = 002, Email = "emailniIU@gmail.com", Address = "Korea", Password = "GandaMoIU", Username = "IU" },
                new User { Id = 003, Email = "emailniDO@gmail.com", Address = "Korea", Password = "KyungsooBliss", Username = "Kyungsoo" }
            );
        }
    }
}