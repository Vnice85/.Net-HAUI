using System;
using System.Collections.Generic;

namespace WpfApp1.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string TenDangNhap { get; set; } = null!;
        public string? MatKhau { get; set; }
        public string? HoTen { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
