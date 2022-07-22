using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BookmyMovie.Models
{
    public partial class mymovieDBContext : DbContext
    {
        public mymovieDBContext()
        {
        }

        public mymovieDBContext(DbContextOptions<mymovieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddMovie> AddMovies { get; set; }
        public virtual DbSet<FinalBooking> FinalBookings { get; set; }
        public virtual DbSet<MyBooking> MyBookings { get; set; }
        public virtual DbSet<TblRegister> TblRegisters { get; set; }
        public virtual DbSet<Tbllogin> Tbllogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BUE654A;Initial Catalog=mymovieDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddMovie>(entity =>
            {
                entity.ToTable("AddMovie");

                entity.Property(e => e.MovieImage).HasMaxLength(100);

                entity.Property(e => e.MovieName).HasMaxLength(100);
            });

            modelBuilder.Entity<FinalBooking>(entity =>
            {
                entity.ToTable("FinalBooking");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName).HasMaxLength(100);

                entity.Property(e => e.Time).HasMaxLength(100);

                entity.Property(e => e.TotalFare).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MyBooking>(entity =>
            {
                entity.ToTable("MyBooking");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .HasColumnName("Email id");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName)
                    .HasMaxLength(100)
                    .HasColumnName("Movie Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfTickets).HasColumnName("no.of tickets");

                entity.Property(e => e.Time).HasMaxLength(100);
            });

            modelBuilder.Entity<TblRegister>(entity =>
            {
                entity.ToTable("TblRegister");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbllogin>(entity =>
            {
                entity.ToTable("Tbllogin");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
