using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ChangeUseDateWithRenewedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseDate",
                table: "FoodStamps");

            migrationBuilder.AddColumn<DateTime>(
                name: "RenewedDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Food stamp renewed date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89fc4d54-32b9-46cd-b1dd-159a8b84d3b6", "AQAAAAEAACcQAAAAEIQSy2tWulmuTz50fs7CabGBUU047ie38Hz67auzOsMUxsZtGqz3hiAQogW5sMl5UA==", "CAD7561B-B04B-4128-B7BE-11594690ACC3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1416f2-5cd3-4fe7-b116-727739cc54b1", "AQAAAAEAACcQAAAAEFgEx4YRTwDIOkrhWppDto+gzBEgg+U3RnOXYGiEx63rpgEP4qags/Hxp4+sHGCXmw==", "CC8D1248-3C00-42D8-A929-2AE01299DE8A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0195fe4-9273-4570-8a3b-c1d773d38f9c", "AQAAAAEAACcQAAAAEFArIzBaiqR7by5rrGERdr04/CgSzFxz137ZZeKO3te1lNXq/EGS0ehfOsAsJtMxJA==", "BFC97163-5949-4004-BB63-D44E1FBA705E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b4ddf4-2a20-43e4-8169-d7324164831c", "AQAAAAEAACcQAAAAEJ8NGumtLzfOCGEnQ2K/JwYkUIhnpJeENkK4KHoQISmtzYQAaqcM8CdEA76AALycrA==", "58F19821-60F0-4521-B1AD-E216E9B2EFED" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f91812-4769-4495-9fb4-8497f929ac66", "AQAAAAEAACcQAAAAEGV9U98FLfNu0yyczmfLILJioK4Tyo4lsTgmvg5vaLjtJOSrrBUsS6EV+dHHC+uvZg==", "F0010E82-CF22-4585-ADC5-E0C9B9587963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26554178-8c17-4555-b425-15c748ddee31", "AQAAAAEAACcQAAAAEBG+sA0uo1ckIPtayYB7IphyUpP2g+IVVMz/+c4Ivu/MZN17YPAsKb7I/WJNB/dnvg==", "40BBF0D2-0BCF-4591-8A1A-F79A684D636D" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad8d1007-587d-403e-8f25-7a8d374d0cc6", "AQAAAAEAACcQAAAAEJfYsx4rzJDZRx7WA9WKkOua9dNfB2sMtgNbgFn8nwaaPlANtZDurJUAFExKCAjN+w==", "998B7B9C-E1EA-4D93-892F-BA3ADC59EE64" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(1660));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RenewedDate",
                table: "FoodStamps");

            migrationBuilder.AddColumn<DateTime>(
                name: "UseDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Food stamp use date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9a6ac87-47fa-4a14-9550-316963cda551", "AQAAAAEAACcQAAAAEMABdWHRbBCd5GHxLsQpUn6BABiGcw6RjLeDURxXQrARE9VGO1Pj2E98488OY51CvA==", "AC6F6FAB-8E20-4372-97F6-7FCC7EA70364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f308b87-7665-4803-8ecf-e1509bbfa0a3", "AQAAAAEAACcQAAAAEHeTiN9DQHsaX0McLs2V9XkZxksCMV0x8qEd75h6xdKzRfUFxjjJIMGy5zbHPcsmlA==", "C2603D15-995F-4F7B-8406-7577D2A1D95F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d29b0bae-8a4b-4152-9373-a185ffca79a6", "AQAAAAEAACcQAAAAEFNmpqvqnOzDiOvNohk7nyK4ENZtJrbJ/AEorPdej9gTcXpw11sn9oHLzqn5hP3sfQ==", "21276D54-D109-4C60-A108-9EFB2DCE0D0D" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc15bb7a-210b-488b-b279-7b7ebbc7128a", "AQAAAAEAACcQAAAAENECOYg+JJHUvJCp2oakjaVXPg3D+9/AJAKwYFHW4JAgAsx2PqdMVzU0g+OTPi+7ZA==", "F331DCD5-854E-41CD-97A8-B7101B6E3A07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec3509b-39e5-4533-8982-2ff09b0694dc", "AQAAAAEAACcQAAAAELIJ2CmGlWZnKuMUJxa86CjjV+gI73ETvbK84UaOt2M4HZdTJaWFF8RACczY6oi+Wg==", "7FDE430E-858A-482C-B6C1-93005E53E207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1864c42-65f5-4038-b78b-969b356ec0e6", "AQAAAAEAACcQAAAAEMuxJp58HvOGBQGieXRYy5C2RSjhcTHPo1k/0BCHLfQI1qln1gcb4C2le3yD0xE4NQ==", "49D1D50E-14A0-4179-9805-1EEE18F425CF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af5bb42b-3728-4dca-b902-1e42989c1652", "AQAAAAEAACcQAAAAEKXVnLNhPOaEkJI36RfA5V0TQCFZoMFs5RvssXwoYTVQGdh+0xZvZa4bHxzQhHnb4w==", "E8233522-44B4-400A-B273-DA81A7F0DB1F" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                columns: new[] { "IssueDate", "UseDate" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "IssueDate", "UseDate" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "IssueDate", "UseDate" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(2300));
        }
    }
}
