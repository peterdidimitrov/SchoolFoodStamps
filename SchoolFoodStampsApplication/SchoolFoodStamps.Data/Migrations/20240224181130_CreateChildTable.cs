using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class CreateChildTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Child identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Child first name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Child last name"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Child date of birth"),
                    ClassNumber = table.Column<int>(type: "int", nullable: false, comment: "Child class"),
                    ClassLetter = table.Column<string>(type: "nvarchar(1)", nullable: false, comment: "Child class"),
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

            migrationBuilder.CreateIndex(
                name: "IX_Children_ParentId",
                table: "Children",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_SchoolId",
                table: "Children",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");
        }
    }
}
