using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project1640.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1640.Data.Seed
{
    public static class UserDefault
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var roleId = new Guid("AD008A87-0ADB-4D26-85AD-0AAC4027BE3B");  /*< [Guid("AD008A87-0ADB-4D26-85AD-0AAC4027BE3B")] >*/
            var adminId = new Guid("25B78B59-3BBE-4217-A9D9-0D945D692AC7");  /*< [Guid("25B78B59-3BBE-4217-A9D9-0D945D692AC7")] >*/
            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
            });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "thduc.2000@gmail.com",
                NormalizedEmail = "thduc.2000@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Duc@123"),
                SecurityStamp = string.Empty,
                FirstName = "DUC",
                LastName = "TRUONG",
                Gender = "MALE",
                DOB = new DateTime(2000, 06, 28)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}
