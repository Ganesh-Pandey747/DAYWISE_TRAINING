using System;
using Usermanagement1.Domain;
using Microsoft.EntityFrameworkCore;
namespace Usermanagement1.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
            modelBuilder.Entity<User>().HasData(new User{Id=123,UserName="sandeep",Password="test123",Email="sandeep@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",modifyDate= DateTime.UtcNow});
            modelBuilder.Entity<User>().HasData(new User{Id=163,UserName="sandeep karan",Password="test789",Email="sandeep23@gmail.com",AddedDate= DateTime.UtcNow,IPAddress="56678",modifyDate= DateTime.UtcNow});
        }
    }
}