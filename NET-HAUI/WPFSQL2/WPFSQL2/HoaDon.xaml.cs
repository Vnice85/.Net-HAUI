using System;
using System.Collections.Generic;
using System.Globalization;
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
using WPFSQL2.Models;

namespace WPFSQL2
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        private QLBanHangContext db = new();
        private string Name,maKH;
        public HoaDon(string Name)
        {
            InitializeComponent();
            this.Name = Name;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtTenDangNhap.Text = Name;
            txtNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void txtSDT_TextChanged(object sender, TextChangedEventArgs e)
        {

            KhachHang kh = db.KhachHangs.FirstOrDefault(x => x.SoDt == txtSDT.Text);

            if (kh != null)
            {
                txtHoTen.Text = kh.TenKh;
                maKH = kh.MaKh;
            }
            else
            {
                txtHoTen.Text = "NULL";
            }
        }

        private void txtMaHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            SanPham sp = db.SanPhams.Find(txtMaHang.Text);
            if (sp != null)
            {
                txtTenHang.Text = sp.TenSp;
                txtDonGia.Text = sp.DonGia.ToString();
            }
            else
            {
                txtTenHang.Text = "NULL";
                txtDonGia.Text = "NULL";
            }
              
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Models.HoaDon hd = new Models.HoaDon()
            {
                MaKh = maKH,
                MaHd = txtSoHD.Text,
                NgayLap = DateTime.ParseExact(txtNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
            NguoiLap = txtTenDangNhap.Text
            };
            db.HoaDons.Add(hd);
            HoaDonChiTiet hdct = new() 
            { 
                MaHd = txtSoHD.Text,
                MaSp = txtMaHang.Text,
                SoLuongMua = Convert.ToInt32(txtSoLuong.Text),
            };
            try
            {
                db.HoaDonChiTiets.Add(hdct);
                db.SaveChanges();
                MessageBox.Show("Đã thêm sản phẩm", "Thông báo", MessageBoxButton.OK);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
             var a = from b in db.SanPhams
                     where b.MaSp == txtMaHang.Text
                     select new
                     {
                         b.MaSp,
                         b.TenSp,
                         b.DonGia,
                         SoLuong = int.Parse(txtSoLuong.Text),
                         ThanhTien = b.DonGia * int.Parse(txtSoLuong.Text)
                     };
            try
            {
                dtg.ItemsSource = a.ToList();

            }
            catch
            {
                MessageBox.Show("Có lỗi khi chuyển sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
