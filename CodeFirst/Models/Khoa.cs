namespace PhamVanNhatHuy_ThucHanhEF.CodeFirst.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        public string TenKhoa { get; set; }
        public List<Lop> DanhSachLops { get; set; } = new List<Lop>();
    }
}
