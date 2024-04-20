using Microsoft.EntityFrameworkCore;
using PhamVanNhatHuy_ThucHanhEF.CodeFirst.Models;

namespace PhamVanNhatHuy_ThucHanhEF.CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>().HasData(
                new Khoa { Id = 1, TenKhoa = "Công nghệ số" },
                new Khoa { Id = 2, TenKhoa = "Cơ khí" },
                new Khoa { Id = 3, TenKhoa = "Xây dựng" });

            modelBuilder.Entity<Lop>().HasData(
                new Lop { Id = 1, MaKhoa = 1, TenLop = "21T1" },
                new Lop { Id = 2, MaKhoa = 1, TenLop = "21T2" },
                new Lop { Id = 3, MaKhoa = 1, TenLop = "21T3" });

            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien { Id = 1, HoTen = "Phạm Văn Nhật Huy", Tuoi = 21, MaLop = 3, MaSinhVien = "21115053120318" },
                new SinhVien { Id = 2, HoTen = "Nguyễn Văn A", Tuoi = 21, MaLop = 2, MaSinhVien = "21115053120336" },
                new SinhVien { Id = 3, HoTen = "Nguyễn Văn B", Tuoi = 21, MaLop = 1, MaSinhVien = "21115053120323" });
        }
    }
}
