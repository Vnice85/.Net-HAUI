using System;
using System.Collections.Generic;

namespace WPFSQL.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public string TenDangNhap { get; set; } = null!;
        public string? MatKhau { get; set; }
        public string? HoTen { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
