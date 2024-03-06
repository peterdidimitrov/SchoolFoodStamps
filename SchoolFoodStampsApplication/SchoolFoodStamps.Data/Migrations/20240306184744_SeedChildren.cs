using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d71d6f5-7cf2-4a78-b1a5-a7966044ee06", "AQAAAAEAACcQAAAAEEugaQdtP+m6079qYnjaZq2rSHYnqgI6PmhVXokg+W9PptGiJY0qRHqsp9mB0kR14A==", "C820F9B9-145A-4903-8CEA-5EDFA6709923" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ffbd90-88aa-4679-8ccb-c525879918ba", "AQAAAAEAACcQAAAAEDDyANpdD5r0idCkNvA+w18+zh+EhtZRLFNFJ0JEHxGASYyu96G7RlG5eBOqP4fq2g==", "3E4D9F50-E0FE-41F0-827D-DBCD89DFB5FD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28f57c2-afcc-4c15-a7d5-c7b460899411", "AQAAAAEAACcQAAAAENtAF+HcRPn2dPQak/jCHConwvc6DpJ7bV0EtPmRgQ4z53gpKX8apNxuAbBdmsWKtA==", "C6D4F897-2932-487B-8F28-715DDA4C3BBF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d673c98-9c3c-4cd1-be62-42b6384d05d3", "AQAAAAEAACcQAAAAEGhUwl6OB3SOnxsSomXhzdcgOV8MAd6EY+6e9Wasei8CyMCo0SXYnqCfLre5d2vHgA==", "2F6E1DCB-9D5B-4CD1-BB4A-46810CAFDAEF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "316e687f-0874-472d-b1cb-8b7157a5caa4", "AQAAAAEAACcQAAAAEGbYJW3y39lNrFvzZ3xRp0mZw87tnYVSkdFLrwvDQJ+8t7SuAA7NguC19qbGTcDXbw==", "75CB12EE-2BE3-42E8-B469-69076A457C41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a19b59-2fd5-417e-b87d-2041ab197d18", "AQAAAAEAACcQAAAAEKlKTP5FItfEWYSlEzzEa0ZOd0Q3tHcRBQ18Sq12rBQVvEVyEfN5YSSpWiv+sHIbTA==", "8DD919D2-BC6C-401D-9D40-3A129A6D80D6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcbd2bcb-fb55-4058-b129-990c38a863a1", "AQAAAAEAACcQAAAAEEeDoeAfYsnDlojCIe+vpk4wuDxzqyhUt96Iw1Xf0E5H4jN//zv4dS/Th8HMEaFywg==", "D8B4C286-46D4-4331-ACF2-E5A54AC744D4" });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "ClassLetter", "ClassNumber", "DateOfBirth", "FirstName", "LastName", "ParentId", "SchoolId" },
                values: new object[,]
                {
                    { new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"), "A", (byte)1, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe", new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") },
                    { new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"), "B", (byte)1, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Doe", new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), new Guid("6cd00c11-b0cb-428a-9143-df5743105a92") },
                    { new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"), "B", (byte)3, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Children",
                keyColumn: "Id",
                keyValue: new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"));

            migrationBuilder.DeleteData(
                table: "Children",
                keyColumn: "Id",
                keyValue: new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"));

            migrationBuilder.DeleteData(
                table: "Children",
                keyColumn: "Id",
                keyValue: new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cba1c66-e389-44b6-a39b-40eda113d618", "AQAAAAEAACcQAAAAECpJJOBIhmHdlQCMuXAoNMPv1/a8fnmUk+EBY5uXVx+Hrixznp+H2LH0JNboN9QKEw==", "BC191C60-32CB-4F1A-8345-DB80A98E0A6A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8e42e26-5ba0-4af0-bbc5-9d08b84fee84", "AQAAAAEAACcQAAAAEHANC9lABRbMale/aL6GA66yBkOWc7gcei8fMcgiUkopPdnWZekz5NlSII5AIs1Pqw==", "953A35F9-C4BE-4383-A2D7-110B94FE25E7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d72e2e-a006-434b-937f-678a23e80109", "AQAAAAEAACcQAAAAEMxEPpx3RiSYPkDB/nP/UwQfXNlHjz1e16fww8KVh43izsfh8Z5HPBxy8klK2mvpJw==", "7C6CB1A5-3189-4EE6-86B2-2DE1D4961B48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "951bcee4-2b14-4af3-b23b-429eb3e0ce17", "AQAAAAEAACcQAAAAEJlHCy0Us+zTHvKKcAjYCJyfFFFVO+dAeyZgMjMTdkrcEXayX8pKcBEyw+iPBnx7IQ==", "BADB1BD2-1676-42C9-B4D3-BD94928C3001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "312b9340-20a0-4d72-b070-05b788d25f2f", "AQAAAAEAACcQAAAAEH41R2lhAMK61D1UPczySFF7HSl1rVakY1HUFctOo6/C6bLwhcA8ETt0k5Ya7olf9g==", "CA1B9155-38C4-4280-81A1-830E216B04FB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ffdf16-8c0f-4118-90ae-829f2341e31c", "AQAAAAEAACcQAAAAEPoD2uSZ+cik53tg7MmEUo8Z8jpnC/pUGnJt8enfrK8krT6xRSOnEbwMMJvvVZlL/g==", "29740100-490F-4604-92D7-FB309B00AEC5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12db5774-014b-4dcb-af67-d76240c4648d", "AQAAAAEAACcQAAAAEK5lwrRyFztETjQpN5jFb+G12xjVIviW7u1JLZAdtbC8Wl+m5xCvnPipgFfWr5I6dA==", "0A7C632D-2448-4F9C-9445-9DE17E583342" });
        }
    }
}
