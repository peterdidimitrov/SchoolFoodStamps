using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class CreateFoodStampTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodStamps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Food stamp identifier"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Food stamp price"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Food stamp issue date"),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Food stamp use date"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Food stamp expiry date"),
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
                        name: "FK_FoodStamps_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                },
                comment: "Food stamp table");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_CateringCompanyId",
                table: "FoodStamps",
                column: "CateringCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_ChildId",
                table: "FoodStamps",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_ParentId",
                table: "FoodStamps",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodStamps");
        }
    }
}
