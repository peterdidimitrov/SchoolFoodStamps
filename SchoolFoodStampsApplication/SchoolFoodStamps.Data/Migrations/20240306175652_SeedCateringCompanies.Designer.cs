﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolFoodStamps.Data;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    [DbContext(typeof(SchoolFoodStampsDbContext))]
    [Migration("20240306175652_SeedCateringCompanies")]
    partial class SeedCateringCompanies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2fb201e5-aef2-4537-8eab-e2dbdc7fa34e",
                            Email = "dimitrichko_admin@org.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DIMITRICHKO_ADMIN@ORG.BG",
                            NormalizedUserName = "DIMITRICHKO_ADMIN@ORG.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEHrBxwTiHx5VzDECLrzGzbHFMqihPH6tqIAsZRHLPlSZNaxnmqnzc9EbiFop5CSF+g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "E06B1C21-EA78-46B0-8144-44E8BCFADE0B",
                            TwoFactorEnabled = false,
                            UserName = "dimitrichko_admin@org.bg"
                        },
                        new
                        {
                            Id = new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be82ac1f-5bd5-447a-9bf5-ae99cfdd9aa3",
                            Email = "test@test.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.BG",
                            NormalizedUserName = "TEST@TEST.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEKwMerqJrrsvamPBJLaIcKhnF+WKqOukv8URlFbQZOe/jhenBfGGWxIIqtoTN7qfHA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5E3D04EB-9216-4A58-A8DD-140CBE95D20B",
                            TwoFactorEnabled = false,
                            UserName = "test@test.bg"
                        },
                        new
                        {
                            Id = new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8f58fda-2bc6-46cf-b02a-5d3596705125",
                            Email = "pesho@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO@ABV.BG",
                            NormalizedUserName = "PESHO@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEKDwzTP6rbcwUPkDDnClwXBhNuzgqV8aP4fBAwnKkho9qU77zequbp9WQVu8uUumig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96246022-EEF3-4441-A259-F84E93DF6B7E",
                            TwoFactorEnabled = false,
                            UserName = "pesho@abv.bg"
                        },
                        new
                        {
                            Id = new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f19e14c7-b590-4098-a604-42f3adb8e515",
                            Email = "patriarh.evtimi@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATRIARH.EVTIMI@ABV.BG",
                            NormalizedUserName = "PATRIARH.EVTIMI@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEDfRzzVu7zJ3mtcl+NOWDkBgACAMQGUgRvXOxkGQs/02touD0SZ+O6If12KrKesDIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87928E55-D154-46D7-8AAB-75A6DAC1FC60",
                            TwoFactorEnabled = false,
                            UserName = "patriarh.evtimi@abv.bg"
                        },
                        new
                        {
                            Id = new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1aacdd70-d711-4875-9ed8-5c8aaf0c8d22",
                            Email = "hristo.botev@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HRISTO.BOTEV@ABV.BG",
                            NormalizedUserName = "HRISTO.BOTEV@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEDjwZU01P7/qJpprkcybC5jjvc3UpLjLWuSczuyjCiZ8mv7817CbE0TkMuwMuvus+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "C6D0EA9C-0F96-44CC-9767-1BD143736612",
                            TwoFactorEnabled = false,
                            UserName = "hristo.botev@abv.bg"
                        },
                        new
                        {
                            Id = new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7c54cbf6-e3e1-4f1f-b722-cf830d2befc6",
                            Email = "pesho@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO@YAHOO.COM",
                            NormalizedUserName = "PESHO@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEv3dt+pB7yImBaGMU4SPHLKayn+C1g7FSFEa8bxuVT/mhib5ewCzeeumn72DPi6ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "C424F191-08F0-4384-8639-D23C17F40DBF",
                            TwoFactorEnabled = false,
                            UserName = "pesho@yahoo.com"
                        },
                        new
                        {
                            Id = new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6c32c37-f255-48d9-bb1a-a6cfd1a09260",
                            Email = "gosho@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GOSHO@YAHOO.COM",
                            NormalizedUserName = "GOSHO@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEePCVzlhcog4yY9S0yWQYmirzjD8M43c1q47vWVC5k8gF4r5YIRMe6WrAUU+5s1qA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "A20C4557-2853-4C95-A67A-CE66263589FE",
                            TwoFactorEnabled = false,
                            UserName = "gosho@yahoo.com"
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

                    b.ToTable("Allergens");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.AllergenDish", b =>
                {
                    b.Property<int>("AllergenId")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.HasKey("AllergenId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("AllergenDishes");
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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CateringCompanies");

                    b.HasComment("Catering company table");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"),
                            IdentificationNumber = "121756888",
                            Name = "ET SAM-DPD",
                            UserId = new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d")
                        },
                        new
                        {
                            Id = new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"),
                            IdentificationNumber = "121756889",
                            Name = "HealtyFoodForChildren",
                            UserId = new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5")
                        });
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

                    b.ToTable("Children");

                    b.HasComment("Child table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Dish identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("CateringCompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Catering company identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Dish description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Dish name");

                    b.Property<double>("Weight")
                        .HasColumnType("float")
                        .HasComment("Dish weight");

                    b.HasKey("Id");

                    b.HasIndex("CateringCompanyId");

                    b.ToTable("Dishes");

                    b.HasComment("Dish table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.DishMenu", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("DishMenus");
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(5.00m)
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

                    b.ToTable("FoodStamps");

                    b.HasComment("Food stamp table");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Menu identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("CateringCompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Catering company identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Menu date of creation");

                    b.Property<DateTime?>("DateOfModify")
                        .HasColumnType("datetime2")
                        .HasComment("Menu date of modify");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int")
                        .HasComment("Menu day of week");

                    b.HasKey("Id");

                    b.HasIndex("CateringCompanyId");

                    b.ToTable("Menus");

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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Parents");

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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("CateringCompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Schools");

                    b.HasComment("School table");
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

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.AllergenDish", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.Allergen", "Allergen")
                        .WithMany("AllergensDishes")
                        .HasForeignKey("AllergenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Dish", "Dish")
                        .WithMany("AllergensDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergen");

                    b.Navigation("Dish");
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.School", "School")
                        .WithMany("Children")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Dish", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.CateringCompany", "Company")
                        .WithMany("Dishes")
                        .HasForeignKey("CateringCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.DishMenu", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.Dish", "Dish")
                        .WithMany("DishesMenus")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Menu", "Menu")
                        .WithMany("DishesMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.FoodStamp", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.CateringCompany", "CateringCompany")
                        .WithMany("FoodStamps")
                        .HasForeignKey("CateringCompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Child", "Child")
                        .WithMany("FoodStamps")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SchoolFoodStamps.Data.Models.Parent", "Parent")
                        .WithMany("FoodStamps")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CateringCompany");

                    b.Navigation("Child");

                    b.Navigation("Menu");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Menu", b =>
                {
                    b.HasOne("SchoolFoodStamps.Data.Models.CateringCompany", "Company")
                        .WithMany("Menus")
                        .HasForeignKey("CateringCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Allergen", b =>
                {
                    b.Navigation("AllergensDishes");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.CateringCompany", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("FoodStamps");

                    b.Navigation("Menus");

                    b.Navigation("Schools");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Child", b =>
                {
                    b.Navigation("FoodStamps");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Dish", b =>
                {
                    b.Navigation("AllergensDishes");

                    b.Navigation("DishesMenus");
                });

            modelBuilder.Entity("SchoolFoodStamps.Data.Models.Menu", b =>
                {
                    b.Navigation("DishesMenus");
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
