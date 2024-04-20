﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhamVanNhatHuy_ThucHanhEF.CodeFirst.Data;

#nullable disable

namespace PhamVanNhatHuy_ThucHanhEF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240420041814_add-sinhvien-khoa-lop")]
    partial class addsinhvienkhoalop
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.Khoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaKhoa")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaKhoa");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaLop")
                        .HasColumnType("int");

                    b.Property<string>("MaSinhVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaLop");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.Lop", b =>
                {
                    b.HasOne("PhamVanNhatHuy_ThucHanhEF.Models.Khoa", "Khoa")
                        .WithMany("DanhSachLops")
                        .HasForeignKey("MaKhoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.SinhVien", b =>
                {
                    b.HasOne("PhamVanNhatHuy_ThucHanhEF.Models.Lop", "Lop")
                        .WithMany("DanhSachSinhVien")
                        .HasForeignKey("MaLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.Khoa", b =>
                {
                    b.Navigation("DanhSachLops");
                });

            modelBuilder.Entity("PhamVanNhatHuy_ThucHanhEF.Models.Lop", b =>
                {
                    b.Navigation("DanhSachSinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
