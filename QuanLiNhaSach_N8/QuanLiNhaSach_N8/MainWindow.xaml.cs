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

namespace QuanLiNhaSach_N8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event when click login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Đã đăng nhập", "Thông báo");

            //var windows = new Find();
            //windows.Show();
            //this.Close();

            var windows = new HoaDon();
            windows.Show();
            this.Close();
        }

        /// <summary>
        /// Contact with admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hplSignIn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            string content = "Facebook\t: fb.com/nguyenhuuhoa.15.04.1998/\nĐiện thoại\t: 0982327118";
            MessageBox.Show(content, "Thông tin", button, icon);
        }
    }
}
