using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class RenameChildrenInDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Children_Schools_SchoolId",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Children_StudentId",
                table: "FoodStamps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Children",
                table: "Children");

            migrationBuilder.RenameTable(
                name: "Children",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Children_SchoolId",
                table: "Students",
                newName: "IX_Students_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Children_ParentId",
                table: "Students",
                newName: "IX_Students_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a050bd39-daf1-4380-a141-bbbcbbe9f297", "AQAAAAEAACcQAAAAEDGQmfuiE07ySORSau7mkOj8TwPITOEwQfGTqjZZRB7AJiZtsbX+9wE0/Jrg2x3M6A==", "F2210FF3-6EA6-402C-B4E8-277D3251D1A6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285bafd4-09bf-4c82-9379-617ebbce71fd", "AQAAAAEAACcQAAAAEHkG/8ZHkcaEcYv+b6jVJFCunrhG1i2350U0EaLDiVRGWEEyQCZFt7DzBFgx+LOpIg==", "CA84D5A9-9815-4411-A599-646BA471EB96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f7d0fe-89d2-4836-8607-8a852eb935bb", "AQAAAAEAACcQAAAAEPQhE9YnMQtff1QoZW20Ytb4pcO7nClmza9vTTuNyxq0vQoUDbnX5021rT+H8/UWSA==", "E5A53906-BDA6-448A-B884-96F70D6C3612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d473e593-e1a9-476d-b6ea-4474cd03f510", "AQAAAAEAACcQAAAAEH0qJxq5WEZ8H8axUCdkmhgrJKYXcHl+oe6N6cxdXeqW3ZIva1QSyvLOOhbHOYEiPg==", "BD262D63-2372-4104-A878-A01BE68014B9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a711b318-4d33-4319-8c35-404e01703952", "AQAAAAEAACcQAAAAEBdfdcVmxKJJZrsTdB8piYfmrDzLoWozPDsY+2jw9wOt4jxOlcXL+XdqoBqr+Rax2A==", "029C5AC4-D2E6-4710-93F3-E2F33BA86B17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a248f568-1201-43b6-9d26-c606b3d85aaf", "AQAAAAEAACcQAAAAEC4vxbUD+tFBHJsEpWO53zdHHA/wULQ65RL05y+xaWtnMO+oE/YFlCzvWiltHfm3Cg==", "5C0E9F28-60BE-4DED-A4BE-C8D2506F08FB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e230c4b8-40f6-409e-a5cd-8004c4170d97", "AQAAAAEAACcQAAAAEJvx8ZTR2IoHYj8kEeOE8ATV5ycFbG3Cf5yPLL8oQ9It4/B7slmvYLv9oNe0ywv9DQ==", "D3F7CEAE-CBD4-4520-ABAC-FBE305F241C8" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 668, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 7, 20, 7, 27, 667, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Students_StudentId",
                table: "FoodStamps",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Students_StudentId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Children");

            migrationBuilder.RenameIndex(
                name: "IX_Students_SchoolId",
                table: "Children",
                newName: "IX_Children_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ParentId",
                table: "Children",
                newName: "IX_Children_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Children",
                table: "Children",
                column: "Id");

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
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 7, 20, 2, 2, 130, DateTimeKind.Utc).AddTicks(4104));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Schools_SchoolId",
                table: "Children",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Children_StudentId",
                table: "FoodStamps",
                column: "StudentId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
