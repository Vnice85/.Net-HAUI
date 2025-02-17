using System;
using System.Collections.Generic;

namespace WPFSQL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; } = null!;
        public string? TenKh { get; set; }
        public string? SoDt { get; set; }
        public string? DiaChi { get; set; }
        public string? TenDangNhap { get; set; }

        public virtual NguoiDung? TenDangNhapNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
