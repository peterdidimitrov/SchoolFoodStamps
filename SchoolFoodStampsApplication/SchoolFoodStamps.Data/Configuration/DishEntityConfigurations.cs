﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class DishEntityConfigurations : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder
                .HasData(this.GenerateDishes());
        }
        private HashSet<Dish> GenerateDishes()
        {
            return new HashSet<Dish>
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
        }
    }
}
