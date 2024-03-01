using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ChangeTheSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1479),
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(3928),
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(2304),
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4582),
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9242b98-2be7-4ac5-9b25-03fc9f436b47", "AQAAAAEAACcQAAAAEMG5Blmv3yf2kgCdmxRXDfcB2C3EWA6aS3xlNjCcUMaQ92cpTNcsy7NZIwSC53dH/Q==", "CE8687FF-A75D-49CB-B737-EF03DA6460B2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ef76ae2-c7c9-4e6d-be32-5ab4a8ae05f9", "AQAAAAEAACcQAAAAEJM+zxplZp2phLuPnm8EBnuu/j/cvNdj5YSXfNiqZcQdzyUWhh0Zvb9RKRXIcvQ5sw==", "CFD908C9-898F-48D3-8497-736833756712" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e0ed780-f86b-4639-be8e-da3c6dd5ca23", "AQAAAAEAACcQAAAAEKo3j0sa0hYk3G9R781jHB2zg0hkEGTCqbbKUDfELk1Ai1i0ONLtmXYXtL5k+EFmXA==", "46A336F3-F799-4B43-974E-6595B911B769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d54a6f1-e3db-4ee7-aa49-0c27987b7204", "AQAAAAEAACcQAAAAEGWr2DjqV08LgiBR2jUCmdsvZe+n4dZbwGhKMXcGQk4uSUAN+dZg/DMa+Daa0RwedA==", "746B6EDC-2B78-4CCF-82EC-6114E38485CC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6bde280-1de1-483c-a1bd-26bafa10f1dc", "AQAAAAEAACcQAAAAEHdS+2pgDn1BobMZODKGU3ss8+iiZHMFQmbZ5d3jwEOSv2F4f0T7+XR0v5gVWK2YxA==", "E471FEEC-BF84-440F-8E5C-A1D5A9107030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e7e0ab-3ff1-4854-b764-bee008d4d607", "AQAAAAEAACcQAAAAEOjLZ/JwbThhho95K+MIrhhPSJfOKprB9J0XdRwbQifkIXdDnAVmJp8B1BFZbqEkCg==", "808DC9F6-B882-4A67-B428-F503D9693204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff3fd5c9-106e-4daa-a1dd-c606880469bf", "AQAAAAEAACcQAAAAEO6B9nbGiNA1ZMqlwaxN0yUT4uP78nNR4Tot3vH1N09fzRiqCz51ziAFiG02oX0AuQ==", "D62A9ABA-B5CC-4E17-98F4-68823E68A2DA" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1631));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(3928),
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(1479),
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4582),
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 13, 16, 44, 206, DateTimeKind.Utc).AddTicks(2304),
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16d31ee0-a243-4a40-8927-4871b887dcc2", "AQAAAAEAACcQAAAAEDQ5cYZlXotx4GApl6lX91DPfdfBnzk07qEe0I8A+8wUgnVouS7kbRD3sv4iO5xcjQ==", "F5009C17-65ED-4574-AF8B-2C4EE54356C6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "585026d3-70d8-423b-9eff-86cbedddd4be", "AQAAAAEAACcQAAAAEEFO//lhvqPeVCeBiuns+E/tPIYzbTSN3/sNS72tAhYypPHyYP/APtyApThbYE+j4A==", "B4875D0B-C647-4D32-ACE3-2815061916F9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a71ae98c-16c0-492e-86ea-9965cdfb0e52", "AQAAAAEAACcQAAAAEG0mnKJnfP41qpzh7AVu9XO5tYavVBNk7Y+g4WwvtIf9MMGFswL8N0984YclJX6mSg==", "43BA35F6-8F82-46DC-8F13-7BA2D4042D9A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9339f2f-d310-4a66-904c-15acec909682", "AQAAAAEAACcQAAAAEEOZyCd2th4nh5alDo+Q4rhnCZzbduA3vzwMY6+SbxcfbdilkxPuwq32tqqYPA6BFg==", "6797E325-4DD2-472A-BD16-9C35391F9D05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ade6862-40fa-4190-b5f8-309ecc34a526", "AQAAAAEAACcQAAAAEE+TBOsG0XT7q5IA2b/6ooOZ8tSM49BJq8FJ6iaSdbvUUHH2nPm5HwDDVqsfVmOHXQ==", "67AE02E8-7F1F-4A33-B552-7AAE4D63E50C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1cb8b2-27d4-4c21-a3da-4b9f94245e6c", "AQAAAAEAACcQAAAAELWHwSdefwOlYjbz3QPpv4g8BX7uBmHFY6icqE8B1nfeOgqtYBt2rAtbDfmUurLflw==", "5235D42F-F9A6-44BB-A89D-C3356BE3B3C2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76a3a5a5-9f2d-4810-93ef-9843ee087d1f", "AQAAAAEAACcQAAAAEN9uF0NyGIdQHobW3G+XPSiaNKqPBBP3mIWZMRGPYsqMl/YBa6TNFvlvVD21HCwgAQ==", "E4C9195D-60B4-4ABC-9328-BA5193637A38" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4052));
        }
    }
}
