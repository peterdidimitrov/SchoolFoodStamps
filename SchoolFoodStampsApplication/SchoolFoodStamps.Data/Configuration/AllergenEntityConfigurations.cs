using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class AllergenEntityConfigurations : IEntityTypeConfiguration<Allergen>
    {
        public void Configure(EntityTypeBuilder<Allergen> builder)
        {
            builder
                .HasData(this.GenerateAllergens());
        }
        private Allergen[] GenerateAllergens()
        {
            ICollection<Allergen> allergens = new HashSet<Allergen>
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

            return allergens.ToArray();
        }
    }
}
