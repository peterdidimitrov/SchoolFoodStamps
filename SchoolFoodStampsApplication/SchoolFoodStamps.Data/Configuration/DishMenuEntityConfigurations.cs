using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class DishMenuEntityConfigurations : IEntityTypeConfiguration<DishMenu>
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

            //builder
            //    .HasOne(dm => dm.Menu)
            //    .WithMany()
            //    .HasForeignKey(dm => dm.MenuId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
