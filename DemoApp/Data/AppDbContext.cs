using DemoApp.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Album");
        });

        modelBuilder.Entity<Artist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Artist");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employee");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
