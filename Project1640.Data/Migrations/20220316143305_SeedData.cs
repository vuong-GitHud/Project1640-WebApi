using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1640.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("ad008a87-0adb-4d26-85ad-0aac4027be3b"), "df8ddb63-e92a-4bfb-bc67-d77fe4de0ca8", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ad008a87-0adb-4d26-85ad-0aac4027be3b"), new Guid("25b78b59-3bbe-4217-a9d9-0d945d692ac7") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("25b78b59-3bbe-4217-a9d9-0d945d692ac7"), 0, "e7662ca0-281a-4970-8b16-4e35c58faa4b", new DateTime(2000, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "thduc.2000@gmail.com", true, "DUC", "MALE", "TRUONG", false, null, "thduc.2000@gmail.com", "admin", "AQAAAAEAACcQAAAAEMf1BQdhgNjhqQCqf3khZwetM7A242hVh4pTrcpy41rZ2kPO8zBH6nu7h9DLXclgDA==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ad008a87-0adb-4d26-85ad-0aac4027be3b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ad008a87-0adb-4d26-85ad-0aac4027be3b"), new Guid("25b78b59-3bbe-4217-a9d9-0d945d692ac7") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25b78b59-3bbe-4217-a9d9-0d945d692ac7"));
        }
    }
}
