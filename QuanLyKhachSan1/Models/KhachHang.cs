using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan1.Models
{
    public class KhachHang
    {
        public int STT { get; set; }
        public bool KhachChinh { get; set; }
        public string TenKhachHang { get; set; }
        public string CMNDHoChieu { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string Phong { get; set; }
    }
}
