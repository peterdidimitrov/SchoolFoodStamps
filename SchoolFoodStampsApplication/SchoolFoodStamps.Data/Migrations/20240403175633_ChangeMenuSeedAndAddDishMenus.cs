using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class ChangeMenuSeedAndAddDishMenus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0d8aae-2b9b-4513-9978-7c7614e1c7a1", "AQAAAAEAACcQAAAAEAK4/gaxDLI6t7PjhgUurUmq1qw1U2P0M5Ql28LFIGJCC4U477iPPe17L5ZBvNC65w==", "6F140441-5BE2-42EC-AE3E-93930C402416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c41a49-4cd8-4cbb-8c9f-30e2bfecf415", "AQAAAAEAACcQAAAAEGC2qB+Mudqbs2v+JFsSU3Crxmv5uCqJxkEsUVO9rK+CeTLE2ufqMlRCQcHlNtKbcw==", "68A0F7A0-E090-4E7C-A75A-E8B970151E7C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8160af5d-8dcd-4721-809e-0228d3db44dc", "AQAAAAEAACcQAAAAEPnabDtoaJwUDDB7dWQhzWGMq+ozfPBcoLQb0d7Kroit7csZyZyT+mWV6CXe8Ljiww==", "A2E808EE-A166-463C-B3EA-4F5AB7B80ACC" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bf9bbc0-4ad7-42e2-9b73-53c32c2d1e2a", "AQAAAAEAACcQAAAAEER+67aQpnM/ocBBCwzlKLmxe2Jc77mmxusKBj0HMETLnmLmiltg4d27ZTdzk991fA==", "722032B4-FFD0-449F-8409-A3F05F93BA30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b37cda0-9530-4f77-ac23-b05154d70a95", "AQAAAAEAACcQAAAAEKS5Rf1FUF3iv14FDvUKRr8gOwziFW09lGlaAVjUGlwlaBHavefVKCLSTaHIVOcyVg==", "54E7576F-50FC-4DB6-8B1D-D4CDC32F8720" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433f5b96-ea5b-4096-ac30-1bb6b23e6430", "AQAAAAEAACcQAAAAEOrz6bjD/0+gReA800e6qwCz/3y9a55StxM23LTCSVT7JrK0gH4mcnZ6669Gnb+h2w==", "EE97F6BC-2617-470B-9891-DC879894159F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb912c7-ace5-4f52-a5b0-a324d8d74426", "AQAAAAEAACcQAAAAELv4KieESJnusAq2r6rhMO7Av9ETG9HWkwlzazDtoXYkb45AHJZSecuRDO4kHEsY8w==", "1BEC69BC-0484-42ED-AF4A-2E0445738921" });

            migrationBuilder.InsertData(
                table: "DishMenus",
                columns: new[] { "DishId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 4 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 5 },
                    { 14, 5 },
                    { 15, 5 }
                });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 567, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 3, 17, 56, 31, 566, DateTimeKind.Utc).AddTicks(2763));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "DishMenus",
                keyColumns: new[] { "DishId", "MenuId" },
                keyValues: new object[] { 15, 5 });

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

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "CateringCompanyId", "Description", "Name", "Weight" },
                values: new object[,]
                {
                    { 16, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Grilled chicken and vegetable skewers (using cherry tomatoes, zucchini, and mushrooms). Served with a side of whole wheat couscous.", "Chicken and Veggie Skewers", 250.0 },
                    { 17, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat pita bread served with hummus and falafel balls. Accompanied by a side of sliced cucumbers and cherry tomatoes.", "Pita Bread with Hummus and Falafel", 320.0 },
                    { 18, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Blend of mixed berries, low-fat yogurt, and a splash of orange juice.", "Mixed Berry Smoothie", 300.0 },
                    { 19, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Whole wheat bread filled with egg salad (chopped hard-boiled eggs mixed with light mayo and mustard). Served with a side of carrot sticks and ranch dressing for dipping.", "Egg Salad Sandwich", 250.0 },
                    { 20, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Quinoa mixed with diced mango, black beans, red bell peppers, and cilantro. Tossed in a honey-lime dressing.", "Mango and Black Bean Quinoa Salad", 200.0 },
                    { 21, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "Assorted cheese slices served with whole grain crackers and apple slices.", "Cheese and Crackers Plate", 200.0 }
                });

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("03c7dd57-8981-43af-ad5f-2a817214fb3e"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("e3bcc07a-9a2f-4c54-8135-a5f1e21ed99d"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "FoodStamps",
                keyColumn: "Id",
                keyValue: new Guid("fb33981c-ae8c-48ea-bf27-3dc5a763d7f9"),
                column: "IssueDate",
                value: new DateTime(2024, 3, 31, 18, 37, 39, 214, DateTimeKind.Utc).AddTicks(3072));

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
        }
    }
}
