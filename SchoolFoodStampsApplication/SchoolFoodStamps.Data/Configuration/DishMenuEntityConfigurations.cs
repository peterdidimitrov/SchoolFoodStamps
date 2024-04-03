using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class DishMenuEntityConfigurationsDishMenuEntityConfigurations : IEntityTypeConfiguration<DishMenu>
    {
        public void Configure(EntityTypeBuilder<DishMenu> builder)
        {
            builder
                .HasKey(dm => new { dm.DishId, dm.MenuId });

            builder
                .HasOne(dm => dm.Dish)
                .WithMany(d => d.DishesMenus)
                .HasForeignKey(dm => dm.DishId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasData(this.GenerateDishMenus());
        }
        private HashSet<DishMenu> GenerateDishMenus()
        {
            return new HashSet<DishMenu>
            {
                new DishMenu { DishId = 1, MenuId = 1},
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
        }
    }
}
