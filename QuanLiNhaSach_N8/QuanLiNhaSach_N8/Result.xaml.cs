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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        

        bool[] check = new bool[3];
        List<Book> listbook = new List<Book>();

        public Result()
        {
            InitializeComponent();
            check = Find.check;
            listbook = Find.listbook;
            //MessageBox.Show(listbook[2].name);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (check[0] == false && check[1] == false && check[2] == false)
            {
                MessageBox.Show("Không tìm thấy sách");
            }
            else if (check[0] == true)
            {
                List<Book> res = new List<Book>();

                for (int i = 0; i < listbook.Count; i++)
                {
                    if (listbook[i].name == "Nhập môn lập trình")
                    {
                        res.Add(listbook[i]);
                    }
                }

                lblRes11.Content = res[0].name;
                lblRes12.Content = res[0].Author;
                lblRes13.Content = res[0].Year.ToString();
            }
            else if (check[1] == true)
            {
                List<Book> res = new List<Book>();

                for (int i = 0; i < listbook.Count; i++)
                {
                    if (listbook[i].Author == "KHTN")
                    {
                        res.Add(listbook[i]);
                    }
                }

                lblRes11.Content = res[0].name;
                lblRes12.Content = res[0].Author;
                lblRes13.Content = res[0].Year.ToString();

                lblRes21.Content = res[1].name;
                lblRes22.Content = res[1].Author;
                lblRes23.Content = res[1].Year.ToString();
            }
            // còn vài trường hợp nữa chưa làm
        }
    }
}
