using System;
using System.Collections.Generic;

namespace PhamVanNhatHuy_ThucHanhEF.DatabaseFirst;

public partial class Lop
{
    public int Id { get; set; }

    public int? KhoaId { get; set; }

    public string? TenLop { get; set; }

    public virtual Khoa? Khoa { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
