using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TokenAuthentication.Entites;

#nullable disable

namespace TokenAuthentication.Data
{
    public partial class TokenDbContext : DbContext
    {
        public TokenDbContext()
        {
        }

        public TokenDbContext(DbContextOptions<TokenDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblbook> Tblbooks { get; set; }
        public virtual DbSet<Tbluser> Tblusers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_India.1252");

            modelBuilder.Entity<Tblbook>(entity =>
            {
                entity.HasKey(e => e.Bookid)
                    .HasName("tblbook_pkey");

                entity.ToTable("tblbook");

                entity.Property(e => e.Bookid)
                    .HasColumnName("bookid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("author");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("isbn");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Price)
                    .HasPrecision(18, 2)
                    .HasColumnName("price");

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("publisher");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Tbluser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("tbluser_pkey");

                entity.ToTable("tbluser");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullname")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Salt).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
