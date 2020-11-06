using EShopAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EShopAPI.DataSeeding
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            {
                //modelBuilder.Entity<AppConfig>().HasData(modelBuilder.Entity<AppConfig>().HasData(
                //   new AppConfig() { Key = "HomeTitle", Value = "This is Home Page of EShop WebSite" },
                //   new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword of  EShop WebSite" },
                //   new AppConfig() { Key = "HomeDescription", Value = "This is Description of  EShop WebSite" }
                //   ));

                //modelBuilder.Entity<Language>().HasData(modelBuilder.Entity<Language>().HasData(
                //     new Language() { LanguageId = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                //     new Language() { LanguageId = "en-US", Name = "English", IsDefault = false }
                // ));


                var roleId = "D9622B5E-5DA0-4F11-A63F-7B042BBCC924";
                var adminId = "EB178765-4E99-4856-A3EA-55BD3A9552A2";
                modelBuilder.Entity<AppRole>().HasData(new AppRole
                {
                    Id = roleId,
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Administrator Role"
                });

                var hasher = new PasswordHasher<AppUser>();
                modelBuilder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "khanggiavu250296@gmail.com",
                    NormalizedEmail = "khanggiavu250296@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "KhangVu2502!996"),
                    SecurityStamp = string.Empty,
                    FirstName = "Khang",
                    LastName = "Vu",
                    DoB = new DateTime(1996, 02, 25)
                });

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = adminId
                });
            }
        }
    }
}
