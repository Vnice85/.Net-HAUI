using Cau3.Models;
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

namespace Cau3
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
            SanPham sp = new SanPham() { MaSp = txtMaSanPham.Text, TenSp = txtTenSanPham.Text, SoLuong = Convert.ToInt32(txtSoLuong.Text), DonGia = Convert.ToInt32(txtDonGia.Text), MaLoai = txtMaLoai.Text };
            db.SanPhams.Add(sp);
            try
            {
                db.SaveChanges();
                dgSanPham.ItemsSource = db.SanPhams.ToList();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm");
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dgSanPham.ItemsSource = db.SanPhams.ToList();
        }

        private void dgvSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SanPham sp = (SanPham)dgSanPham.SelectedItem;
            if (sp != null)
            {
                txtMaSanPham.Text = sp.MaSp;
                txtTenSanPham.Text = sp.TenSp;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtDonGia.Text = sp.DonGia.ToString();
                txtMaLoai.Text = sp.MaLoai;
            }  
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            SanPham sp = db.SanPhams.Find(txtMaSanPham.Text);
            sp.TenSp = txtTenSanPham.Text;
            sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            sp.DonGia = Convert.ToInt32(txtDonGia.Text);
            sp.MaLoai = txtMaLoai.Text;
            try
            {
                db.SaveChanges();
                dgSanPham.ItemsSource = db.SanPhams.ToList();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi sửa sản phẩm");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa sản phẩm này?", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Question)==MessageBoxResult.OK)
            {
                SanPham sp = db.SanPhams.Find(txtMaSanPham.Text);
                db.SanPhams.Remove(sp);
                try
                {
                    db.SaveChanges();
                    dgSanPham.ItemsSource = db.SanPhams.ToList();
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xóa sản phẩm");
                }
            }    
        }
    }
}
