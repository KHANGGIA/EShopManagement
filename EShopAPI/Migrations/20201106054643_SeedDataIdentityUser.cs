using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopAPI.Migrations
{
    public partial class SeedDataIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "D9622B5E-5DA0-4F11-A63F-7B042BBCC924", "bae870b1-e1a4-45f0-a3c6-7fc6b32339ed", "Administrator Role", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "EB178765-4E99-4856-A3EA-55BD3A9552A2", "D9622B5E-5DA0-4F11-A63F-7B042BBCC924" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "EB178765-4E99-4856-A3EA-55BD3A9552A2", 0, "52a533b5-0341-47e2-bf56-0136704b9df5", new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "khanggiavu250296@gmail.com", true, "Khang", "Vu", false, null, "khanggiavu250296@gmail.com", "admin", "AQAAAAEAACcQAAAAEGtizi7B0XOUkItIMS0pYuR64lA+8n6cz6c7wFKeytxxGhRPm1b56BNrFJ2IWdOPOA==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "D9622B5E-5DA0-4F11-A63F-7B042BBCC924");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "EB178765-4E99-4856-A3EA-55BD3A9552A2", "D9622B5E-5DA0-4F11-A63F-7B042BBCC924" });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "EB178765-4E99-4856-A3EA-55BD3A9552A2");
        }
    }
}
