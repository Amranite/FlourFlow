using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlourFlowDesktop.Models;

namespace FlourFlowDesktop.Data
{
    internal class FlourFlowContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Configure the connection string
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Flour Flow;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Order>()
			   .HasOne(o => o.Ingredient)
			   .WithMany()
			   .HasForeignKey(o => o.IngredientId);

			modelBuilder.Entity<Order>()
				.HasOne(o => o.Supplier)
				.WithMany()
				.HasForeignKey(o => o.SupplierId);

			/* // Configure primary keys
			 modelBuilder.Entity<Ingredient>()
				 .HasKey(i => i.IngredientId);

			 modelBuilder.Entity<Supplier>()
				 .HasKey(s => s.SupplierId);

			 modelBuilder.Entity<Order>()
				 .HasKey(o => o.OrderId);

			 // Configure Relationships
			 modelBuilder.Entity<Ingredient>()
				 .HasOne(i => i.Supplier)
				 .WithMany()
				 .HasForeignKey(i => i.SupplierId);

			 modelBuilder.Entity<Order>()
				 .HasOne(o => o.Ingredient)
				 .WithMany()
				 .HasForeignKey(o => o.IngredientId);

			 // Define table names if necessary
			 modelBuilder.Entity<Ingredient>()
				 .ToTable("Ingredients");
			 modelBuilder.Entity<Supplier>()
				 .ToTable("Suppliers");
			 modelBuilder.Entity<Order>()
				 .ToTable("Orders");*/
		}

    }
}
