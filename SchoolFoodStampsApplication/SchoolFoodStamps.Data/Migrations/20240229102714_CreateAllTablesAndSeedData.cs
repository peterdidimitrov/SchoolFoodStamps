using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class CreateAllTablesAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CateringCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Catering company name"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Catering company address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Catering company phone number"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Catering company Identification Number"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateringCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CateringCompanies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Catering company table");

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Parent identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Parent first name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Parent last name"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Parent address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Parent phone number"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Parent table");

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Dish identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Dish name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Dish description"),
                    Weight = table.Column<double>(type: "float", nullable: false, comment: "Dish weight"),
                    CateringCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishes_CateringCompanies_CateringCompanyId",
                        column: x => x.CateringCompanyId,
                        principalTable: "CateringCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Dish table");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Menu identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false, comment: "Menu day of week"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3464), comment: "Menu date of creation"),
                    DateOfModify = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Menu date of modify"),
                    CateringCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_CateringCompanies_CateringCompanyId",
                        column: x => x.CateringCompanyId,
                        principalTable: "CateringCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Menu table");

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "School identifier"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "School name"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "School address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "School phone number"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CateringCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schools_CateringCompanies_CateringCompanyId",
                        column: x => x.CateringCompanyId,
                        principalTable: "CateringCompanies",
                        principalColumn: "Id");
                },
                comment: "School table");

            migrationBuilder.CreateTable(
                name: "AllergenDishes",
                columns: table => new
                {
                    AllergenId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergenDishes", x => new { x.AllergenId, x.DishId });
                    table.ForeignKey(
                        name: "FK_AllergenDishes_Allergens_AllergenId",
                        column: x => x.AllergenId,
                        principalTable: "Allergens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergenDishes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishMenus",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishMenus", x => new { x.DishId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_DishMenus_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DishMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Child identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Child first name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Child last name"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Child date of birth"),
                    ClassNumber = table.Column<byte>(type: "tinyint", nullable: false, comment: "Child class number in school"),
                    ClassLetter = table.Column<string>(type: "nvarchar(1)", nullable: false, comment: "Child class letter in school"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Parent identifier"),
                    SchoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "School identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Children_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                },
                comment: "Child table");

            migrationBuilder.CreateTable(
                name: "FoodStamps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Food stamp identifier"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 5.00m, comment: "Food stamp price"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(4838), comment: "Food stamp issue date"),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Food stamp use date"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Food stamp expiry date"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Food stamp status"),
                    MenuId = table.Column<int>(type: "int", nullable: false, comment: "Menu identifier"),
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Child identifier"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Parent identifier"),
                    CateringCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStamps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodStamps_CateringCompanies_CateringCompanyId",
                        column: x => x.CateringCompanyId,
                        principalTable: "CateringCompanies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodStamps_Children_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Children",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodStamps_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodStamps_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                },
                comment: "Food stamp table");

            migrationBuilder.InsertData(
                table: "Allergens",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gluten" },
                    { 2, "Dairy" },
                    { 3, "Eggs" },
                    { 4, "Fish" },
                    { 5, "Peanuts" },
                    { 6, "SeeFood" },
                    { 7, "Soy" },
                    { 8, "TreeNuts" },
                    { 9, "Wheat" },
                    { 10, "Celery" },
                    { 11, "Sulfites" },
                    { 12, "Lupin" },
                    { 13, "Sesame" },
                    { 14, "Mustard" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"), 0, "bf59b165-1ac2-4208-b865-0e62396383b6", "gosho@yahoo.com", false, false, null, "GOSHO@YAHOO.COM", "GOSHO@YAHOO.COM", "AQAAAAEAACcQAAAAEA0nmAn6cjOTN0gqmd87tHeMIBoqAmYY7TFIo1PSRaYz/538i7XDLC6tmagA+jtVnQ==", null, false, "95A3305A-31F4-4382-BDF5-D0616E28AE31", false, "gosho@yahoo.com" },
                    { new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"), 0, "50245ef7-40ac-417d-8d01-c5b3ed9ecb13", "patriarh.evtimi@abv.bg", false, false, null, "PATRIARH.EVTIMI@ABV.BG", "PATRIARH.EVTIMI@ABV.BG", "AQAAAAEAACcQAAAAEEWZt+MV9iYnCylJ3jqs6Npnk+MtQ1m9zbcDFtwnebMY9DILPdAvfDGA6i5ma0GuAA==", null, false, "6FE3B2D9-F998-4D0A-A779-FEF0C61A7459", false, "patriarh.evtimi@abv.bg" },
                    { new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"), 0, "b718ab8c-51a4-4dca-8ce2-b177bf17b4eb", "pesho@abv.bg", false, false, null, "PESHO@ABV.BG", "PESHO@ABV.BG", "AQAAAAEAACcQAAAAEBe+nWhLFEdJHb0cu3DLchBtia2SnGlKa3xo4Rp0EwU8gSeF/pdzmkl4z0psmilnIQ==", null, false, "DC987121-684C-4A8C-8828-0B60A232F85E", false, "pesho@abv.bg" },
                    { new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"), 0, "29f3cf37-ab82-48f4-ae0c-f27875e6859b", "dimitrichko_admin@org.bg", false, false, null, "DIMITRICHKO_ADMIN@ORG.BG", "DIMITRICHKO_ADMIN@ORG.BG", "AQAAAAEAACcQAAAAECgfUNLqD01q/s8poyIkSaHfBa8DbkNo+AOqhJOb5UplHov7bbZoPvdVSf0d5tcMqQ==", null, false, "4380F041-223B-428B-A45A-4741CB2EE056", false, "dimitrichko_admin@org.bg" },
                    { new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"), 0, "3d713650-260d-42dc-87c7-c728eb7f998c", "hristo.botev@abv.bg", false, false, null, "HRISTO.BOTEV@ABV.BG", "HRISTO.BOTEV@ABV.BG", "AQAAAAEAACcQAAAAEJIGyudE5PvckVsDeeFCLhjgATYvmdogydXd2c1tD4wpjKy/KdH71RFE6ItOrmubYw==", null, false, "BFF8F559-4654-4EC8-8860-8041F24530C0", false, "hristo.botev@abv.bg" },
                    { new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"), 0, "4acc4f75-f674-48a9-b124-fb8aebbc564a", "pesho@yahoo.com", false, false, null, "PESHO@YAHOO.COM", "PESHO@YAHOO.COM", "AQAAAAEAACcQAAAAEGbABQaCeAErkeeaSdyb8XeE+M5D34af3LIpqd38LknEXClCkkvvbXpbQT20/BDqDg==", null, false, "2F2DC114-6F12-4D86-95B7-B4088C9BCF3B", false, "pesho@yahoo.com" },
                    { new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), 0, "e01a5013-87a4-4fca-bebf-ef0ad5377b6f", "test@test.bg", false, false, null, "TEST@TEST.BG", "TEST@TEST.BG", "AQAAAAEAACcQAAAAEPftdjnGwIepRqslrJky2uKtgsuInlTwHEuEX+mp8Fv665tmOJyGrp4JEQ2OL+QkRA==", null, false, "0A19F215-F283-4540-A728-8FF965BDDD5F", false, "test@test.bg" }
                });

            migrationBuilder.InsertData(
                table: "CateringCompanies",
                columns: new[] { "Id", "Address", "IdentificationNumber", "Name", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), null, "121756889", "HealtyFoodForChildren", null, new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5") },
                    { new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), null, "121756888", "ET SAM-DPD", null, new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d") }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), "Sofia, Bulgaria", "Petar", "Ivanov", "0888123456", new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d") },
                    { new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), "Stara Zagora, Bulgaria", "Georgi", "Petrov", "0888123444", new Guid("4aa8654e-1465-4839-814c-a62a69d532e9") }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "CateringCompanyId", "Description", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat bread filled with sliced turkey breast, lettuce, and low-fat cheese. Served with a side of cherry tomatoes and cucumber slices.", "Turkey and Cheese Sandwich", 250.0 },
                    { 2, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat pasta mixed with assorted chopped vegetables (such as bell peppers, cherry tomatoes, and broccoli). Tossed in a light Italian dressing.", "Vegetable Pasta Salad", 200.0 },
                    { 3, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Mixed fruit salad (such as strawberries, grapes, and kiwi) served with a dollop of low-fat yogurt.", "Fruit Salad with Yogurt", 150.0 },
                    { 4, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Grilled chicken strips, romaine lettuce, and Caesar dressing wrapped in a whole wheat tortilla. Served with a side of carrot sticks and hummus.", "Chicken Caesar Wrap", 280.0 },
                    { 5, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Quinoa mixed with black beans, corn, diced bell peppers, and cilantro. Drizzled with a squeeze of lime juice.", "Quinoa and Black Bean Bowl", 250.0 },
                    { 6, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Salad greens topped with cucumber slices, cherry tomatoes, feta cheese, and olives. Served with a side of whole grain pita bread.", "Greek Salad", 200.0 },
                    { 7, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat wrap filled with hummus, shredded carrots, spinach leaves, and sliced bell peppers. Served with a side of sugar snap peas.", "Hummus and Veggie Wrap", 270.0 },
                    { 8, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Homemade vegetable soup (carrots, celery, onions, and beans) served with whole grain crackers on the side.", "Vegetable Soup with Whole Grain Crackers", 300.0 },
                    { 9, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Slices of apple served with cheese cubes and whole grain crackers.", "Apple and Cheese Plate", 200.0 },
                    { 10, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Halved bell peppers filled with tuna salad (made with canned tuna, light mayo, diced celery, and a dash of lemon juice). Served with a side of carrot sticks and ranch dressing for dipping.", "Tuna Salad Stuffed Bell Peppers", 300.0 },
                    { 11, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Brown rice sushi rolls filled with cucumber, avocado, and cooked shrimp. Served with a side of edamame.", "Brown Rice Sushi Rolls", 280.0 },
                    { 12, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Layers of low-fat yogurt, granola, and mixed berries.", "Yogurt Parfait", 200.0 },
                    { 13, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat tortillas filled with sautéed bell peppers, onions, spinach, and shredded cheese. Served with a side of salsa for dipping.", "Veggie and Cheese Quesadillas", 250.0 },
                    { 14, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Roasted sweet potatoes mixed with black beans, corn, and diced red onions. Tossed in a lime vinaigrette dressing.", "Sweet Potato and Black Bean Salad", 200.0 },
                    { 15, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Sliced cucumbers and cherry tomatoes tossed in a light balsamic vinaigrette dressing.", "Cucumber and Tomato Salad", 150.0 },
                    { 16, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Grilled chicken and vegetable skewers (using cherry tomatoes, zucchini, and mushrooms). Served with a side of whole wheat couscous.", "Chicken and Veggie Skewers", 250.0 },
                    { 17, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat pita bread served with hummus and falafel balls. Accompanied by a side of sliced cucumbers and cherry tomatoes.", "Pita Bread with Hummus and Falafel", 320.0 },
                    { 18, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Blend of mixed berries, low-fat yogurt, and a splash of orange juice.", "Mixed Berry Smoothie", 300.0 },
                    { 19, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat bread filled with egg salad (chopped hard-boiled eggs mixed with light mayo and mustard). Served with a side of carrot sticks and ranch dressing for dipping.", "Egg Salad Sandwich", 250.0 },
                    { 20, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Quinoa mixed with diced mango, black beans, red bell peppers, and cilantro. Tossed in a honey-lime dressing.", "Mango and Black Bean Quinoa Salad", 200.0 },
                    { 21, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Assorted cheese slices served with whole grain crackers and apple slices.", "Cheese and Crackers Plate", 200.0 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CateringCompanyId", "CreatedOn", "DateOfModify", "DayOfWeek" },
                values: new object[,]
                {
                    { 1, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3636), null, 1 },
                    { 2, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3655), null, 2 },
                    { 3, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3656), null, 3 },
                    { 4, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3659), null, 4 },
                    { 5, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3664), null, 5 },
                    { 6, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3665), null, 6 },
                    { 7, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(3667), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CateringCompanyId", "IdentificationNumber", "Name", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("6cd00c11-b0cb-428a-9143-df5743105a92"), "bul. Al. Stamboliiski 33", new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), "121756787", "51 SOU Hristo  Botev", "02 987 4243", new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421") },
                    { new Guid("e3af4b8e-8f07-4962-838e-670bd305758f"), "bul. Hristo Botev 41", new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "121756886", "41 OU Patriarh Evtimii", "02 987 6543", new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0") }
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "ClassLetter", "ClassNumber", "DateOfBirth", "FirstName", "LastName", "ParentId", "SchoolId" },
                values: new object[] { new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"), "A", (byte)1, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe", new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "ClassLetter", "ClassNumber", "DateOfBirth", "FirstName", "LastName", "ParentId", "SchoolId" },
                values: new object[] { new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"), "B", (byte)1, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Doe", new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), new Guid("6cd00c11-b0cb-428a-9143-df5743105a92") });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "ClassLetter", "ClassNumber", "DateOfBirth", "FirstName", "LastName", "ParentId", "SchoolId" },
                values: new object[] { new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"), "B", (byte)3, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), new Guid("e3af4b8e-8f07-4962-838e-670bd305758f") });

            migrationBuilder.InsertData(
                table: "FoodStamps",
                columns: new[] { "Id", "CateringCompanyId", "ChildId", "ExpiryDate", "IssueDate", "MenuId", "ParentId", "Price", "Status", "UseDate" },
                values: new object[] { new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"), new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new Guid("49d7ed09-30b0-4b52-b3d4-b2c7c318ccd1"), new DateTime(2024, 9, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6386), 2, new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), 5.00m, 1, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "FoodStamps",
                columns: new[] { "Id", "CateringCompanyId", "ChildId", "ExpiryDate", "IssueDate", "MenuId", "ParentId", "Price", "Status", "UseDate" },
                values: new object[] { new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"), new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new Guid("a1abc1d5-3718-4639-ab42-d7a1e9a0fcb0"), new DateTime(2024, 9, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6317), 1, new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), 5.00m, 1, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "FoodStamps",
                columns: new[] { "Id", "CateringCompanyId", "ChildId", "ExpiryDate", "IssueDate", "MenuId", "ParentId", "Price", "Status", "UseDate" },
                values: new object[] { new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"), new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), new Guid("69d5eefd-e902-4706-8bd8-b523bb24b9b6"), new DateTime(2024, 9, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 10, 27, 14, 8, DateTimeKind.Utc).AddTicks(6401), 3, new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), 5.00m, 1, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AllergenDishes_DishId",
                table: "AllergenDishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CateringCompanies_UserId",
                table: "CateringCompanies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_ParentId",
                table: "Children",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_SchoolId",
                table: "Children",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CateringCompanyId",
                table: "Dishes",
                column: "CateringCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DishMenus_MenuId",
                table: "DishMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_CateringCompanyId",
                table: "FoodStamps",
                column: "CateringCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_ChildId",
                table: "FoodStamps",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_MenuId",
                table: "FoodStamps",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_ParentId",
                table: "FoodStamps",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CateringCompanyId",
                table: "Menus",
                column: "CateringCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CateringCompanyId",
                table: "Schools",
                column: "CateringCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_UserId",
                table: "Schools",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergenDishes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DishMenus");

            migrationBuilder.DropTable(
                name: "FoodStamps");

            migrationBuilder.DropTable(
                name: "Allergens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "CateringCompanies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
