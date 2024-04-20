using System.ComponentModel.DataAnnotations.Schema;

namespace PhamVanNhatHuy_ThucHanhEF.CodeFirst.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string TenLop { get; set; }
        [ForeignKey(nameof(Khoa))]
        public int MaKhoa { get; set; }
        public Khoa Khoa { get; set; }
        public List<SinhVien> DanhSachSinhVien { get; set; } = new List<SinhVien>();
    }
}
