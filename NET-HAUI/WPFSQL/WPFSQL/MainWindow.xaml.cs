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
using WPFSQL.Models;

namespace WPFSQL
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

        public class ProductDetail
        {
            public string MaSp { get; set; } = null!;
            public string? TenSp { get; set; }
            public string? MaLoai { get; set; }
            public int? SoLuong { get; set; }
            public int? DonGia { get; set; }
            public string? TenLoai { get; set; }
        }
        private void view()
        {
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals lsp.MaLoai
                        select new ProductDetail
                        {
                            MaSp = sp.MaSp,
                            TenSp = sp.TenSp,
                            SoLuong = sp.SoLuong,
                            DonGia = sp.DonGia,
                            MaLoai = sp.MaLoai,
                            TenLoai = lsp.TenLoai
                        };
            List<ProductDetail> productDetails = query.ToList();
            dtg.ItemsSource = null;
            dtg.ItemsSource = productDetails;
            cbx.ItemsSource = db.LoaiSanPhams.ToList();
            cbx.DisplayMemberPath = "TenLoai";
            cbx.SelectedValuePath = "MaLoai";
            cbx.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             view();
        }
       
        private void clear()
        {
            txtMaSp.Text =
            txtTenSp.Text =
            txtSoLuong.Text =
            txtDonGia.Text =
            string.Empty;
            txtMaSp.IsEnabled = true;
          
        }
        private void dtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtMaSp.IsEnabled = false;
            ProductDetail sp = (ProductDetail)dtg.SelectedItem;
            if (sp != null)
            {
                txtMaSp.Text = sp.MaSp;
                txtTenSp.Text = sp.TenSp;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtDonGia.Text = sp.DonGia.ToString();
                cbx.SelectedItem = db.LoaiSanPhams.Find(sp.MaLoai);
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!db.SanPhams.Any(x => x.MaSp == txtMaSp.Text))
                {
                    SanPham sp = new SanPham();
                    sp.MaSp = txtMaSp.Text;
                    sp.TenSp = txtTenSp.Text;
                    sp.SoLuong = int.Parse(txtSoLuong.Text);
                    sp.DonGia = int.Parse(txtDonGia.Text);
                       sp.MaLoai = cbx.SelectedValue.ToString();
                  
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                    view();
                    clear();
                }
                else
                {
                    MessageBox.Show("Không được trùng mã sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm sản phẩm");
            }


        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if(dtg.SelectedItem != null)
            {
               
                SanPham sp = db.SanPhams.Find(txtMaSp.Text);
                sp.TenSp = txtTenSp.Text;
                sp.SoLuong = int.Parse(txtSoLuong.Text);
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.MaLoai = cbx.SelectedValue.ToString();
                db.SaveChanges();
                view();
                clear();
            }
            else
            {
                MessageBox.Show("Sua cc");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dtg.SelectedItem != null)
            {

                SanPham sp = db.SanPhams.Find(txtMaSp.Text);
               MessageBoxResult rs = MessageBox.Show("Are you sure", "Thong bao", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                    view();
                    clear();
                }
               
            }
            else
            {
                MessageBox.Show("Xoa cc");
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs = MessageBox.Show("Are you sure", "Thong bao", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (rs == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }

}