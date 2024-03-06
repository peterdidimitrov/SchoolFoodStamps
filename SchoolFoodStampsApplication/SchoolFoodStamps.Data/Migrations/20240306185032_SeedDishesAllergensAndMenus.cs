using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedDishesAllergensAndMenus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0511ca-9044-41eb-ab76-575c376c8a80", "AQAAAAEAACcQAAAAEI9dT6Yjoiro0Zr00j2VPF+40LL0KsbkDs9adUrf4fZdDoyvcsSY0Yi8QLGj2RbP0A==", "0909A182-9C69-4386-A7B6-B56161D63F15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5161d5fa-2c14-4601-ba89-cf3ad33cff32", "AQAAAAEAACcQAAAAEL6QQo5ULYEVqKpjqCNK4VdnFPDUdW3D3Aauq/ZKbz/6YBNbjJfiZCFrlOsAnfQGCQ==", "7539862E-1024-403C-AD58-0DC9E69DCEA2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c016d8-3729-40c7-ae69-c18b22c5539f", "AQAAAAEAACcQAAAAEL1HGemI+p10fTy50DvEnC6Thq06biZvNrj/rRUhkVID20hzBYEgN6fqs2LeE7q/jQ==", "76A40EA1-D94A-42EA-8FF3-56CDC363EC26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e43b4ce9-315f-40fc-a13e-8e6d5552a475", "AQAAAAEAACcQAAAAEKPVHu3wjzUzu527MVGzFpMt82sGbk7J1dGsY0/r8TYeN+0k6eTTEVDOY7gpGmOcpg==", "089CC561-39EC-47A9-8866-EC16F7012684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71a3dc79-03f7-4bb2-a647-20eed87aa64a", "AQAAAAEAACcQAAAAEH0SkDhtEmeMhKudP/r9SCvc8q62sY2u2ACq4n+qJUv8XGQhxTjBIxfP2DDdv+nnEw==", "F14C619E-F178-4437-8337-15FDB08E28E2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7660e3a1-9866-430b-9ba5-b6d2f2d33a7a", "AQAAAAEAACcQAAAAEPZ1orT8255GB7FyiKHNBQMKPKvbtqfwYdbOTE6B5FG3bLm4W/z7pvcs23CGCF4P0Q==", "17A757BB-27CA-43BB-A30F-12574AE39AF0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13663739-c62a-438f-8c3f-3ce8e824303a", "AQAAAAEAACcQAAAAEG3mfxG+sAlPE1/JvdTpmtk90cMKsbBfoK51Xz51IthgU3rtVTMXt8NeTqVbjDVBag==", "6BE92828-8E46-4A82-A2F0-299AAD28072A" });

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
                    { 1, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6218), null, 1 },
                    { 2, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6241), null, 2 },
                    { 3, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6245), null, 3 },
                    { 4, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6248), null, 4 },
                    { 5, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6257), null, 5 },
                    { 6, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6260), null, 6 },
                    { 7, new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), new DateTime(2024, 3, 6, 18, 50, 30, 926, DateTimeKind.Utc).AddTicks(6263), null, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 15);

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

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d71d6f5-7cf2-4a78-b1a5-a7966044ee06", "AQAAAAEAACcQAAAAEEugaQdtP+m6079qYnjaZq2rSHYnqgI6PmhVXokg+W9PptGiJY0qRHqsp9mB0kR14A==", "C820F9B9-145A-4903-8CEA-5EDFA6709923" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ffbd90-88aa-4679-8ccb-c525879918ba", "AQAAAAEAACcQAAAAEDDyANpdD5r0idCkNvA+w18+zh+EhtZRLFNFJ0JEHxGASYyu96G7RlG5eBOqP4fq2g==", "3E4D9F50-E0FE-41F0-827D-DBCD89DFB5FD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28f57c2-afcc-4c15-a7d5-c7b460899411", "AQAAAAEAACcQAAAAENtAF+HcRPn2dPQak/jCHConwvc6DpJ7bV0EtPmRgQ4z53gpKX8apNxuAbBdmsWKtA==", "C6D4F897-2932-487B-8F28-715DDA4C3BBF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d673c98-9c3c-4cd1-be62-42b6384d05d3", "AQAAAAEAACcQAAAAEGhUwl6OB3SOnxsSomXhzdcgOV8MAd6EY+6e9Wasei8CyMCo0SXYnqCfLre5d2vHgA==", "2F6E1DCB-9D5B-4CD1-BB4A-46810CAFDAEF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "316e687f-0874-472d-b1cb-8b7157a5caa4", "AQAAAAEAACcQAAAAEGbYJW3y39lNrFvzZ3xRp0mZw87tnYVSkdFLrwvDQJ+8t7SuAA7NguC19qbGTcDXbw==", "75CB12EE-2BE3-42E8-B469-69076A457C41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a19b59-2fd5-417e-b87d-2041ab197d18", "AQAAAAEAACcQAAAAEKlKTP5FItfEWYSlEzzEa0ZOd0Q3tHcRBQ18Sq12rBQVvEVyEfN5YSSpWiv+sHIbTA==", "8DD919D2-BC6C-401D-9D40-3A129A6D80D6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcbd2bcb-fb55-4058-b129-990c38a863a1", "AQAAAAEAACcQAAAAEEeDoeAfYsnDlojCIe+vpk4wuDxzqyhUt96Iw1Xf0E5H4jN//zv4dS/Th8HMEaFywg==", "D8B4C286-46D4-4331-ACF2-E5A54AC744D4" });
        }
    }
}
