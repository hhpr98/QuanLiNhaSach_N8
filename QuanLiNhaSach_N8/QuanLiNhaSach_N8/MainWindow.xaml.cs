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
            if (txtUsername.Text == "")
            {
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                string content = "Lỗi : Không được để trống tên đăng nhập";
                MessageBox.Show(content, "Lỗi!", button, icon);
            }
            else if (txtPassword.Password == "")
            {
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                string content = "Lỗi : Không được để trống mật khẩu";
                MessageBox.Show(content, "Lỗi!", button, icon);
            }
            else if (txtUsername.Text!="admin")
            {
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string content = "Thông báo : Sai tên đăng nhập hoặc mật khẩu";
                MessageBox.Show(content, "Thông báo", button, icon);
            }
            else if (txtPassword.Password != "123")
            {
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string content = "Thông báo : Sai mật khẩu";
                MessageBox.Show(content, "Thông báo", button, icon);
            }
            else
            {
                var windows = new DashBoard();
                windows.Show();
                this.Close();
            }


            
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

        /// <summary>
        /// Exit screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        ///  Information of project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            string content = "Quản lí nhà sách v1.0\nby T4H";
            MessageBox.Show(content, "Thông tin", button, icon);
        }


        /// <summary>
        /// Password box focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
        }


        /// <summary>
        /// username box focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUsername.Foreground = System.Windows.Media.Brushes.Black;
            txtUsername.Text = "";
        }

        /// <summary>
        /// Password box loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Loaded(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "12345678";
        }
    }
}
