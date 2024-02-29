using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;
using System.Globalization;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Data.Configuration
{
    public class SchoolFoodStampEntityConfigurations :  IEntityTypeConfiguration<FoodStamp>
    {
        public void Configure(EntityTypeBuilder<FoodStamp> builder)
        {
            builder
                .Property(fs => fs.IssueDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(fs => fs.Price)
                .HasDefaultValue(FoodStampPrice);

            builder
                .HasOne(fs => fs.Parent)
                .WithMany(p => p.FoodStamps)
                .HasForeignKey(fs => fs.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(fs => fs.Child)
                .WithMany(c => c.FoodStamps)
                .HasForeignKey(fs => fs.ChildId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(fs => fs.CateringCompany)
                .WithMany(c => c.FoodStamps)
                .HasForeignKey(fs => fs.CateringCompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(fs => fs.Menu)
                .WithMany()
                .HasForeignKey(fs => fs.MenuId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasData(this.GenrateFoodStamps());
        }

        private HashSet<FoodStamp> GenrateFoodStamps()
        {
            return new HashSet<FoodStamp>()
            {
                new FoodStamp
                {
                    Id = Guid.Parse("E3BCC07A-9A2F-4C54-8135-A5F1E21ED99D"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    UseDate = DateTime.ParseExact("09/16/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ExpiryDate = DateTime.ParseExact("09/16/2024 14:00", "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture),
                    Status = FoodStampStatus.Valid,
                    MenuId = 1,
                    ChildId = Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0"),
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                },
                new FoodStamp
                {
                    Id = Guid.Parse("03C7DD57-8981-43AF-AD5F-2A817214FB3E"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    UseDate = DateTime.ParseExact("09/17/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ExpiryDate = DateTime.ParseExact("09/17/2024 14:00", "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture),
                    Status = FoodStampStatus.Valid,
                    MenuId = 2,
                    ChildId = Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"),
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                },
                new FoodStamp
                {
                    Id = Guid.Parse("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9"),
                    Price = FoodStampPrice,
                    IssueDate = DateTime.UtcNow,
                    UseDate = DateTime.ParseExact("09/18/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ExpiryDate = DateTime.ParseExact("09/18/2024 14:00", "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture),
                    Status = FoodStampStatus.Valid,
                    MenuId = 3,
                    ChildId = Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"),
                    ParentId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    CateringCompanyId = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                }
            };
        }
    }
}
