using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ChangeIdentificationNumberMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "Schools",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                comment: "Catering company Identification Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Catering company Identification Number");

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "CateringCompanies",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                comment: "Catering company Identification Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Catering company Identification Number");

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
                column: "IssueDate",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 20, 7, 2, 52, 386, DateTimeKind.Utc).AddTicks(4317));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "Schools",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Catering company Identification Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldComment: "Catering company Identification Number");

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationNumber",
                table: "CateringCompanies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Catering company Identification Number",
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldComment: "Catering company Identification Number");

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
        }
    }
}
