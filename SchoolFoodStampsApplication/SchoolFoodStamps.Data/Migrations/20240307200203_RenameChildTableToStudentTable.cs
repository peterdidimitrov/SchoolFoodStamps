using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class RenameChildTableToStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps");

            migrationBuilder.DropIndex(
                name: "IX_FoodStamps_ChildId",
                table: "FoodStamps");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "FoodStamps");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "FoodStamps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Student identifier");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Children",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Student last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Child last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Children",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Student first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Child first name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Children",
                type: "datetime2",
                nullable: false,
                comment: "Student date of birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Child date of birth");

            migrationBuilder.AlterColumn<byte>(
                name: "ClassNumber",
                table: "Children",
                type: "tinyint",
                nullable: false,
                comment: "Student class number in school",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldComment: "Child class number in school");

            migrationBuilder.AlterColumn<string>(
                name: "ClassLetter",
                table: "Children",
                type: "nvarchar(1)",
                nullable: false,
                comment: "Student class letter in school",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldComment: "Child class letter in school");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Children",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Student identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Child identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcc1f1dc-724d-4f57-a8b9-b3ccf6262bcc", "AQAAAAEAACcQAAAAEKzfhDK7Z5MAD9h4X0siyvwvLPV159zhzO/VBJuJ1OzKePtC4vT/XcKfwHGkrpl+mQ==", "7979C476-1EB8-4A50-82BD-FAF516549BF2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97ac11e-4aee-4092-a208-b109769369fd", "AQAAAAEAACcQAAAAEF3VgE2QOC7xkJTISGomiQM0D6WwQvsuadfEE23T4fsaFAc1ciGBOQ1/mngpvpw/IQ==", "6C41BC8C-4887-4120-801C-93BC79EB3A8F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07832d9e-93b1-4d95-8d5b-ff60eb5541e8", "AQAAAAEAACcQAAAAEPy0r16Z6gv0B+oYD3Th9cJWJmEpSpIFgcqn67NZxtOa+apCtERQwZLLwERaH6TvKw==", "38D22A2F-E990-432A-966A-B24399C37791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d338d83-a864-452b-b2be-4deb5bdf7324", "AQAAAAEAACcQAAAAEMLJPdHc6Y14wSxDPsOHRCjqNNRI14SDRvruhQ1SKyAY6TP6l7oOAueuiV4XE4HCtA==", "D98F8E9B-1FD7-4430-B7D2-91C52891AD3E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e87801c1-9be4-4483-a620-8b3078762af4", "AQAAAAEAACcQAAAAELImbReek0pcPkVTKkvb1BtKXSb3LvbPUEXqX6110DHMJWJF7ALaI4G49JlwNEETaQ==", "5B0F36BB-2691-45E6-8FB7-06681FFF6863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2a38b7d-914d-4b2d-9da8-0ccae0a99f57", "AQAAAAEAACcQAAAAEL5pNtlku1USjIspp2hKNrjt3PBB9qTmuhlbz1Gqj2lFONS38YrasnbHZ6RZpzlM7g==", "C1749B39-593B-426D-9342-B1525AF10930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6e43d6-e269-460b-8699-df6b9c068706", "AQAAAAEAACcQAAAAEChXtr9Mwrx/W3J8vMFAmb9dkylfJmiuwVef4Z2ZkaBARMgemQaRsxkP4WWDjYMG7Q==", "F746FD71-A11E-4D9C-BDDC-27761B206639" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                columns: new[] { "IssueDate", "StudentId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4091), new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1") });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "IssueDate", "StudentId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4066), new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0") });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "IssueDate", "StudentId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4104), new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6") });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 129, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_StudentId",
                table: "FoodStamps",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Children_StudentId",
                table: "FoodStamps",
                column: "StudentId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Children_StudentId",
                table: "FoodStamps");

            migrationBuilder.DropIndex(
                name: "IX_FoodStamps_StudentId",
                table: "FoodStamps");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "FoodStamps");

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "FoodStamps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Child identifier");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Children",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Child last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Student last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Children",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Child first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Student first name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Children",
                type: "datetime2",
                nullable: false,
                comment: "Child date of birth",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Student date of birth");

            migrationBuilder.AlterColumn<byte>(
                name: "ClassNumber",
                table: "Children",
                type: "tinyint",
                nullable: false,
                comment: "Child class number in school",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldComment: "Student class number in school");

            migrationBuilder.AlterColumn<string>(
                name: "ClassLetter",
                table: "Children",
                type: "nvarchar(1)",
                nullable: false,
                comment: "Child class letter in school",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldComment: "Student class letter in school");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Children",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Child identifier",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Student identifier");

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

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                columns: new[] { "ChildId", "IssueDate" },
                values: new object[] { new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                columns: new[] { "ChildId", "IssueDate" },
                values: new object[] { new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                columns: new[] { "ChildId", "IssueDate" },
                values: new object[] { new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"), new DateTime(2024, 3, 6, 18, 54, 45, 247, DateTimeKind.Utc).AddTicks(5884) });

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_ChildId",
                table: "FoodStamps",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
