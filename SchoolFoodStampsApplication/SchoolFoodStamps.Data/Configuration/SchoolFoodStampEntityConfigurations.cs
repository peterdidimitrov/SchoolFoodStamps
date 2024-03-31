using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Data.Configuration
{
    public class SchoolFoodStampEntityConfigurations :  IEntityTypeConfiguration<FoodStamp>
    {
        public void Configure(EntityTypeBuilder<FoodStamp> builder)
        {
            builder.Property(fs => fs.Price)
                .HasDefaultValue(FoodStampPrice);

            builder.Property(fs => fs.IssueDate)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(fs => fs.Parent)
                .WithMany(p => p.FoodStamps)
                .HasForeignKey(fs => fs.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(fs => fs.Student)
                .WithMany(c => c.FoodStamps)
                .HasForeignKey(fs => fs.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(fs => fs.CateringCompany)
                .WithMany(c => c.FoodStamps)
                .HasForeignKey(fs => fs.CateringCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(fs => fs.Menu)
                .WithMany()
                .HasForeignKey(fs => fs.MenuId)
                .OnDelete(DeleteBehavior.Restrict);

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
        }
    }
}
