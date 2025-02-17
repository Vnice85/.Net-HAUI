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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai12_P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            QLBanHangContext db = new QLBanHangContext();
            if (db.NguoiDungs.FirstOrDefault(n => n.TenDangNhap == txtTenDangNhap.Text && n.MatKhau == txtMatKhau.Password) != null)
                new HoaDon(txtTenDangNhap.Text).Show();
            else
                MessageBox.Show("Người sử dụng không tồn tại hoặc không đúng mật khẩu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
