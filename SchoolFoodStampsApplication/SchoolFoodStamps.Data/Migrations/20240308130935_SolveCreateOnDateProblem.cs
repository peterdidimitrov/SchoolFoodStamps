using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SolveCreateOnDateProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640b0d68-7925-4966-b62c-55033aac4d29", "AQAAAAEAACcQAAAAELkmNbpRsfLUaYH+NcHvJ5f7YQ40BJwmcImlRpC47DPlAu9a0BPn62YGJml0BF+EEQ==", "F31F5CE3-E8B0-4ED4-B37B-1A07A373F6EE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96654759-f85a-4e9e-b98f-38f98f96dfd1", "AQAAAAEAACcQAAAAEPSZ09tdwKPRRL6TSCDEfg39BOLOrkQiW/m7CzC7NVfQEtJaFUnNva1wMtyDabYdyw==", "485107C1-B5E7-4198-B866-2E29687E5E02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fac715e-0c3e-4e8f-a3e7-6feaba1ae2dd", "AQAAAAEAACcQAAAAEGyAPvPAyn/gEAUMp7aycqur509MPxOp0ToXINna17oyzmnapDsT3NLWomjzk2JYxQ==", "24E1A037-882A-4112-A08A-AEAE8A58EB03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6daaae91-ea71-4b27-9a6e-0ca95311bf0c", "AQAAAAEAACcQAAAAEH17ak1oFtXobQeESKGqeIdmNupp5c0TMduul1dwiwSW/UDBBR2LIXoq+JLbYxbcew==", "9A7505F4-06A1-4C50-AB02-9487FC9548FC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce981d7d-0be0-4042-8758-a7e07535b28e", "AQAAAAEAACcQAAAAECkRoUGkaDFiaP1DhwbXLzBXDpQhJ2qf79D7Jb3bHaMqj+WJFzLqeQ4fTZod0zUc6g==", "12659BD7-B67A-41B3-BBA3-4194EEE59A14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48510cc-a881-495e-a73f-20f49c1b9e50", "AQAAAAEAACcQAAAAEJ3PlE7+filh1vMEisekeiAYan3DUHoQvv/a4wRML9quG3H5oi4a+62XgOXwHvy8iQ==", "B17AE139-98C4-4264-8B37-07C762B0F103" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6f9c8e3-369b-4154-9a14-91346d48f92e", "AQAAAAEAACcQAAAAELXFcPC/nRKxvl5qQVlEm7gQJrSphI2goVlyhjFwTtIQfcfgrqMM+UHsLk9UpMIw2g==", "C9CC95BB-509F-459D-8A79-F1C7FE053D71" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 13, 9, 35, 326, DateTimeKind.Utc).AddTicks(2219));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()",
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a050bd39-daf1-4380-a141-bbbcbbe9f297", "AQAAAAEAACcQAAAAEDGQmfuiE07ySORSau7mkOj8TwPITOEwQfGTqjZZRB7AJiZtsbX+9wE0/Jrg2x3M6A==", "F2210FF3-6EA6-402C-B4E8-277D3251D1A6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285bafd4-09bf-4c82-9379-617ebbce71fd", "AQAAAAEAACcQAAAAEHkG/8ZHkcaEcYv+b6jVJFCunrhG1i2350U0EaLDiVRGWEEyQCZFt7DzBFgx+LOpIg==", "CA84D5A9-9815-4411-A599-646BA471EB96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f7d0fe-89d2-4836-8607-8a852eb935bb", "AQAAAAEAACcQAAAAEPQhE9YnMQtff1QoZW20Ytb4pcO7nClmza9vTTuNyxq0vQoUDbnX5021rT+H8/UWSA==", "E5A53906-BDA6-448A-B884-96F70D6C3612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d473e593-e1a9-476d-b6ea-4474cd03f510", "AQAAAAEAACcQAAAAEH0qJxq5WEZ8H8axUCdkmhgrJKYXcHl+oe6N6cxdXeqW3ZIva1QSyvLOOhbHOYEiPg==", "BD262D63-2372-4104-A878-A01BE68014B9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a711b318-4d33-4319-8c35-404e01703952", "AQAAAAEAACcQAAAAEBdfdcVmxKJJZrsTdB8piYfmrDzLoWozPDsY+2jw9wOt4jxOlcXL+XdqoBqr+Rax2A==", "029C5AC4-D2E6-4710-93F3-E2F33BA86B17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a248f568-1201-43b6-9d26-c606b3d85aaf", "AQAAAAEAACcQAAAAEC4vxbUD+tFBHJsEpWO53zdHHA/wULQ65RL05y+xaWtnMO+oE/YFlCzvWiltHfm3Cg==", "5C0E9F28-60BE-4DED-A4BE-C8D2506F08FB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e230c4b8-40f6-409e-a5cd-8004c4170d97", "AQAAAAEAACcQAAAAEJvx8ZTR2IoHYj8kEeOE8ATV5ycFbG3Cf5yPLL8oQ9It4/B7slmvYLv9oNe0ywv9DQ==", "D3F7CEAE-CBD4-4520-ABAC-FBE305F241C8" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2907));
        }
    }
}
