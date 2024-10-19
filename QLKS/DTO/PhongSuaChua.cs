
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhongSuaChua
    {
        private int maPhong;
        private int tang;
        private string tinhTrang;
        private int maSuaChua;
        private string ngayBatDau;
        private string ngayketThuc;
        private string thoiGianBatDau;
        private string thoiGianKetThuc;
        private string ghiChu;
        private string tenLoaiPhong;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int MaSuaChua { get => maSuaChua; set => maSuaChua = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public string ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public string NgayketThuc { get => ngayketThuc; set => ngayketThuc = value; }

        public PhongSuaChua(int maPhong, int tang, string tinhTrang, int maSuaChua, string ngaySuaChua, string thoiGianBatDau, string thoiGianKetThuc, string ghiChu,string TenLoaiPhong,string ngayKetThuc)
        {
            this.maPhong = maPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.maSuaChua = maSuaChua;
            this.ngayBatDau = ngaySuaChua;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.ghiChu = ghiChu;
            this.tenLoaiPhong = TenLoaiPhong;
            this.ngayketThuc = ngayKetThuc;
        }
        public PhongSuaChua(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.maSuaChua = (int)row["MaSuaChua"];
            this.ngayBatDau = row["NgayBatDau"].ToString();
            this.ngayketThuc = row["NgayKetThuc"].ToString();
            this.thoiGianBatDau = row["ThoiGianBatDau"].ToString();
            this.thoiGianKetThuc = row["ThoiGianKetThuc"].ToString();
            this.ghiChu = row["GhiChuSuaChua"].ToString();
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();

        }
    }
}
