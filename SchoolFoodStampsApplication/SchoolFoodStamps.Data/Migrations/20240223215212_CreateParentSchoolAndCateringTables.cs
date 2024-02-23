using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class CreateParentSchoolAndCateringTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CateringCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Catering company name"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Catering company address"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Catering company Identification Number"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Parent address"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
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
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "School identifier"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "School name"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "School address"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CateringCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Catering company identifier"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
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

            migrationBuilder.CreateIndex(
                name: "IX_CateringCompanies_UserId",
                table: "CateringCompanies",
                column: "UserId");

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
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "CateringCompanies");
        }
    }
}
