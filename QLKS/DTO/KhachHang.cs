using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class KhachHang
    {
        private string tenKhachHang;
        private string cccd;
        private DateTime ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string email;

        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public DateTime NgaySinh { get => ngaySinh.Date; set => ngaySinh = value.Date; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang() { }

        public KhachHang(string tenKhachHang, string cccd, DateTime ngaySinh, string diaChi, string soDienThoai, string email)
        {
            this.tenKhachHang = tenKhachHang;
            this.cccd = cccd;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
        }

        public KhachHang(DataRow row)
        {
            this.tenKhachHang = row["TenKhachHang"].ToString();
            this.cccd = row["CCCD"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.ngaySinh = this.ngaySinh.Date;
            this.diaChi = row["DiaChi"].ToString();
            this.soDienThoai = row["SoDienThoai"].ToString();
            this.email = row["Email"].ToString();
        }
    }
}
