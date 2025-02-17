using Bai12_P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai12_P1
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        private string tenDangNhap, maKH;

        public HoaDon()
        {
            InitializeComponent();
        }

        public HoaDon(string tenDangNhap)
        {
            InitializeComponent();

            this.tenDangNhap = tenDangNhap;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtTenDangNhap.Text = tenDangNhap;
            txtNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void txtSDTKhachHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            KhachHang kh = db.KhachHangs.FirstOrDefault(kh => kh.SoDt == txtSDTKhachHang.Text);
            if (kh != null)
            {
                txtHoTenKhachHang.Text = kh.TenKh;
                maKH = kh.MaKh;
            }
        }

        private void txtMaHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            SanPham sp = db.SanPhams.Find(txtMaHang.Text);
            if (sp != null)
            {
                txtTenHang.Text = sp.TenSp;
                txtDonGia.Text = sp.DonGia.ToString();
            }
            else
                txtTenHang.Text = txtDonGia.Text = string.Empty;
        }

        private void txtChuyen_Click(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            var hm = from sp in db.SanPhams
                     where sp.MaSp == txtMaHang.Text
                     select new { sp.MaSp, sp.TenSp, sp.DonGia, SoLuong = txtSoLuong.Text, ThanhTien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text) };
            dgvHangMua.ItemsSource = hm.ToList();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            Models.HoaDon hd = new Models.HoaDon() { MaHd = txtSoHoaDon.Text, NgayLap = Convert.ToDateTime(txtNgayLap.Text), MaKh = maKH, NguoiLap = txtTenDangNhap.Text };
            db.HoaDons.Add(hd);
            HoaDonChiTiet ct = new HoaDonChiTiet() { MaHd = txtSoHoaDon.Text, MaSp = txtMaHang.Text, SoLuongMua = Convert.ToInt32(txtSoLuong.Text) };
            db.HoaDonChiTiets.Add(ct);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Hóa đơn đã được lưu");
            }
            catch
            {
                MessageBox.Show("Hóa đơn không được lưu");
            }    
        }
    }
}
