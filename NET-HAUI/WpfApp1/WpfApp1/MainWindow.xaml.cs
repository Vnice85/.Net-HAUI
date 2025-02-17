using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.QLBanHangContext db = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            SanPham sp = new()
            {
                MaSp = txtMaSanPham.Text,
                TenSp = txtTenSanPham.Text,
                MaLoai = txtMaLoai.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = int.Parse(txtDonGia.Text)
            };
            db.SanPhams.Add(sp);
            db.SaveChanges();
            dgSanPham.ItemsSource = db.SanPhams.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgSanPham.ItemsSource = db.SanPhams.ToList();
        }
    }
}