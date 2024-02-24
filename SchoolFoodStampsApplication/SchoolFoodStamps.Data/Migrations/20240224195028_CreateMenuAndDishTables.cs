using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class CreateMenuAndDishTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "FoodStamps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Menu identifier");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "FoodStamps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Food stamp status");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Menu identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false, comment: "Menu day of week"),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Menu date of creation"),
                    DateOfModify = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Menu date of modify")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                },
                comment: "Menu table");

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Dish identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Dish name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Dish description"),
                    Weight = table.Column<double>(type: "float", nullable: false, comment: "Dish weight"),
                    MenuId = table.Column<int>(type: "int", nullable: false, comment: "Menu identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishes_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                },
                comment: "Dish table");

            migrationBuilder.CreateIndex(
                name: "IX_FoodStamps_MenuId",
                table: "FoodStamps",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_MenuId",
                table: "Dishes",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodStamps_Menus_MenuId",
                table: "FoodStamps");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_FoodStamps_MenuId",
                table: "FoodStamps");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "FoodStamps");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "FoodStamps");
        }
    }
}
