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
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        class Book
        {
            public int STT { get; set; }
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public int SL { get; set; }
            public int DonGia { get; set; }
            public int ThanhTien { get; set; }
        }

        private List<Book> getItem()
        {
            var items = new List<Book>() { new Book() { STT=1, MaSach="S001", TenSach="Nhập môn lập trình",SL=1,DonGia=50000,ThanhTien=50000},
                                            new Book() { STT=2, MaSach="S002", TenSach="Kĩ thuật lập trình",SL=3,DonGia=55000,ThanhTien=165000 },
                                            new Book() { STT=3, MaSach="S003", TenSach="Xác suất thống kê",SL=1,DonGia=80000,ThanhTien=80000 }};
            return items;
        }

        /// <summary>
        ///  Load danh sách các sách của hóa đơn
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
