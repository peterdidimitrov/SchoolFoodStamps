using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedFoodStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f22b201-d3c6-4b8e-90d6-1ea0d6bf0b83", "AQAAAAEAACcQAAAAEJ9Gx02lBGEc5niKtFi5LSkNt7jVs7hmhoF+QeV0ecrAPYT3lnh0YASXHSdwi001zw==", "E12672A1-7587-4138-9946-C09945A8B55D" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede1e1ee-1110-4e3e-808d-3da81d34a26e", "AQAAAAEAACcQAAAAEKigGuCGqyDIqpnd99xJvWxPMSBGixwYjot0gqssC2FJnnKKAG2q54Fu/2CICOfLkA==", "63C90AA9-A7A2-4942-9FBE-3BE87EBD91EA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da982181-8365-4718-bf15-656dfc70c526", "AQAAAAEAACcQAAAAELZc2GbcTqsvCi7E7Msnv1j1ZV3I6+LHsUP89WoJ3K71mcT5sss2zCieuDVGOItLrw==", "B92BF1DA-86F6-406B-BA4C-CE49C230529C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "673f3e20-ba1e-4c82-b0ef-70422ad5ebfa", "AQAAAAEAACcQAAAAEG1xH1EVaMiJtOnOUcNvm+yxJ7vYnveIoMHW0hYarCdyJ1TTeN6fJzGLh/uRN7EeVg==", "82501F4A-024B-464C-B99C-433610182E2E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfab44c9-1525-4e76-8d45-9473e194b263", "AQAAAAEAACcQAAAAEHt01tofEZudVuR3KoCfGC80LCQhgeg4ONgK/tZd6MM+Kc8QFi39qY0E216NriHQFA==", "43E6F8D5-F4E5-4C2C-A8E5-B3FC5D5045FC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3631e2b7-55fa-4d25-ab79-4f30d347bf2e", "AQAAAAEAACcQAAAAEKUp8U3fVsFlGGIM1GCL+PsqZtmJr4MK/JxNKHfKMIXhKpb11r7GwZFN5NkO8oVFDQ==", "BA407248-CEEC-417A-B409-A8121D79B947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f0c251e-cbfb-4584-abf4-690945256fc3", "AQAAAAEAACcQAAAAECsksS+NccDKTOU/oJuEYhI2AdVYnR05TTZwE5v8oWzA1ZALHpgRQn5Daon9798FLQ==", "7ECFE1BF-B71B-46B8-9597-DF7458C9D68C" });

            migrationBuilder.InsertData(
                table: "FoodStamps",
                columns: new[] { "Id", "CateringCompanyId", "ChildId", "ExpiryDate", "IssueDate", "MenuId", "ParentId", "Price", "Status", "UseDate" },
                values: new object[,]
                {
                    { new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"), new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"), new DateTime(2024, 9, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5875), 2, new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), 5.00m, 1, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"), new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"), new DateTime(2024, 9, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5857), 1, new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), 5.00m, 1, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"), new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"), new DateTime(2024, 9, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5884), 3, new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), 5.00m, 1, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 54, 45, 246, DateTimeKind.Utc).AddTicks(7621));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"));

            migrationBuilder.DeleteData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"));

            migrationBuilder.DeleteData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0511ca-9044-41eb-ab76-575c376c8a80", "AQAAAAEAACcQAAAAEI9dT6Yjoiro0Zr00j2VPF+40LL0KsbkDs9adUrf4fZdDoyvcsSY0Yi8QLGj2RbP0A==", "0909A182-9C69-4386-A7B6-B56161D63F15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5161d5fa-2c14-4601-ba89-cf3ad33cff32", "AQAAAAEAACcQAAAAEL6QQo5ULYEVqKpjqCNK4VdnFPDUdW3D3Aauq/ZKbz/6YBNbjJfiZCFrlOsAnfQGCQ==", "7539862E-1024-403C-AD58-0DC9E69DCEA2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c016d8-3729-40c7-ae69-c18b22c5539f", "AQAAAAEAACcQAAAAEL1HGemI+p10fTy50DvEnC6Thq06biZvNrj/rRUhkVID20hzBYEgN6fqs2LeE7q/jQ==", "76A40EA1-D94A-42EA-8FF3-56CDC363EC26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e43b4ce9-315f-40fc-a13e-8e6d5552a475", "AQAAAAEAACcQAAAAEKPVHu3wjzUzu527MVGzFpMt82sGbk7J1dGsY0/r8TYeN+0k6eTTEVDOY7gpGmOcpg==", "089CC561-39EC-47A9-8866-EC16F7012684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71a3dc79-03f7-4bb2-a647-20eed87aa64a", "AQAAAAEAACcQAAAAEH0SkDhtEmeMhKudP/r9SCvc8q62sY2u2ACq4n+qJUv8XGQhxTjBIxfP2DDdv+nnEw==", "F14C619E-F178-4437-8337-15FDB08E28E2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7660e3a1-9866-430b-9ba5-b6d2f2d33a7a", "AQAAAAEAACcQAAAAEPZ1orT8255GB7FyiKHNBQMKPKvbtqfwYdbOTE6B5FG3bLm4W/z7pvcs23CGCF4P0Q==", "17A757BB-27CA-43BB-A30F-12574AE39AF0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13663739-c62a-438f-8c3f-3ce8e824303a", "AQAAAAEAACcQAAAAEG3mfxG+sAlPE1/JvdTpmtk90cMKsbBfoK51Xz51IthgU3rtVTMXt8NeTqVbjDVBag==", "6BE92828-8E46-4A82-A2F0-299AAD28072A" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6263));
        }
    }
}
