using QuanLyKhachSan1.Models;
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
using System.Windows.Shapes;

namespace QuanLyKhachSan1.Views
{
    /// <summary>
    /// Interaction logic for DatPhong.xaml
    /// </summary>
    public partial class DatPhong : UserControl
    {
        public ObservableCollection<KhachHang> DanhSachKhach { get; set; }
        public DatPhong()
        {
            InitializeComponent();

            DanhSachKhach = new ObservableCollection<KhachHang>
            {
                new KhachHang{ STT = 1, KhachChinh = true, TenKhachHang = "Khách lẻ", CMNDHoChieu = "123456789", DienThoai = "0900000000", Email = "", Phong = "201"}
            };

            this.DataContext = this;
        }

    }
}
