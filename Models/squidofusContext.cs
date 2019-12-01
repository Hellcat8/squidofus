using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Squidofus.Models
{
    public partial class SquidofusContext : DbContext
    {
        public SquidofusContext()
        {
        }

        public SquidofusContext(DbContextOptions<SquidofusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ClassDetail> ClassDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=midnightpurple;database=squidofus");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClass)
                    .HasName("PRIMARY");

                entity.ToTable("class");

                entity.Property(e => e.IdClass)
                    .HasColumnName("id_class")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ClassDetail>(entity =>
            {
                entity.HasKey(e => e.IdClassDetail)
                    .HasName("PRIMARY");

                entity.ToTable("class_detail");

                entity.HasIndex(e => e.IdClass)
                    .HasName("fk_class_detail_to_class_idx");

                entity.Property(e => e.IdClassDetail)
                    .HasColumnName("id_class_detail")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdClass)
                    .HasColumnName("id_class")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassDetail)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_class_detail_to_class");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
