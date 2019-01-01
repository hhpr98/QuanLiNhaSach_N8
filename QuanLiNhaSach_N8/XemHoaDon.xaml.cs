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
    /// Interaction logic for XemHoaDon.xaml
    /// </summary>
    public partial class XemHoaDon : Window
    {
        public XemHoaDon()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            var mahd = txtInput.Text;

            var db = new BOOKEntities();

            var hoadon = db.HoaDons.Find(mahd);

            if (hoadon==null) // không tìm thấy mã hóa đơn nào
            {
                var img = MessageBoxImage.Error;
                var btn = MessageBoxButton.OK;
                var msg = "Không tìm thấy mã hóa đơn!";
                MessageBox.Show(msg, "Thông báo", btn, img);
            }
            else // có mã hóa đơn
            {
                var windows = new HoaDonDetailxaml();
                windows.Sender(txtInput.Text); // gửi mã hóa đơn sang form chi tiết hóa đơn
                windows.Show();
                //this.Close();
            }
        }

        /// <summary>
        /// Hủy bỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
