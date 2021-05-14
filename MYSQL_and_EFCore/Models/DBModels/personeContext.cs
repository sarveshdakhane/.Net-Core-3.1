using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using DotNet_Core_with_Entity_Framework_Core_With_MySql.DBModels;

#nullable disable

namespace DotNet_Core_with_Entity_Framework_Core_With_MySql.Models.DBModels
{
    public partial class personeContext : DbContext
    { 
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string ConnectingString= ConfigurationManager.AppSettings["ConnectionString"];
                optionsBuilder.UseMySql(ConnectingString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Idemployee)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.Property(e => e.Idemployee)
                    .ValueGeneratedNever()
                    .HasColumnName("idemployee");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .HasColumnName("Last Name");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
