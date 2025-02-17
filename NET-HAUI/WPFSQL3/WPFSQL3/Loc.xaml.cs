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
using WPFSQL3.Models;

namespace WPFSQL3
{
    /// <summary>
    /// Interaction logic for Loc.xaml
    /// </summary>
    public partial class Loc : Window
    {
        private List<SanPham> lsp;
        private QLBanHangContext db = new();
        public Loc(List<SanPham> lsp)
        {
            InitializeComponent();
            this.lsp = lsp;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            dtgSanPhams.ItemsSource = lsp;
        }
    }
}
