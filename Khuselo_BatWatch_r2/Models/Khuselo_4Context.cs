using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Khuselo_BatWatch_r2.Models
{
    public partial class Khuselo_4Context : DbContext
    {
      
        public Khuselo_4Context()
        {
        }

        public Khuselo_4Context(DbContextOptions<Khuselo_4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<KhuseloDb4> KhuseloDb4s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhuseloDb4>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("KhuseloDb4");

                entity.Property(e => e.Serial).ValueGeneratedNever();

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.ChargeCycles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateExpired).HasColumnType("date");

                entity.Property(e => e.DateInstalled).HasColumnType("date");

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechCell)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TechnName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
