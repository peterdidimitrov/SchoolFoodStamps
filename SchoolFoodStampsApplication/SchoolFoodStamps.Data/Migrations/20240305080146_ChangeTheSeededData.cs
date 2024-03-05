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
                values: new object[] { "83e30885-0087-4a6a-8532-bf8526ee02c2", "AQAAAAEAACcQAAAAEJfMjI9iB67JUpZSXtFi1IsBjxt011EhE0cYefdsF4oduuikxTU/Ky0deRTMbh/OSw==", "BC9AA79F-3F7C-4E7E-9B07-E702BC60613A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8013709b-e0a6-4657-8922-248a87c613e1", "AQAAAAEAACcQAAAAEFMN9CJtFZ1aW6Y5U9PJtkXHznr0NVtMQDCvQ+wXo3zmn7uq9CaRAItAUNwXXEQRxA==", "90244B45-552C-4A44-B68D-58B001C20CF6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a65b8887-bc5c-4986-acea-38ac2554fa7c", "AQAAAAEAACcQAAAAEGSxKF5QDopBCPuavKEJSqeOM6wPXqoj9LnnPm12ixq35vCNIxK3SrDP9WFVX1f80Q==", "C9DBC86A-10A1-41AD-9440-A5D49F1160A0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54c54be-ed07-4b13-8e24-23343d88fc79", "AQAAAAEAACcQAAAAEEFZGEgnMq2Tb8uPlD5yoz0x9BIlhin0djbm6nU3v27lh0arVGMLuZr9Vo63K2gr3A==", "EB84D1F5-9F6A-437A-9D07-F4F1EF3FF5AD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eced55e-9440-42f0-8c96-fedeb4165571", "AQAAAAEAACcQAAAAEEdTqurKP79BMlBy5PWCExbGr665QOvjWiOR8oux/xQpPLz8PkPvzs3T16+PDb9EAw==", "010D0205-1417-4C1D-9FCA-E7445D2328DD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c1bf847-2e07-4616-a80a-b69cb67e66e8", "AQAAAAEAACcQAAAAEJRi5xX5hUu3DCpp/QNAnFAbUFP1nGPPcBQ5/pTSrGvdTIyI3NteiNcKSapUpRWBTA==", "6E893D2A-DFF6-4670-B658-94D9464CF6CC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d2f391-e512-4eae-96a8-004d8c526b49", "AQAAAAEAACcQAAAAECH7IteMKZP+P7gUOLk4fooy+bHp4EUGsLHQW/XaVfy+A9c70mBYlCY29ZgNjiBkaQ==", "A7EE88AB-FE1E-48F5-8A55-04D84EF0716A" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 869, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 869, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 869, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 5, 8, 1, 45, 868, DateTimeKind.Utc).AddTicks(9483));
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
