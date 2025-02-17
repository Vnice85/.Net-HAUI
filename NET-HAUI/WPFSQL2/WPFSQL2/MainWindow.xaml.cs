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
using WPFSQL2.Models;

namespace WPFSQL2
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            overlay.Visibility = Visibility.Visible;
            if (db.NguoiDungs.Any(x => x.TenDangNhap == txtName.Text && x.MatKhau == pswPassword.Password))
            {
               
                new HoaDon(txtName.Text).Show();
                overlay.Visibility = Visibility.Collapsed;

            }
            else
            {
                
                MessageBox.Show("Don't have this account","Notification",MessageBoxButton.OK, MessageBoxImage.Information); overlay.Visibility = Visibility.Collapsed;
            }
        }
    }
}