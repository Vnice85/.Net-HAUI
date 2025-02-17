using System;
using System.Collections.Generic;

#nullable disable

namespace Cau3.Modelss
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
