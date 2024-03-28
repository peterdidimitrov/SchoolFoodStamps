using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class MakeRenewedDateNullAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RenewedDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: true,
                comment: "Food stamp renewed date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Food stamp renewed date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d93932b4-c168-4023-8dae-8ee84e8c2f95", "AQAAAAEAACcQAAAAELOrZsHHWIQ6PrOd5P3Dri6pI5JgkY6PPtdZBBirP4T4gU81/DRBPOqculhM/QH5Wg==", "D3ECEBA6-780F-4F4F-80A5-36FA329B13AA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af7708d-5241-4d35-8316-6e04a1d659e2", "AQAAAAEAACcQAAAAEF/eaH8ta3s2+Vr1Vb+QH7TJcm/J+8AIWR1vIIBnb5JB2NVUnjmHKC8TpasfQFjAlw==", "2EF21CA4-2414-4BA0-A22E-EC14B280D7CB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e950b49-1942-44ca-a8e4-74b6aa147b38", "AQAAAAEAACcQAAAAEGOCzn70+HCTF7v6LzdiBr2FIA4VxjIMhqEK5TxLHtwW3BxF1hFK5aOxbCxr/FxBqQ==", "33CD94C2-1D3D-4197-961F-2C0A87277F97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49dde23b-90d0-4cc7-bdcb-5758350cc0ee", "AQAAAAEAACcQAAAAEOaWJDad13O0Iy+atzwTYMqMju5Omggqq5hsvhC07jg3JBMV11djNWkaf2yKjwFccg==", "5EDA286F-9FA1-426E-B22C-BD53B67A4DDB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adecd867-afea-4155-a623-645c514803f0", "AQAAAAEAACcQAAAAEBahCv+MuDF5HDih+T04XEc2Oav7stSj9XQclhRxYbBlNjhGl9zMSAaT6CKSNnt8Ag==", "5EA63C9A-967E-451B-B23B-8933F674A923" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "926d2784-3a8b-4512-a5f0-38751b398d5f", "AQAAAAEAACcQAAAAEPjYH/kfIT3MorFozzMAmmhqPpUjstwS/LGp0bx6UIrEJ058o//dGiTvX4SwM/8BCA==", "DA153DDF-D7E2-4617-9D7C-647A0B4DF9F1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3155956d-be1d-41a6-afe6-9f3f37a391db", "AQAAAAEAACcQAAAAECRi5KSH20tUIQsiQPpFvGuwNLIRdsz7TUZKev3kYC8iTAU4B7Kop7NCt3HwTENVxw==", "C37A5EF6-E86B-4077-A285-5F7C0E4FDB4F" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8585), null });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8570), null });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8590), null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(5595));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RenewedDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Food stamp renewed date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Food stamp renewed date");

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
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3785), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "IssueDate", "RenewedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 25, 33, 90, DateTimeKind.Utc).AddTicks(3799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
    }
}