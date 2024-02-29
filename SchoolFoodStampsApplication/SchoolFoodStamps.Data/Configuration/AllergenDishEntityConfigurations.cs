using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class AllergenDishEntityConfigurations : IEntityTypeConfiguration<AllergenDish>
    {
        public void Configure(EntityTypeBuilder<AllergenDish> builder)
        {
            builder
            .HasKey(dm => new { dm.AllergenId, dm.DishId });
        }
    }
}
