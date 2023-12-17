namespace SchoolMealVouchers.Data;

using Microsoft.EntityFrameworkCore;
using SchoolMealVouchers.Data.Models;
using System.Reflection.Emit;

public class SoftJailDbContext : DbContext
{
    public SoftJailDbContext()
    {
    }

    public SoftJailDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } = null!;
    public virtual DbSet<School> Schools { get; set; } = null!;
    public virtual DbSet<Student> Students { get; set; } = null!;
    public virtual DbSet<CateringCompany> CateringCompanies { get; set; } = null!;
    public virtual DbSet<Parent> Parents { get; set; } = null!;
    public virtual DbSet<VoucherParent> VoucherParents { get; set; } = null!;
    public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseSqlServer(Configuration.ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<VoucherParent>(e =>
        {
            e.HasKey(vp => new { vp.ParentId, vp.VoucherId });

            e.HasOne(vp => vp.Parent)
                .WithMany(p => p.VoucherParents)
                .HasForeignKey(vp => vp.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        //builder.Entity<School>()
        //    .HasOne(s => s.User)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Restrict);
    }
}