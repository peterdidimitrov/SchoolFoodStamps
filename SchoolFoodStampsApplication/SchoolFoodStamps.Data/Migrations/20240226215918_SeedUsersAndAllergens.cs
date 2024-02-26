using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedUsersAndAllergens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Allergens",
                columns: new[] { "Id", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Gluten" },
                    { 2, null, "Dairy" },
                    { 3, null, "Eggs" },
                    { 4, null, "Fish" },
                    { 5, null, "Peanuts" },
                    { 6, null, "SeeFood" },
                    { 7, null, "Soy" },
                    { 8, null, "TreeNuts" },
                    { 9, null, "Wheat" },
                    { 10, null, "Celery" },
                    { 11, null, "Sulfites" },
                    { 12, null, "Lupin" },
                    { 13, null, "Sesame" },
                    { 14, null, "Mustard" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33f27dfc-bcc3-4b7d-bc9b-78a11f3e3719"), 0, "83bb98d3-07d8-4ea4-9047-27fbc6fc3309", "pesho@abv.bg", false, false, null, "PESHO@ABV.BG", "PESHO@ABV.BG", "UVXdgNN5xTguEUf/7T/qaW97rbFUMKcHoPFFwqTjKS0xqNky", null, false, "A768F82D-87A6-4360-8670-EB83DDBEC3ED", false, "pesho@abv.bg" },
                    { new Guid("ca4a635b-5974-428b-b661-c43491dc60e8"), 0, "cac5737a-8256-48c2-8437-4172c3f42e82", "test@test.bg", false, false, null, "TEST@TEST.BG", "TEST@TEST.BG", "LcSIrk8uu9FVBbkbxjD3Magy0riZz/RHaNrT/yhK0ukOfw+z", null, false, "6D05B818-009D-45C2-936C-39D3E904F18F", false, "test@test.bg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33f27dfc-bcc3-4b7d-bc9b-78a11f3e3719"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ca4a635b-5974-428b-b661-c43491dc60e8"));
        }
    }
}
