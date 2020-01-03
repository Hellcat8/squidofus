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
        public virtual DbSet<Spell> Spell { get; set; }
        public virtual DbSet<SpellDetail> SpellDetail { get; set; }
        public virtual DbSet<SpellEffect> SpellEffect { get; set; }

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

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
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

            modelBuilder.Entity<Spell>(entity =>
            {
                entity.HasKey(e => e.IdSpell)
                    .HasName("PRIMARY");

                entity.ToTable("spell");

                entity.HasIndex(e => e.IdClass)
                    .HasName("fk_spell_to_class_idx");

                entity.Property(e => e.IdSpell)
                    .HasColumnName("id_spell")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdClass)
                    .HasColumnName("id_class")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImgFilename)
                    .IsRequired()
                    .HasColumnName("img_filename")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.Spell)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_spell_to_class");
            });

            modelBuilder.Entity<SpellDetail>(entity =>
            {
                entity.HasKey(e => e.IdSpellDetail)
                    .HasName("PRIMARY");

                entity.ToTable("spell_detail");

                entity.HasIndex(e => e.IdSpell)
                    .HasName("fk_spell_detail_to_spell_idx");

                entity.Property(e => e.IdSpellDetail)
                    .HasColumnName("id_spell_detail")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdjustableRange).HasColumnName("adjustable_range");

                entity.Property(e => e.ApCost)
                    .IsRequired()
                    .HasColumnName("ap_cost")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CriticalHitProbability)
                    .IsRequired()
                    .HasColumnName("critical_hit_probability")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FailureEndsTurn).HasColumnName("failure_ends_turn");

                entity.Property(e => e.FailureProbability)
                    .IsRequired()
                    .HasColumnName("failure_probability")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FreeCells).HasColumnName("free_cells");

                entity.Property(e => e.HasCriticalEffect).HasColumnName("has_critical_effect");

                entity.Property(e => e.HasSummonInfo).HasColumnName("has_summon_info");

                entity.Property(e => e.IdSpell)
                    .HasColumnName("id_spell")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LineOfSight).HasColumnName("line_of_sight");

                entity.Property(e => e.Linear).HasColumnName("linear");

                entity.Property(e => e.NbCastPerTurn)
                    .IsRequired()
                    .HasColumnName("nb_cast_per_turn")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NbCastPerTurnPerPlayer)
                    .IsRequired()
                    .HasColumnName("nb_cast_per_turn_per_player")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NbTurnsBetweenTwoCasts)
                    .IsRequired()
                    .HasColumnName("nb_turns_between_two_casts")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Range)
                    .IsRequired()
                    .HasColumnName("range")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RequiredLvl)
                    .HasColumnName("required_lvl")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpellLvl)
                    .HasColumnName("spell_lvl")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.IdSpellNavigation)
                    .WithMany(p => p.SpellDetail)
                    .HasForeignKey(d => d.IdSpell)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_spell_detail_to_spell");
            });

            modelBuilder.Entity<SpellEffect>(entity =>
            {
                entity.HasKey(e => e.IdSpellEffect)
                    .HasName("PRIMARY");

                entity.ToTable("spell_effect");

                entity.HasIndex(e => e.IdSpellDetail)
                    .HasName("fk_spell_effect_to_spell_detail_idx");

                entity.Property(e => e.IdSpellEffect)
                    .HasColumnName("id_spell_effect")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect")
                    .HasColumnType("varchar(70)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Element)
                    .HasColumnName("element")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdSpellDetail)
                    .HasColumnName("id_spell_detail")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdSpellDetailNavigation)
                    .WithMany(p => p.SpellEffect)
                    .HasForeignKey(d => d.IdSpellDetail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_spell_effect_to_spell_detail");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
