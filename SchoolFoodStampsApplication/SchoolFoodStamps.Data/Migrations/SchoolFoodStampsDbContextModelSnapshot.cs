﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolFoodStamps.Data;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    [DbContext(typeof(SchoolFoodStampsDbContext))]
    partial class SchoolFoodStampsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AllergenDish", b =>
                {
                    b.Property<int>("AllergensId")
                        .HasColumnType("int");

                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.HasKey("AllergensId", "DishesId");

                    b.HasIndex("DishesId");

                    b.ToTable("AllergenDish", (string)null);
                });

            modelBuilder.Entity("ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("26264acb-32dd-44cb-a5e3-5e707e37f61f"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88944306-e723-4e57-86ed-54bfd866d6c2",
                            Email = "test@test.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.BG",
                            NormalizedUserName = "TEST@TEST.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEEUBePebfgEOrSg50xIuJKcweJpN5/ywoe1lVQkmEwo3brxucWukW9Ipw27z/DN2gg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "061E5799-F265-4EB7-9C34-ACB5BEE4DFF1",
                            TwoFactorEnabled = false,
                            UserName = "test@test.bg"
                        },
                        new
                        {
                            Id = new Guid("6136e95f-8387-4023-b476-ea5ddffbc61e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e292a30f-ca69-46b2-a0cc-19d3201f0da9",
                            Email = "pesho@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO@ABV.BG",
                            NormalizedUserName = "PESHO@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAELAWOovbNzIXyfjDYfhF1pZuxXqR4nRMRFv79YtSpKAroX4adUQyC/fGe57+6cZ2+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "098EACC6-B385-4CBC-B3C7-541588F5E170",
                            TwoFactorEnabled = false,
                            UserName = "pesho@abv.bg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Allergen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Allergens", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gluten"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Eggs"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Peanuts"
                        },
                        new
                        {
                            Id = 6,
                            Name = "SeeFood"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Soy"
                        },
                        new
                        {
                            Id = 8,
                            Name = "TreeNuts"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Wheat"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Celery"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sulfites"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lupin"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sesame"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Mustard"
                        });
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.CateringCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Catering company identifier");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Catering company address");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Catering company Identification Number");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Catering company name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Catering company phone number");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CateringCompanies", (string)null);

                    b.HasComment("Catering company table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Child", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Child identifier");

                    b.Property<string>("ClassLetter")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasComment("Child class letter in school");

                    b.Property<byte>("ClassNumber")
                        .HasColumnType("tinyint")
                        .HasComment("Child class number in school");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasComment("Child date of birth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Child first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Child last name");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Parent identifier");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("School identifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Children", (string)null);

                    b.HasComment("Child table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Dish identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Dish description");

                    b.Property<int>("MenuId")
                        .HasColumnType("int")
                        .HasComment("Menu identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Dish name");

                    b.Property<double>("Weight")
                        .HasColumnType("float")
                        .HasComment("Dish weight");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Dishes", (string)null);

                    b.HasComment("Dish table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.FoodStamp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Food stamp identifier");

                    b.Property<Guid>("CateringCompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Catering identifier");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Child identifier");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2")
                        .HasComment("Food stamp expiry date");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2")
                        .HasComment("Food stamp issue date");

                    b.Property<int>("MenuId")
                        .HasColumnType("int")
                        .HasComment("Menu identifier");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Parent identifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Food stamp price");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("Food stamp status");

                    b.Property<DateTime>("UseDate")
                        .HasColumnType("datetime2")
                        .HasComment("Food stamp use date");

                    b.HasKey("Id");

                    b.HasIndex("CateringCompanyId");

                    b.HasIndex("ChildId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ParentId");

                    b.ToTable("FoodStamps", (string)null);

                    b.HasComment("Food stamp table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Menu identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2")
                        .HasComment("Menu date of creation");

                    b.Property<DateTime>("DateOfModify")
                        .HasColumnType("datetime2")
                        .HasComment("Menu date of modify");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int")
                        .HasComment("Menu day of week");

                    b.HasKey("Id");

                    b.ToTable("Menus", (string)null);

                    b.HasComment("Menu table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Parent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Parent identifier");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Parent address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Parent first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Parent last name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("Parent phone number");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Parents", (string)null);

                    b.HasComment("Parent table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("School identifier");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("School address");

                    b.Property<Guid>("CateringCompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Catering company identifier");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("School name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("School phone number");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("CateringCompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Schools", (string)null);

                    b.HasComment("School table");
                });

            modelBuilder.Entity("AllergenDish", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.Allergen", null)
                        .WithMany()
                        .HasForeignKey("AllergensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.CateringCompany", b =>
                {
                    b.HasOne("ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Child", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.Parent", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.School", "School")
                        .WithMany("Children")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Dish", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.Menu", "Menu")
                        .WithMany("Dishes")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.FoodStamp", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.CateringCompany", "CateringCompany")
                        .WithMany("FoodStamps")
                        .HasForeignKey("CateringCompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Child", "Child")
                        .WithMany("FoodStamps")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Parent", "Parent")
                        .WithMany("FoodStamps")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CateringCompany");

                    b.Navigation("Child");

                    b.Navigation("Menu");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Parent", b =>
                {
                    b.HasOne("ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.School", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.CateringCompany", "Company")
                        .WithMany("Schools")
                        .HasForeignKey("CateringCompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.CateringCompany", b =>
                {
                    b.Navigation("FoodStamps");

                    b.Navigation("Schools");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Child", b =>
                {
                    b.Navigation("FoodStamps");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Menu", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Parent", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("FoodStamps");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.School", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
