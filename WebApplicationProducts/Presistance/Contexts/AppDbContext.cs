using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProducts.Domain.Models;

namespace WebApplicationProducts.Presistance.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>()
                .ToTable("Categories");

            builder.Entity<Category>()
                .HasKey(p => p.Id);

            builder.Entity<Category>()
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Entity<Category>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
                (
                new Category { Id = 1000, Name = "Beverages" },
                new Category { Id = 2000, Name = "Juice and Hot Dairy" },
                new Category { Id = 10000, Name = "None"}
                );

            builder.Entity<Product>()
                .ToTable("Products");

            builder.Entity<Product>().
                HasKey(p => p.Id);

            builder.Entity<Product>()
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();

            builder.Entity<Product>()
                .Property(p => p.IsActive)
                .IsRequired();

            builder.Entity<Product>().HasData
                (
                    new Product
                    {
                        Id = 100,
                        Name = "Sandora",
                        Price = 28.10,
                        IsActive = true,
                        CategoryId = 2000
                    },
                    new Product
                    {
                        Id = 200,
                        Name = "Pepsi MAX",
                        Price = 14.10,
                        IsActive = true,
                        CategoryId = 1000
                    }
                );
        }

    }
}
