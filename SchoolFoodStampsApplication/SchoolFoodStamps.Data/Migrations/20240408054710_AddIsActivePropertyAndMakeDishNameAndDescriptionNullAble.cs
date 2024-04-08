using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class AddIsActivePropertyAndMakeDishNameAndDescriptionNullAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is active");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dishes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Dish name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Dish name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Dishes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                comment: "Dish description",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Dish description");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Dishes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is active");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b08d8653-df01-496b-89a3-f4403a4c4d10", "AQAAAAEAACcQAAAAEO3CF1Qpwyb3PbEx/6O8zse8ziw2QiObqvyHiLpvBaC0JZhQIho9IsYgh9hESs3RKg==", "0966A4C4-EB14-4DB1-A577-483E684BD29F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe274ee-09d8-43b4-bc57-de2d71e331ce", "AQAAAAEAACcQAAAAELCdXVg8RalHubtxVfruSGrbkPgAdDy4UzNRV9qhMIHf20kpWEIVIDi7CdjcpGERWw==", "C6920600-C163-4F81-9B1F-F0BDB7DD44E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c138ab9c-8e7d-4d2d-9083-bce28278404a", "AQAAAAEAACcQAAAAEFp3zYewKP7NfETIvhgb0qxsGIJEwaWXWUX6eKQ7nDPG7U+oS1u8D+k11t46nAaEYA==", "77CB963A-AF8D-4AD7-8CB1-33C69B114DA2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edffe3bf-9f4e-4cdf-b095-2dbf04716844", "AQAAAAEAACcQAAAAEJzjovCTJN2u0KLTBX/aA/tfEFzo1Yi/UQW5QBwTTvmqa+h1wJfj1cRfZXWdns1EuQ==", "29ACD70E-3819-4F2C-BBCD-C0F20C89D76C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e84e34-8a3c-4d90-9f0d-c4f135eed74f", "AQAAAAEAACcQAAAAEH/RAo52eIzdrFMi746Ivs9+MmRpDlKAcZ1693fv2yAimdlkkSMG4E4anQ9EPRbKeA==", "D0822C37-276B-469E-B9B1-C8FF21D61C21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b505b265-f9ab-4e09-bda1-d692d669bd84", "AQAAAAEAACcQAAAAEMyEpSbNvrxmrBlo5JEfC3qedhVDTsGKmmBhtdQPD5WYQOAkl+Ztrl3UiHWX4d3d+w==", "9F40BCC9-DAD9-425E-B646-702F058A3BCE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31a7e5c7-dea5-49aa-879d-b87710a5bbe4", "AQAAAAEAACcQAAAAEBefLCfcUJmNyfF0fo3yuddAI+gjudIU4mtXKDBA8tru4xUtATq90i59ptvodF+xMg==", "003542B6-0CB6-49CF-BF49-976069B8DEBD" });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 885, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 885, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 885, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9991), true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9995), true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9997), true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9998), true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 4, 8, 5, 47, 9, 885, DateTimeKind.Utc), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Dishes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dishes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Dish name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Dish name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Dishes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                comment: "Dish description",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Dish description");

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
    }
}
