using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<StaffsIF> stafflist = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        public class StaffsIF
        {
            public string MaNV { get; set; } = string.Empty;
            public string Ten { get; set; } = string.Empty;
            public DateTime NgaySinh { get; set; }
            public string GioiTinh { get; set; } = string.Empty;
            public string PhongBan { get; set; } = string.Empty;
            public int HeSoLuong {  get; set; }

        }

        private void btnnhap_Click(object sender, RoutedEventArgs e)
        {

            StaffsIF staffs = new StaffsIF();

            if (tbxmanhanvien.Text != string.Empty)
                if (stafflist.Any(x => x.MaNV == tbxmanhanvien.Text))
                {
                    tbxmanhanvien.Text = "";
                    MessageBox.Show("Đã xuất hiện mã nhân viên này", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;

                }
            else
                    staffs.MaNV = tbxmanhanvien.Text;
            else
                {
                    MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            if (tbxhoten.Text != string.Empty)
                staffs.Ten = tbxhoten.Text;
            else { 
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }
            if(dpkngaysinh.SelectedDate.HasValue && dpkngaysinh.SelectedDate.Value < DateTime.Today)
            {
                staffs.NgaySinh = dpkngaysinh.SelectedDate.Value;
            }
          else
            {
                MessageBox.Show("Chọn ngày hợp lệ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            staffs.GioiTinh = (rbnnam.IsChecked.HasValue && rbnnam.IsChecked.Value) ? "Nam" : "Nữ";

            staffs.PhongBan = cbxphongban.Text;
            try
            {
                staffs.HeSoLuong = int.Parse(tbxhesoluong.Text);

            }
            catch
            {
                tbxhesoluong.Text = "";
                MessageBox.Show("Điền số tự nhiên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            stafflist.Add(staffs);
              dtg.ItemsSource = null;
           dtg.ItemsSource = stafflist;
            
        }

        private void btnnhaplai_Click(object sender, RoutedEventArgs e)
        {
            tbxmanhanvien.Text = "";
            tbxhoten.Text = "";
            cbxphongban.SelectedIndex = 0;
            dpkngaysinh.SelectedDate = DateTime.Today;
            rbnnam.IsChecked = true;
            tbxhesoluong.Text = "";

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dpkngaysinh.SelectedDate = DateTime.Today;
        }

        private void btnloc_Click(object sender, RoutedEventArgs e)
        {
        
            Loc loc = new Loc();
            int MaxHeSoLuong = stafflist.Max(x => x.HeSoLuong);
            List<StaffsIF> MaxSalary = new List<StaffsIF>();
            MaxSalary = stafflist.Where(x=>x.HeSoLuong == MaxHeSoLuong).ToList();
           loc.dtg.ItemsSource = MaxSalary;
            loc.ShowDialog();
        }

        private void btnxoa_Click(object sender, RoutedEventArgs e)
        {
            if (tbxdelete.Text != "")
            {
                if (!stafflist.Any(x => x.MaNV == tbxdelete.Text))
                {
                    tbxdelete.Text = "";
                    MessageBox.Show("Không có nhân viên mang mã đó", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    string text = tbxdelete.Text;
                    tbxdelete.Text = "";
                    stafflist.RemoveAll(x => x.MaNV == text);
                    dtg.ItemsSource = null;
                    dtg.ItemsSource = stafflist;
                }
            }
            else
            {
                tbxdelete.Text = "";
                MessageBox.Show("Nhập đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}