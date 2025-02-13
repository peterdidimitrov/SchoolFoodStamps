using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class AddEmailConfirmedToSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb426f73-7e53-4df2-bb39-53e35c099836", true, "AQAAAAEAACcQAAAAEBB6ZY1uW7Ki5mWuhe2qoSmC4RWUuETE73Z4gzUP28pngWiuQpCXPTp+VILuu6iJJA==", "FB43C166-E89E-41C1-961E-9BF5598F935B" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92029206-6e7b-41bf-8aab-333204e512d9", true, "AQAAAAEAACcQAAAAELZszeActZHUQuiTkgf6L3RTRIvruybb72fVz4yWlLxE4puFN7FumZD/a5mhUuuvVA==", "D12BA040-98FB-47D4-8756-797FC2C8F886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cff09ead-48ab-4280-b0bd-19d5f02a25e6", true, "AQAAAAEAACcQAAAAEJxxL50kMYGvZ/pkJeNYjk37kifjcWU2ugmaIht/VJ8iGkdmFjuBEIixQyz2yoa4eg==", "DFE1F226-6317-4971-ACA2-29C20B565B14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47986514-cce7-400b-b159-08cb82692da3", true, "AQAAAAEAACcQAAAAEK8nbLsvFirYc6E2wZvU3yWD5t1lPa2LTN/03hDltNkXudTFrMAsJ2/ws0M+acKgZA==", "C5A7EC3B-B7CF-490E-A9E5-DA4BC4CF110F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24289cf1-cbcb-4c00-b875-4b61d4deaf74", true, "AQAAAAEAACcQAAAAEJyWNcLyHX5o/rT8qnfXdizhM8j15iH0WhDcU25q6UoK5mjDvDBt/WVc61Ac9D1ewA==", "2E23CEFB-29D3-4593-9CB4-F6601A0B029B" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0950e2c9-41fb-480a-bb0c-9985c5c8d58f", true, "AQAAAAEAACcQAAAAEM/mhxVKKkdWMXXSCA6w+iI9bm4RicsFej2CN2tm6E8W9Iwa7AQKWpYMZdMU73NQBw==", "CBCC93BF-08FC-4770-9272-93F6E67DDFC4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10aef151-5fd9-45c1-b16a-1aad522266f4", true, "AQAAAAEAACcQAAAAEJe1XUtja18DEp+dLsQ/PK7LevbRsLXNnI9I1kfPmrzs8naAzERX3DpEgkKgp9nDvw==", "B2E6DA02-4C6B-4C60-B70C-4822734872F0" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 802, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 802, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 802, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 801, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 801, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 801, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 801, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 13, 13, 2, 6, 801, DateTimeKind.Utc).AddTicks(8847));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "703dc275-4821-4a47-b42b-8a295f840951", false, "AQAAAAEAACcQAAAAENvT4/pU8O2Q4RwSdaHfT54VH6zIvyTuD2K7rQ1ZsZVE261+0bYiVoNoH9CuOe270Q==", "C330A40C-66AC-46EC-A03F-7E6CC9A3A7AF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af54701a-2439-443f-a586-74c8b2faf518", false, "AQAAAAEAACcQAAAAEMZk/icTIaHKSAygewk5qcNp0QCny5dKGUlg5I0T3SO8YXL0XB83INOJAzYBVejBZg==", "E2DE5A32-DD77-4FE3-BB0C-EC0E92D54C7A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7442c3-e2d0-4203-94ab-487413bf308d", false, "AQAAAAEAACcQAAAAEHvMCLUCTAt0PDXIehh02lzqodypjF/lhNay4WP/K+wwhjVLTj18dkZy2PIJZ+j00A==", "031F3ED5-7D91-49FF-A611-512DF8D05BCE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9756bba7-48c5-473b-af16-be3a84c6333d", false, "AQAAAAEAACcQAAAAEOBy5jhI/GlYdPc/vhnlo3NEcRdpIbo9+qeQbNfqIMHAqeluumv6fN2gCisHRfdhIA==", "EBE3AECF-E164-4EE2-94C2-D69877E7A200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3a7f223-b36c-4838-8f4c-6f22b5ad9225", false, "AQAAAAEAACcQAAAAEEY5qX+QPBDSu6j7Y4Znc11FoAyJcAIMk2zRRU3yez8/Mg3nsFkSd4vZsXI2mv+FGA==", "0D310000-F682-4DF8-9B82-3BB80D4DB981" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f71ca5b5-ec9c-42f5-bfe3-9fd0cb475c18", false, "AQAAAAEAACcQAAAAEDvUwVFIXsTPonPnS9z/pCRQJNNRLZwz6sNt6GAmU6OHdx6Iy9ZjizSkDIxJUTCgrA==", "FA978BF0-A478-443A-87F9-39185AE8FFFA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc920f4-40d6-4faa-bc70-8997200978f7", false, "AQAAAAEAACcQAAAAEFaivyu64OC10+GoIG914HAVxvDSYfZS7zrFTYAUwfVeHanHKeoqFfepMUcBEi4mcw==", "8A9D9181-7B8A-4DA2-B6E2-3C5C616F856F" });

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
        }
    }
}
