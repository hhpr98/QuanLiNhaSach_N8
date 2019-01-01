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

namespace QuanLiNhaSach_N8
{
    /// <summary>
    /// Interaction logic for DanhSachTaiKhoan.xaml
    /// </summary>
    public partial class DanhSachTaiKhoan : Window
    {
        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        class TK
        {
            public string MaTK { get; set; }
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
            public int LoaiTK { get; set; }
        }

        private List<TK> getItem()
        {
            var items = new List<TK>() { new TK() {MaTK="TK001",TenDangNhap="admin",MatKhau="123",LoaiTK=0},
                                         new TK() {MaTK="TK002",TenDangNhap="hieu",MatKhau="hieu123",LoaiTK=1 },
                                         new TK() {MaTK="TK003",TenDangNhap="hoi",MatKhau="hoi123",LoaiTK=1},
                                         new TK() {MaTK="TK004",TenDangNhap="huan",MatKhau="huan123",LoaiTK=1} };
            return items;
        }

        /// <summary>
        /// Windows loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var items = getItem();
            itemListView.ItemsSource = items;
        }
    }
}
