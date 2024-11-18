using QuanLyKhachSan1.Views;
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

namespace QuanLyKhachSan1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowHomePage();
        }
        private void ShowHomePage()
        {
            // Tạo một thể hiện của HomePage và gán cho ContentControl
            TrangChu homePage = new TrangChu();
            MainContentControl.Content = homePage;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new TrangChu();
        }
        private void BookingButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new DatPhong();
        }
        private void RoomButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new QuanLyPhong();
        }
    }
}
