using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Services.Tests
{
    public static class DataBaseSeeder
    {
        public static List<ApplicationUser> Users = null!;
        public static List<CateringCompany> Companies = null!;
        public static List<School> Schools = null!;
        public static List<Parent> Parents = null!;
        public static List<Allergen> Allergens = null!;
        public static List<Dish> Dishes = null!;
        public static List<AllergenDish> AllergenDishes = null!;
        public static List<Menu> Menus = null!;
        public static List<DishMenu> DishMenus = null!;
        public static List<Student> Students = null!;
        public static List<FoodStamp> FoodStamps = null!;

        public static void SeedDataBase(SchoolFoodStampsDbContext dbContext)
        {

            Users = new List<ApplicationUser>()
            {
                new ApplicationUser()
            {
                Id = Guid.Parse("AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E"),
                UserName = "dimitrichko_admin@org.bg",
                NormalizedUserName = "DIMITRICHKO_ADMIN@ORG.BG",
                Email = "dimitrichko_admin@org.bg",
                NormalizedEmail = "DIMITRICHKO_ADMIN@ORG.BG"
            },
                new ApplicationUser()
            {
                Id = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                UserName = "test@test.bg",
                NormalizedUserName = "TEST@TEST.BG",
                Email = "test@test.bg",
                NormalizedEmail = "TEST@TEST.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5"),
                UserName = "pesho@abv.bg",
                NormalizedUserName = "PESHO@ABV.BG",
                Email = "pesho@abv.bg",
                NormalizedEmail = "PESHO@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0"),
                UserName = "patriarh.evtimi@abv.bg",
                NormalizedUserName = "PATRIARH.EVTIMI@ABV.BG",
                Email = "patriarh.evtimi@abv.bg",
                NormalizedEmail = "PATRIARH.EVTIMI@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421"),
                UserName = "hristo.botev@abv.bg",
                NormalizedUserName = "HRISTO.BOTEV@ABV.BG",
                Email = "hristo.botev@abv.bg",
                NormalizedEmail = "HRISTO.BOTEV@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("F4E56355-18AE-42A7-B082-25A2CF382D3D"),
                UserName = "pesho@yahoo.com",
                NormalizedUserName = "PESHO@YAHOO.COM",
                Email = "pesho@yahoo.com",
                NormalizedEmail = "PESHO@YAHOO.COM"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("4AA8654E-1465-4839-814C-A62A69D532E9"),
                UserName = "gosho@yahoo.com",
                NormalizedUserName = "GOSHO@YAHOO.COM",
                Email = "gosho@yahoo.com",
                NormalizedEmail = "GOSHO@YAHOO.COM"
            }
        };

            Companies = new List<CateringCompany>()
            {
                new CateringCompany
                {
                    Id = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    Name = "ET SAM-DPD",
                    Address = null,
                    IdentificationNumber = "121756888",
                    UserId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D")
                },
                new CateringCompany
                {
                    Id = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    Name = "HealtyFoodForChildren",
                    Address = null,
                    IdentificationNumber = "121756889",
                    UserId = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5")
                }
        };
            Schools = new List<School>()
            {
                new School()
                {
                    Id = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F"),
                    Name = "41 OU Patriarh Evtimii",
                    Address = "bul. Hristo Botev 41",
                    IdentificationNumber = "121756886",
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    UserId = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0")
                },
                new School()
                {
                    Id = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92"),
                    Name = "51 SOU Hristo  Botev",
                    Address = "bul. Al. Stamboliiski 33",
                    IdentificationNumber = "121756787",
                    CateringCompanyId = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    UserId = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421")
                },
            };
            Parents = new List<Parent>()
            {
                new Parent()
                {
                    Id = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    FirstName = "Petar",
                    LastName = "Ivanov",
                    Address = "Sofia, Bulgaria",
                    UserId = Guid.Parse("F4E56355-18AE-42A7-B082-25A2CF382D3D")
                },
                    new Parent()
                    {
                    Id = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    FirstName = "Georgi",
                    LastName = "Petrov",
                    Address = "Stara Zagora, Bulgaria",
                    UserId = Guid.Parse("4AA8654E-1465-4839-814C-A62A69D532E9")
                },
            };
            Allergens = new List<Allergen>()
            {
                new Allergen { Id = 1, Name = "Gluten" },
                new Allergen { Id = 2, Name = "Dairy" },
                new Allergen { Id = 3, Name = "Eggs" },
                new Allergen { Id = 4, Name = "Fish" },
                new Allergen { Id = 5, Name = "Peanuts" },
                new Allergen { Id = 6, Name = "SeeFood" },
                new Allergen { Id = 7, Name = "Soy" },
                new Allergen { Id = 8, Name = "TreeNuts" },
                new Allergen { Id = 9, Name = "Wheat" },
                new Allergen { Id = 10, Name = "Celery" },
                new Allergen { Id = 11, Name = "Sulfites" },
                new Allergen { Id = 12, Name = "Lupin" },
                new Allergen { Id = 13, Name = "Sesame" },
                new Allergen { Id = 14, Name = "Mustard" }
            };
            Dishes = new List<Dish>()
            {
                //Menu 1
                new Dish { Id = 1, Name = "Turkey and Cheese Sandwich", Description = "Whole wheat bread filled with sliced turkey breast, lettuce, and low-fat cheese. Served with a side of cherry tomatoes and cucumber slices.", Weight = 250, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 2, Name = "Vegetable Pasta Salad", Description = "Whole wheat pasta mixed with assorted chopped vegetables (such as bell peppers, cherry tomatoes, and broccoli). Tossed in a light Italian dressing.", Weight = 200, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 3, Name = "Fruit Salad with Yogurt", Description = "Mixed fruit salad (such as strawberries, grapes, and kiwi) served with a dollop of low-fat yogurt.", Weight = 150, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                
                //Menu 2
                new Dish { Id = 4, Name = "Chicken Caesar Wrap", Description = "Grilled chicken strips, romaine lettuce, and Caesar dressing wrapped in a whole wheat tortilla. Served with a side of carrot sticks and hummus.", Weight = 280, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 5, Name = "Quinoa and Black Bean Bowl", Description = "Quinoa mixed with black beans, corn, diced bell peppers, and cilantro. Drizzled with a squeeze of lime juice.", Weight = 250, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 6, Name = "Greek Salad", Description = "Salad greens topped with cucumber slices, cherry tomatoes, feta cheese, and olives. Served with a side of whole grain pita bread.", Weight = 200,  CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                
                //Menu 3
                new Dish { Id = 7, Name = "Hummus and Veggie Wrap", Description = "Whole wheat wrap filled with hummus, shredded carrots, spinach leaves, and sliced bell peppers. Served with a side of sugar snap peas.", Weight = 270, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 8, Name = "Vegetable Soup with Whole Grain Crackers", Description = "Homemade vegetable soup (carrots, celery, onions, and beans) served with whole grain crackers on the side.", Weight = 300, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 9, Name = "Apple and Cheese Plate", Description = "Slices of apple served with cheese cubes and whole grain crackers.", Weight = 200, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },

                //Menu 4
                new Dish { Id = 10, Name = "Tuna Salad Stuffed Bell Peppers", Description = "Halved bell peppers filled with tuna salad (made with canned tuna, light mayo, diced celery, and a dash of lemon juice). Served with a side of carrot sticks and ranch dressing for dipping.", Weight = 300, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 11, Name = "Brown Rice Sushi Rolls", Description = "Brown rice sushi rolls filled with cucumber, avocado, and cooked shrimp. Served with a side of edamame.", Weight = 280, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 12, Name = "Yogurt Parfait", Description = "Layers of low-fat yogurt, granola, and mixed berries.", Weight = 200, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },

                //Menu 5
                new Dish { Id = 13, Name = "Veggie and Cheese Quesadillas", Description = "Whole wheat tortillas filled with sautéed bell peppers, onions, spinach, and shredded cheese. Served with a side of salsa for dipping.", Weight = 250, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 14, Name = "Sweet Potato and Black Bean Salad", Description = "Roasted sweet potatoes mixed with black beans, corn, and diced red onions. Tossed in a lime vinaigrette dressing.", Weight = 200, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Dish { Id = 15, Name = "Cucumber and Tomato Salad", Description = "Sliced cucumbers and cherry tomatoes tossed in a light balsamic vinaigrette dressing.", Weight = 150, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") }
            };
            Menus = new List<Menu>()
            {
                new Menu { Id = 1, DayOfWeek = CustomDayOfWeek.Monday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), IsActive = true },
                new Menu { Id = 2, DayOfWeek = CustomDayOfWeek.Tuesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), IsActive = true },
                new Menu { Id = 3, DayOfWeek = CustomDayOfWeek.Wednesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), IsActive = true },
                new Menu { Id = 4, DayOfWeek = CustomDayOfWeek.Thursday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), IsActive = true },
                new Menu { Id = 5, DayOfWeek = CustomDayOfWeek.Friday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), IsActive = true }
            };
            Students = new List<Student>()
            {
                new Student
                {
                    Id = Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0"),
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2010, 1, 1),
                    ClassNumber = 3,
                    ClassLetter = 'B',
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F"),
                    IsActive = true
                },
                new Student
                {
                    Id = Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"),
                    FirstName = "Jane",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2012, 10, 1),
                    ClassNumber = 1,
                    ClassLetter = 'A',
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F"),
                    IsActive = true
                },
                new Student
                {
                    Id = Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"),
                    FirstName = "Jack",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2014, 11, 10),
                    ClassNumber = 1,
                    ClassLetter = 'B',
                    ParentId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    SchoolId = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92"),
                    IsActive = true
                }
            };
            DishMenus = new List<DishMenu>()
            {
                new DishMenu { DishId = 2, MenuId = 1},
                new DishMenu { DishId = 3, MenuId = 1},
                new DishMenu { DishId = 4, MenuId = 2},
                new DishMenu { DishId = 5, MenuId = 2},
                new DishMenu { DishId = 6, MenuId = 2},
                new DishMenu { DishId = 7, MenuId = 3},
                new DishMenu { DishId = 8, MenuId = 3},
                new DishMenu { DishId = 9, MenuId = 3},
                new DishMenu { DishId = 10, MenuId = 4},
                new DishMenu { DishId = 11, MenuId = 4},
                new DishMenu { DishId = 12, MenuId = 4},
                new DishMenu { DishId = 13, MenuId = 5},
                new DishMenu { DishId = 14, MenuId = 5},
                new DishMenu { DishId = 15, MenuId = 5}
            };
            FoodStamps = new List<FoodStamp>()
            {
                new FoodStamp
                {
                    Id = Guid.Parse("E3BCC07A-9A2F-4C54-8135-A5F1E21ED99D"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    ExpiryDate = new DateTime(2024, 09, 16, 14, 0, 0),
                    Status = FoodStampStatus.Valid,
                    MenuId = 1,
                    StudentId = Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0"),
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")
                },
                new FoodStamp
                {
                    Id = Guid.Parse("03C7DD57-8981-43AF-AD5F-2A817214FB3E"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    ExpiryDate = new DateTime(2024, 09, 17, 14, 0, 0),
                    Status = FoodStampStatus.Valid,
                    MenuId = 2,
                    StudentId = Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"),
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")
                },
                new FoodStamp
                {
                    Id = Guid.Parse("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    ExpiryDate = new DateTime(2024, 09, 18, 14, 0, 0),
                    Status = FoodStampStatus.Valid,
                    MenuId = 3,
                    StudentId = Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"),
                    ParentId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    CateringCompanyId = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    SchoolId = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92")
                }
            };
            AllergenDishes = new List<AllergenDish>()
            {
                new AllergenDish { AllergenId = 1, DishId = 1 },
                new AllergenDish { AllergenId = 3, DishId = 1 },
                new AllergenDish { AllergenId = 4, DishId = 1 },
                new AllergenDish { AllergenId = 5, DishId = 1 },
                new AllergenDish { AllergenId = 6, DishId = 1 },
                new AllergenDish { AllergenId = 7, DishId = 1 },
                new AllergenDish { AllergenId = 8, DishId = 1 },
                new AllergenDish { AllergenId = 9, DishId = 1 },
                new AllergenDish { AllergenId = 10, DishId = 1 },
                new AllergenDish { AllergenId = 11, DishId = 1 },
                new AllergenDish { AllergenId = 12, DishId = 1 },
                new AllergenDish { AllergenId = 13, DishId = 1 },
                new AllergenDish { AllergenId = 14, DishId = 1 },
                new AllergenDish { AllergenId = 1, DishId = 2 },
                new AllergenDish { AllergenId = 2, DishId = 2 },
                new AllergenDish { AllergenId = 3, DishId = 2 },
                new AllergenDish { AllergenId = 4, DishId = 2 },
                new AllergenDish { AllergenId = 5, DishId = 2 },
                new AllergenDish { AllergenId = 6, DishId = 2 },
                new AllergenDish { AllergenId = 7, DishId = 2 },
                new AllergenDish { AllergenId = 8, DishId = 2 },
                new AllergenDish { AllergenId = 9, DishId = 3 }
            };

            dbContext.Users.AddRange(Users);
            dbContext.CateringCompanies.AddRange(Companies);
            dbContext.Schools.AddRange(Schools);
            dbContext.Parents.AddRange(Parents);
            dbContext.Allergens.AddRange(Allergens);
            dbContext.Dishes.AddRange(Dishes);
            dbContext.Menus.AddRange(Menus);
            dbContext.Students.AddRange(Students);
            dbContext.DishMenus.AddRange(DishMenus);
            dbContext.AllergenDishes.AddRange(AllergenDishes);
            dbContext.FoodStamps.AddRange(FoodStamps);
            dbContext.SaveChanges();
        }
    }
}
