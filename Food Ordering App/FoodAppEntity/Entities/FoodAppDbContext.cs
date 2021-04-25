using System;
using FoodAppEntity.CustomModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class FoodAppDbContext : DbContext
    {
        public FoodAppDbContext()
        {
        }

        public FoodAppDbContext(DbContextOptions<FoodAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ImageDemo> ImageDemos { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderHistory> OrderHistories { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<ReservationDetails> ReservationDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<OrderCategoryModel> OrderCategoryModel { get; set; }
        public virtual DbSet<OrderHistoryModel> OrderHistoryModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NPTB8JS;Database=FoodApp;User Id= dimple; Password=Dimple@1217;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageDemo>(entity =>
            {
                entity.ToTable("ImageDemo");

                entity.Property(e => e.Photu)
                    .IsRequired()
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ItemImage).HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__CategoryId__32E0915F");
            });

            modelBuilder.Entity<OrderHistory>(entity =>
            {
                entity.ToTable("OrderHistory");

                entity.Property(e => e.OrderDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.OrderHistories)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderHist__MenuI__4CA06362");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderHist__UserI__4BAC3F29");
            });

            modelBuilder.Entity<PaymentDetails>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailsId)
                    .HasName("PK__PaymentD__0994973B58C82493");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserResidenceAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PaymentDe__UserI__5535A963");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.MethodId)
                    .HasName("PK__PaymentM__FC681851D88317FE");

                entity.ToTable("PaymentMethod");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReservationDetails>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__Reservat__B7EE5F241A891169");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderHistoryModel>(entity => { });
            modelBuilder.Entity<OrderCategoryModel>(entity => { });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
