using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan1.Models
{
    public enum TrangThaiPhong
    {
        DaDat,
        DangSuDung,
        Trong
    }
    public class Phong
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TenKhach { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuongNguoi { get; set; }
        public TrangThaiPhong TrangThai { get; set; }


    }
}
