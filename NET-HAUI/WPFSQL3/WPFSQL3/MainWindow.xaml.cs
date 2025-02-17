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
using WPFSQL3.Models;

namespace WPFSQL3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QLBanHangContext db = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtMaSp.Text = txtTenSp.Text = txtMaLoai.Text = txtDonGia.Text = txtSoLuong.Text = string.Empty;
            txtMaSp.IsEnabled = true;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgSanPhams.ItemsSource = db.SanPhams.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            SanPham sp = new();
            if(!db.SanPhams.Any(x=>x.MaSp == txtMaSp.Text))
            {
                try
                {
                    sp.MaSp = txtMaSp.Text;
                    if (db.LoaiSanPhams.Any(x => x.MaLoai == txtMaLoai.Text))
                    {
                        sp.MaLoai = txtMaLoai.Text;
                    }
                    else
                    {
                        LoaiSanPham ls = new LoaiSanPham() { MaLoai = txtMaLoai.Text };
                        sp.MaLoai = ls.MaLoai;
                        db.LoaiSanPhams.Add(ls);
                    }
                    sp.DonGia = int.Parse(txtDonGia.Text);
                    sp.SoLuong = int.Parse(txtSoLuong.Text);
                    sp.TenSp = txtTenSp.Text;
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                    
                    dtgSanPhams.ItemsSource = db.SanPhams.ToList();
                }
                catch
                {
                    MessageBox.Show("Co loi khi them san pham");
                }
                clear();
            }
            else
            {
                MessageBox.Show("Khong duoc them trung san pham");
            }
           
           
        }

        private void dtgSanPhams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SanPham sp = (SanPham)dtgSanPhams.SelectedItem;
            if (sp != null)
            {
                txtMaSp.Text = sp.MaSp;
                txtTenSp.Text = sp.TenSp;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtDonGia.Text = sp.DonGia.ToString();
                txtMaLoai.Text = sp.MaLoai;
            }
           
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dtgSanPhams.SelectedItem != null)
            {
                SanPham sp = db.SanPhams.Find(txtMaSp.Text);
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                dtgSanPhams.ItemsSource = db.SanPhams.ToList();
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            clear();
        }


        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (dtgSanPhams.SelectedItem != null)
            {

                SanPham sp = db.SanPhams.Find(txtMaSp.Text);
                sp.TenSp = txtTenSp.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.DonGia = int.Parse(txtDonGia.Text);
                if (db.LoaiSanPhams.Any(x => x.MaLoai == txtMaLoai.Text))
                {
                    sp.MaLoai = txtMaLoai.Text;
                }
                else
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.MaLoai = txtMaLoai.Text;
                    db.LoaiSanPhams.Add(lsp);
                    sp.MaLoai = lsp.MaLoai;
                }
                db.SaveChanges();
        
                dtgSanPhams.ItemsSource = db.SanPhams.ToList();

            }
            else
            {
                MessageBox.Show("Sua cc");
            }
            clear();
        }

      

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButton.OKCancel);
            if(rs == MessageBoxResult.OK) { Environment.Exit(0); }
            
        }

        private void btnLoc_Click(object sender, RoutedEventArgs e)
        {
            if (txtLoc.Text != string.Empty)
            {
                if(db.LoaiSanPhams.Any(x=>x.MaLoai == txtLoc.Text))
                {
                    var a = from b in db.SanPhams
                            where b.MaLoai == txtLoc.Text
                            select b;
                    new Loc(a.ToList()).Show();
                }
                else
                {
                    MessageBox.Show("Dell có mã này", "ĐCM", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Lọc cái lon, ghi điều kiện dell đâu mà lọc", "ĐCM", MessageBoxButton.OK);
            }



        }
    }
}