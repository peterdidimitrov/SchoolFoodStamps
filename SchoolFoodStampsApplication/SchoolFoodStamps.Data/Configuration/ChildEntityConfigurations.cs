using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ChildEntityConfigurations : IEntityTypeConfiguration<Child>
    {
        public void Configure(EntityTypeBuilder<Child> builder)
        {
            builder
                .HasOne(c => c.Parent)
                .WithMany(s => s.Children)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(c => c.School)
                .WithMany(s => s.Children)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasData(this.GenerateChildren());
        }

        private HashSet<Child> GenerateChildren()
        {
            return new HashSet<Child>()
            {
                new Child
                {
                    Id = Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0"),
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2010, 1, 1),
                    ClassNumber = 3,
                    ClassLetter = 'B',
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")
                },
                new Child
                {
                    Id = Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"),
                    FirstName = "Jane",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2012, 10, 1),
                    ClassNumber = 1,
                    ClassLetter = 'A',
                    ParentId = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    SchoolId = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")
                },
                new Child
                {
                    Id = Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"),
                    FirstName = "Jack",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2014, 11, 10),
                    ClassNumber = 1,
                    ClassLetter = 'B',
                    ParentId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    SchoolId = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92")
                }
            };
        }
    }
}
