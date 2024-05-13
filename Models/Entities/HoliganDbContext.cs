using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace holiganbet.Models.Entities;

public partial class HoliganDbContext : DbContext
{
    public HoliganDbContext()
    {
    }

    public HoliganDbContext(DbContextOptions<HoliganDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin5_turkish_ci")
            .HasCharSet("latin5");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Namesurname)
                .HasMaxLength(50)
                .HasColumnName("namesurname");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("login");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("offer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Moneyamount)
                .HasMaxLength(50)
                .HasColumnName("moneyamount");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
