using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace QuanLiNhaSach_N8
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Nhập sách clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNhapSach_Click(object sender, RoutedEventArgs e)
        {
            // do something
        }

        /// <summary>
        /// Tìm kiếm clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            var windows = new Find();
            windows.Show();
        }

        /// <summary>
        /// Hóa Đơn clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHoaDon_Click(object sender, RoutedEventArgs e)
        {
            var windows = new XemHoaDon();
            windows.Show();
        }

        /// <summary>
        /// Danh sách tài khoản clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDanhSachTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            var windows = new DanhSachTaiKhoan();
            windows.Show();
        }

		private void btnThongKeNgay_Click(object sender, RoutedEventArgs e)
		{
			var windows = new XemTheoNgay();
			windows.Show();
		}
	}
}
