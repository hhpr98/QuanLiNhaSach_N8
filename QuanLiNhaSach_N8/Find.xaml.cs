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
    /// Interaction logic for Find.xaml
    /// </summary>
    public partial class Find : Window
    {
        public Find()
        {
            InitializeComponent();
        }

        //public static List<Book> listbook = new List<Book>();

        public static bool[] check = new bool[3] { false, false, false };

        /// <summary>
        /// load data when windows start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //listbook.Add(new Book { name = "Nhập môn lập trình", Author = "KHTN", Year = 2008 });
            //listbook.Add(new Book { name = "Kĩ thuật lập trình", Author = "KHTN", Year = 2008 });
            //listbook.Add(new Book { name = "Tấm cám", Author = "Kim Đồng", Year = 2003 });
        }

        private void cbName_Checked(object sender, RoutedEventArgs e)
        {
            check[0] = true;
            MessageBox.Show("Box Name checked");
        }

        private void cbAuthor_Checked(object sender, RoutedEventArgs e)
        {
            check[1] = true;
            MessageBox.Show("Box Author checked");
        }

        private void cbYear_Checked(object sender, RoutedEventArgs e)
        {
            check[2] = true;
            MessageBox.Show("Box Year checked");
        }

        private void cbYear_Unchecked(object sender, RoutedEventArgs e)
        {
            check[2] = false;
            MessageBox.Show("Box Year unchecked");
        }

        private void cbName_Unchecked(object sender, RoutedEventArgs e)
        {
            check[0] = false;
            MessageBox.Show("Box Name unchecked");
        }

        private void cbAuthor_Unchecked(object sender, RoutedEventArgs e)
        {
            check[1] = false;
            MessageBox.Show("Box Author unchecked");
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var windows = new Result();
            this.Hide();
            windows.Show();
        }
    }
}
