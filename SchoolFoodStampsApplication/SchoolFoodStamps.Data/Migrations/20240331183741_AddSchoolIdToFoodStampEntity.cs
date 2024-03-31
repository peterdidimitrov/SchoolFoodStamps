using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class AddSchoolIdToFoodStampEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SchoolId",
                table: "FoodStamps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "School identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "effbe53a-a2d4-45c3-a4f5-bbdf36d7c69f", "AQAAAAEAACcQAAAAENA9QAcWm5mVf7gvFOT46/RxtHppd/4zbn/9T/NufyxaYFNPaLNMBwqKadI5129dUQ==", "333B7B22-1AAE-401A-8E3A-5D64845AD74A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2858946-239c-49ff-93e5-b0a7c5db4a3b", "AQAAAAEAACcQAAAAEI2NUc8R4wrXUWZRYIt2oQIPn8wOr2xoGQhq96lRoIT1i81Um6WQ2iPeR5TlOgluUA==", "02C5BF46-CD13-4F17-83E8-85FB94B7D156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee58087a-7e85-4d5a-94e4-b521b3f98a0b", "AQAAAAEAACcQAAAAELUUZluo1b5kzUs8NJUYjwP6viZy1HCPefdlFZicbjSGKi/6ekW+wZ5hilKjJ7Le2A==", "E407D296-0C0C-48F6-A7EE-BA3FC4667EB0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d57f3323-deec-484b-becf-b3fc77c14c7e", "AQAAAAEAACcQAAAAECDZEfzTNPazW7C9X4+HVHIseze3+hPKLFdEZV1OFAqHiiC76CLVwpTLvDaHJh3aKA==", "EB94C1DA-0572-430E-AEB6-E21BB29CDF08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c216b36-1c18-4298-bded-c2217a78a0c0", "AQAAAAEAACcQAAAAEC+/ATaCsW57EfA4z2nTfbLx9R14Go4RhZNviae8uiZPLLLbo8AbGdaqukxnz173NA==", "30C4EAF7-9C74-49EB-A2AD-03DCE49E4431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78f90f3-98ee-4d17-8b1c-85c8d950e21a", "AQAAAAEAACcQAAAAEFW9g9dcZQKKvoWbe9ntjjCFNm7rao+nPZekN9z759oNNCo8JtA+DoS91D8PzIg5Lg==", "428376DC-DF14-4EFB-ACD7-2DB53FF948F7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "221daf2e-f91e-4a0d-9ebf-7d690aaca6dd", "AQAAAAEAACcQAAAAEOuvODb0UnnSlTquuOhBJ6rPLk45c+Hu6r5DQm3/lUxb5NpogjsUCuwDOjwT9Qr6RQ==", "9F9AB887-AFC5-4692-A924-773D8462AD29" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                columns: new[] { "IssueDate", "SchoolId" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3057), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "IssueDate", "SchoolId" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3015), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "IssueDate", "SchoolId" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3072), new Guid("6cd00c11-b0cb-428a-9143-df5743105a92") });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 211, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_SchoolId",
                table: "FoodStamps",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Schools_SchoolId",
                table: "FoodStamps",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Schools_SchoolId",
                table: "FoodStamps");

            migrationBuilder.DropIndex(
                name: "IX_FoodStamps_SchoolId",
                table: "FoodStamps");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "FoodStamps");

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
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 28, 8, 29, 56, 90, DateTimeKind.Utc).AddTicks(8590));

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
    }
}
