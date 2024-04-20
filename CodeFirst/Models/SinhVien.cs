using System.ComponentModel.DataAnnotations.Schema;

namespace PhamVanNhatHuy_ThucHanhEF.CodeFirst.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string MaSinhVien { get; set; }
        public int Tuoi { get; set; }
        [ForeignKey(nameof(Lop))]
        public int MaLop { get; set; }
        public Lop Lop { get; set; }
    }
}
