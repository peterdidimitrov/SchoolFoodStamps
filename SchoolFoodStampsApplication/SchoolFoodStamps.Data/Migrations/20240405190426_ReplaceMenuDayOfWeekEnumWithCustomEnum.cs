using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ReplaceMenuDayOfWeekEnumWithCustomEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4be3cc5-125f-4a9f-8ff3-95c29cafeb9f", "AQAAAAEAACcQAAAAEGZklvYGa8Pp0jIqDlFYdb5kiWEQrKL3j3oBevhAVT53YPeeWrM++/n+GkPB3c6OZA==", "C5980DD3-584A-4AC5-A8B5-5548B9EE392F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e31fee3-a364-4b14-b843-a59c5d599c44", "AQAAAAEAACcQAAAAEKINbeJl1KAnGy+FbZNAY7hcfcTWnewbsB28z3aZKVK2zo46qdWfswBQ/j8tXkPgOA==", "A421A178-A3AF-47DB-A587-BC3795CFCF26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc918329-62cc-49be-8350-70ba2e6f5a38", "AQAAAAEAACcQAAAAEGBwBZYgJpQ5MW0ol7/+x8eCkRdd2nupfIql6/11zAWhNd/rjeGtMzWhCPYAKvZ01w==", "1B0F3CE3-3C62-4749-AA41-E012680BF5A2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e0db194-6365-4f95-ae42-9432f363605a", "AQAAAAEAACcQAAAAECnU5cFeiaY2/fm57R8r9T3aYKD0Y7mC4qzBlhvPE4wD3UjlS39cceT4ucde/veveQ==", "DA3E0359-4F60-46C4-9ED7-873A48BCD847" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf78196a-3215-4731-abb6-aae65cd65ebe", "AQAAAAEAACcQAAAAENnr2h+twzEkc5KQRpL/4Nt9KszrxtxwujDE2XeyJ/sBV6Psd167MNR8kyq1T7p/QQ==", "6243F66B-5262-4A04-B003-EF5B27300280" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "511560ea-0df4-4057-94d1-92c4d5a6340a", "AQAAAAEAACcQAAAAEDaRBSQ7tste76W9W80siuJRChhOOVReYLdZV4q17cMKocVGiIZMioFqIE+hKp4Kbw==", "AB05F06C-E601-432B-8183-F4E200D6AB96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "072905ea-1142-472a-ac5e-34cad5e1775d", "AQAAAAEAACcQAAAAEDwzlsoBqkcKIXbukuRNibCWaM4GuGpUX83rf3ihH77WsBrNnegiGRbqZK6GMTumEg==", "199952F7-8E3F-43C2-9485-A895633DB50A" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 899, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 899, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 899, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 898, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 898, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 898, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 898, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 5, 19, 4, 24, 898, DateTimeKind.Utc).AddTicks(883));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0d8aae-2b9b-4513-9978-7c7614e1c7a1", "AQAAAAEAACcQAAAAEAK4/gaxDLI6t7PjhgUurUmq1qw1U2P0M5Ql28LFIGJCC4U477iPPe17L5ZBvNC65w==", "6F140441-5BE2-42EC-AE3E-93930C402416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c41a49-4cd8-4cbb-8c9f-30e2bfecf415", "AQAAAAEAACcQAAAAEGC2qB+Mudqbs2v+JFsSU3Crxmv5uCqJxkEsUVO9rK+CeTLE2ufqMlRCQcHlNtKbcw==", "68A0F7A0-E090-4E7C-A75A-E8B970151E7C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8160af5d-8dcd-4721-809e-0228d3db44dc", "AQAAAAEAACcQAAAAEPnabDtoaJwUDDB7dWQhzWGMq+ozfPBcoLQb0d7Kroit7csZyZyT+mWV6CXe8Ljiww==", "A2E808EE-A166-463C-B3EA-4F5AB7B80ACC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bf9bbc0-4ad7-42e2-9b73-53c32c2d1e2a", "AQAAAAEAACcQAAAAEER+67aQpnM/ocBBCwzlKLmxe2Jc77mmxusKBj0HMETLnmLmiltg4d27ZTdzk991fA==", "722032B4-FFD0-449F-8409-A3F05F93BA30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b37cda0-9530-4f77-ac23-b05154d70a95", "AQAAAAEAACcQAAAAEKS5Rf1FUF3iv14FDvUKRr8gOwziFW09lGlaAVjUGlwlaBHavefVKCLSTaHIVOcyVg==", "54E7576F-50FC-4DB6-8B1D-D4CDC32F8720" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433f5b96-ea5b-4096-ac30-1bb6b23e6430", "AQAAAAEAACcQAAAAEOrz6bjD/0+gReA800e6qwCz/3y9a55StxM23LTCSVT7JrK0gH4mcnZ6669Gnb+h2w==", "EE97F6BC-2617-470B-9891-DC879894159F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb912c7-ace5-4f52-a5b0-a324d8d74426", "AQAAAAEAACcQAAAAELv4KieESJnusAq2r6rhMO7Av9ETG9HWkwlzazDtoXYkb45AHJZSecuRDO4kHEsY8w==", "1BEC69BC-0484-42ED-AF4A-2E0445738921" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CateringCompanyId", "CreatedOn", "DateOfModify", "DayOfWeek" },
                values: new object[,]
                {
                    { 6, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2760), null, 6 },
                    { 7, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2763), null, 0 }
                });
        }
    }
}
