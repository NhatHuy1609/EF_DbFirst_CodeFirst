using System;
using System.Collections.Generic;

namespace PhamVanNhatHuy_ThucHanhEF.DatabaseFirst;

public partial class SinhVien
{
    public int Id { get; set; }

    public string? HoTen { get; set; }

    public string? MaSinhVien { get; set; }

    public int? Tuoi { get; set; }

    public int? MaLop { get; set; }

    public virtual Lop? MaLopNavigation { get; set; }
}
