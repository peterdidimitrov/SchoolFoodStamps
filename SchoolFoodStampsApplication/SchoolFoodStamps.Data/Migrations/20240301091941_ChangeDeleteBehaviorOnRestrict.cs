using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ChangeDeleteBehaviorOnRestrict : Migration
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
                name: "FK_FoodStamps_CateringCompanies_CateringCompanyId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Parents_ParentId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_CateringCompanies_CateringCompanyId",
                table: "Schools");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(3928),
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3464),
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4582),
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(4838),
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16d31ee0-a243-4a40-8927-4871b887dcc2", "AQAAAAEAACcQAAAAEDQ5cYZlXotx4GApl6lX91DPfdfBnzk07qEe0I8A+8wUgnVouS7kbRD3sv4iO5xcjQ==", "F5009C17-65ED-4574-AF8B-2C4EE54356C6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "585026d3-70d8-423b-9eff-86cbedddd4be", "AQAAAAEAACcQAAAAEEFO//lhvqPeVCeBiuns+E/tPIYzbTSN3/sNS72tAhYypPHyYP/APtyApThbYE+j4A==", "B4875D0B-C647-4D32-ACE3-2815061916F9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a71ae98c-16c0-492e-86ea-9965cdfb0e52", "AQAAAAEAACcQAAAAEG0mnKJnfP41qpzh7AVu9XO5tYavVBNk7Y+g4WwvtIf9MMGFswL8N0984YclJX6mSg==", "43BA35F6-8F82-46DC-8F13-7BA2D4042D9A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9339f2f-d310-4a66-904c-15acec909682", "AQAAAAEAACcQAAAAEEOZyCd2th4nh5alDo+Q4rhnCZzbduA3vzwMY6+SbxcfbdilkxPuwq32tqqYPA6BFg==", "6797E325-4DD2-472A-BD16-9C35391F9D05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ade6862-40fa-4190-b5f8-309ecc34a526", "AQAAAAEAACcQAAAAEE+TBOsG0XT7q5IA2b/6ooOZ8tSM49BJq8FJ6iaSdbvUUHH2nPm5HwDDVqsfVmOHXQ==", "67AE02E8-7F1F-4A33-B552-7AAE4D63E50C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1cb8b2-27d4-4c21-a3da-4b9f94245e6c", "AQAAAAEAACcQAAAAELWHwSdefwOlYjbz3QPpv4g8BX7uBmHFY6icqE8B1nfeOgqtYBt2rAtbDfmUurLflw==", "5235D42F-F9A6-44BB-A89D-C3356BE3B3C2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76a3a5a5-9f2d-4810-93ef-9843ee087d1f", "AQAAAAEAACcQAAAAEN9uF0NyGIdQHobW3G+XPSiaNKqPBBP3mIWZMRGPYsqMl/YBa6TNFvlvVD21HCwgAQ==", "E4C9195D-60B4-4ABC-9328-BA5193637A38" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4052));

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
                name: "FK_FoodStamps_CateringCompanies_CateringCompanyId",
                table: "FoodStamps",
                column: "CateringCompanyId",
                principalTable: "CateringCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Parents_ParentId",
                table: "FoodStamps",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_CateringCompanies_CateringCompanyId",
                table: "Schools",
                column: "CateringCompanyId",
                principalTable: "CateringCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_Children_Schools_SchoolId",
                table: "Children");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_CateringCompanies_CateringCompanyId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Parents_ParentId",
                table: "FoodStamps");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_CateringCompanies_CateringCompanyId",
                table: "Schools");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3464),
                comment: "Menu date of creation",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(3928),
                oldComment: "Menu date of creation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "FoodStamps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(4838),
                comment: "Food stamp issue date",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 9, 19, 41, 348, DateTimeKind.Utc).AddTicks(4582),
                oldComment: "Food stamp issue date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf59b165-1ac2-4208-b865-0e62396383b6", "AQAAAAEAACcQAAAAEA0nmAn6cjOTN0gqmd87tHeMIBoqAmYY7TFIo1PSRaYz/538i7XDLC6tmagA+jtVnQ==", "95A3305A-31F4-4382-BDF5-D0616E28AE31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50245ef7-40ac-417d-8d01-c5b3ed9ecb13", "AQAAAAEAACcQAAAAEEWZt+MV9iYnCylJ3jqs6Npnk+MtQ1m9zbcDFtwnebMY9DILPdAvfDGA6i5ma0GuAA==", "6FE3B2D9-F998-4D0A-A779-FEF0C61A7459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b718ab8c-51a4-4dca-8ce2-b177bf17b4eb", "AQAAAAEAACcQAAAAEBe+nWhLFEdJHb0cu3DLchBtia2SnGlKa3xo4Rp0EwU8gSeF/pdzmkl4z0psmilnIQ==", "DC987121-684C-4A8C-8828-0B60A232F85E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f3cf37-ab82-48f4-ae0c-f27875e6859b", "AQAAAAEAACcQAAAAECgfUNLqD01q/s8poyIkSaHfBa8DbkNo+AOqhJOb5UplHov7bbZoPvdVSf0d5tcMqQ==", "4380F041-223B-428B-A45A-4741CB2EE056" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d713650-260d-42dc-87c7-c728eb7f998c", "AQAAAAEAACcQAAAAEJIGyudE5PvckVsDeeFCLhjgATYvmdogydXd2c1tD4wpjKy/KdH71RFE6ItOrmubYw==", "BFF8F559-4654-4EC8-8860-8041F24530C0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acc4f75-f674-48a9-b124-fb8aebbc564a", "AQAAAAEAACcQAAAAEGbABQaCeAErkeeaSdyb8XeE+M5D34af3LIpqd38LknEXClCkkvvbXpbQT20/BDqDg==", "2F2DC114-6F12-4D86-95B7-B4088C9BCF3B" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01a5013-87a4-4fca-bebf-ef0ad5377b6f", "AQAAAAEAACcQAAAAEPftdjnGwIepRqslrJky2uKtgsuInlTwHEuEX+mp8Fv665tmOJyGrp4JEQ2OL+QkRA==", "0A19F215-F283-4540-A728-8FF965BDDD5F" });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Parents_ParentId",
                table: "Children",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Schools_SchoolId",
                table: "Children",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_CateringCompanies_CateringCompanyId",
                table: "FoodStamps",
                column: "CateringCompanyId",
                principalTable: "CateringCompanies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Children_ChildId",
                table: "FoodStamps",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Parents_ParentId",
                table: "FoodStamps",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_CateringCompanies_CateringCompanyId",
                table: "Schools",
                column: "CateringCompanyId",
                principalTable: "CateringCompanies",
                principalColumn: "Id");
        }
    }
}
