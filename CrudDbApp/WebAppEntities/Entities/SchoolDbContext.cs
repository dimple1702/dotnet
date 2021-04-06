using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAppEntities.CustomEntities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppEntities.Entities
{
    public partial class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentTeacher> StudentTeacher { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<CollectiveData> CollectiveData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NPTB8JS;Database=School;User Id= dimple; Password=Dimple@1217;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__014881AE8609EED8");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocId)
                    .HasName("PK__Location__6A46DE89ED987670");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Location__Countr__6A30C649");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentDob).HasColumnType("date");

                entity.Property(e => e.StudentEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentFname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudentLname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudentPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Loc)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.LocId)
                    .HasConstraintName("FK__Student__LocId__787EE5A0");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Student__Teacher__778AC167");
            });

            modelBuilder.Entity<StudentTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StudentTeacher");

                entity.Property(e => e.StudentEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.TeacherEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherFname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherLname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Teacher__DeptId__6FE99F9F");

                entity.HasOne(d => d.Loc)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.LocId)
                    .HasConstraintName("FK__Teacher__LocId__70DDC3D8");
            });

            modelBuilder.Entity <CollectiveData> (entity => { });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
