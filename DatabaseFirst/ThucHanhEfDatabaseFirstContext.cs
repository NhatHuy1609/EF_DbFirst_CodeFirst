using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhamVanNhatHuy_ThucHanhEF.DatabaseFirst;

public partial class ThucHanhEfDatabaseFirstContext : DbContext
{
    public ThucHanhEfDatabaseFirstContext()
    {
    }

    public ThucHanhEfDatabaseFirstContext(DbContextOptions<ThucHanhEfDatabaseFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NHATHUY16903\\SQLEXPRESS;Initial Catalog=ThucHanhEF_DatabaseFirst;User ID=pvnhathuy;Password=Nhathuy160903;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Khoa__3214EC0780D0FBD6");

            entity.ToTable("Khoa");

            entity.Property(e => e.TenKhoa).HasMaxLength(50);
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lop__3214EC0733DA1D1C");

            entity.ToTable("Lop");

            entity.Property(e => e.TenLop).HasMaxLength(50);

            entity.HasOne(d => d.Khoa).WithMany(p => p.Lops)
                .HasForeignKey(d => d.KhoaId)
                .HasConstraintName("FK__Lop__KhoaId__267ABA7A");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC07217DD154");

            entity.ToTable("SinhVien");

            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaSinhVien)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK__SinhVien__MaLop__29572725");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
