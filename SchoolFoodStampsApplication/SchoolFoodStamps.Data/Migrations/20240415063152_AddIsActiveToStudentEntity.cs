using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class AddIsActiveToStudentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Student last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Student last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Student first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Student first name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: true,
                comment: "Student date of birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Student date of birth");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is active");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "703dc275-4821-4a47-b42b-8a295f840951", "AQAAAAEAACcQAAAAENvT4/pU8O2Q4RwSdaHfT54VH6zIvyTuD2K7rQ1ZsZVE261+0bYiVoNoH9CuOe270Q==", "C330A40C-66AC-46EC-A03F-7E6CC9A3A7AF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af54701a-2439-443f-a586-74c8b2faf518", "AQAAAAEAACcQAAAAEMZk/icTIaHKSAygewk5qcNp0QCny5dKGUlg5I0T3SO8YXL0XB83INOJAzYBVejBZg==", "E2DE5A32-DD77-4FE3-BB0C-EC0E92D54C7A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7442c3-e2d0-4203-94ab-487413bf308d", "AQAAAAEAACcQAAAAEHvMCLUCTAt0PDXIehh02lzqodypjF/lhNay4WP/K+wwhjVLTj18dkZy2PIJZ+j00A==", "031F3ED5-7D91-49FF-A611-512DF8D05BCE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9756bba7-48c5-473b-af16-be3a84c6333d", "AQAAAAEAACcQAAAAEOBy5jhI/GlYdPc/vhnlo3NEcRdpIbo9+qeQbNfqIMHAqeluumv6fN2gCisHRfdhIA==", "EBE3AECF-E164-4EE2-94C2-D69877E7A200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a7f223-b36c-4838-8f4c-6f22b5ad9225", "AQAAAAEAACcQAAAAEEY5qX+QPBDSu6j7Y4Znc11FoAyJcAIMk2zRRU3yez8/Mg3nsFkSd4vZsXI2mv+FGA==", "0D310000-F682-4DF8-9B82-3BB80D4DB981" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f71ca5b5-ec9c-42f5-bfe3-9fd0cb475c18", "AQAAAAEAACcQAAAAEDvUwVFIXsTPonPnS9z/pCRQJNNRLZwz6sNt6GAmU6OHdx6Iy9ZjizSkDIxJUTCgrA==", "FA978BF0-A478-443A-87F9-39185AE8FFFA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc920f4-40d6-4faa-bc70-8997200978f7", "AQAAAAEAACcQAAAAEFaivyu64OC10+GoIG914HAVxvDSYfZS7zrFTYAUwfVeHanHKeoqFfepMUcBEi4mcw==", "8A9D9181-7B8A-4DA2-B6E2-3C5C616F856F" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 15, 6, 31, 51, 735, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"),
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Student last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Student last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Student first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Student first name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Student date of birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Student date of birth");

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
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 884, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 8, 5, 47, 9, 885, DateTimeKind.Utc));
        }
    }
}
