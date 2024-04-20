using System;
using System.Collections.Generic;

namespace PhamVanNhatHuy_ThucHanhEF.DatabaseFirst;

public partial class Khoa
{
    public int Id { get; set; }

    public string? TenKhoa { get; set; }

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
