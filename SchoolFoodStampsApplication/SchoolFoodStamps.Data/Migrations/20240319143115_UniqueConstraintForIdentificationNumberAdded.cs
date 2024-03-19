using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class UniqueConstraintForIdentificationNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "Schools",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Catering company Identification Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b37a4080-5041-4212-9ff0-83254086b8ef", "AQAAAAEAACcQAAAAEEjEC+g+uSKMSfTI9a2G1cnJLpB6EMPooaucPtwd2YCv1s+mJLTrl7ivWLzP3IARUA==", "9C5ADF64-4C56-4FD4-89AD-1330A7FE117A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c691acd5-e383-4742-9274-891b66fcd06a", "AQAAAAEAACcQAAAAEHevUB8t46xd3Dm3dDrOO/AtWYyyq04dDnUxhfZQK6KhNvU63ckb8iNfSUgdhnuJdg==", "5318288A-B4CE-485E-AFE4-DF2B14BED0FF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645f4c5c-e76e-4c0a-be19-032037f81cc2", "AQAAAAEAACcQAAAAEHuIYmuvglJIiMuMU4o2p6J8eU+43vkKb8Xi4tQcJK5nkv1wNJ9biswWsIllptVn1Q==", "F2164958-9212-4E97-BE92-EC77F6F2ADFE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a25b125-1d54-434b-b957-fe3a4e060f9e", "AQAAAAEAACcQAAAAEG6uq2S+cr/w5bobDe5eX6Ovsg6T2cEt2Dw9ISjAEFi07o7Yg/VLc02WKskBiXLSBg==", "85BCDE32-8FF1-4139-9C40-AF5E6C311308" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c9a1ea5-1034-4411-85d2-b9b6e174431b", "AQAAAAEAACcQAAAAEF5M4i9TTkqqI6h2xd4P8R/djnxYN8JNO6ON/53C2pM4DikkJuVjxPBYUd9BPXEehQ==", "8288C75B-9CA9-4EE4-B50E-32E51DBC53D6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0002b3f-32bb-4fe5-9fa5-e8056a49289c", "AQAAAAEAACcQAAAAEINVz4ansP8C8NnwpxUqcHXA7ofs+XPE0KC6L9D6AZ8b1meXUMbnzgm+390D7JWxbQ==", "F6B676ED-2A2D-4FA1-9804-0C56A9B8DE93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "403dbba2-8721-485f-b619-b257815d4bdd", "AQAAAAEAACcQAAAAEF26nsRHc+bOZQOv6b8rpsJ1PhmBc+YsdvN+WtFjaLfBhf3+tl/Rln1zmdKzcZBVLw==", "6399CBAA-228A-42DF-A72A-FD93841F46CA" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 19, 14, 31, 15, 45, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.CreateIndex(
                name: "IX_Schools_IdentificationNumber",
                table: "Schools",
                column: "IdentificationNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CateringCompanies_IdentificationNumber",
                table: "CateringCompanies",
                column: "IdentificationNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Schools_IdentificationNumber",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_CateringCompanies_IdentificationNumber",
                table: "CateringCompanies");

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Catering company Identification Number");

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
    }
}
