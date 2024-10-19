using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhongDonDep
    {
        private int maPhong;
        private string tenLoaiPhong;
        private int tang;
        private string tinhTrang;
        private int maDonDep;
        private string ngayDonDep;
        private string thoiGianBatDau;
        private string thoiGianKetThuc;
        private string ghiChu;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int MaDonDep { get => maDonDep; set => maDonDep = value; }
        public string NgayDonDep { get => ngayDonDep; set => ngayDonDep = value; }
        public string ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public string ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public PhongDonDep(int maPhong, int maLoaiPhong, int tang, string tinhTrang, int maDonDep, string ngayDonDep, string thoiGianBatDau, string thoiGianKetThuc, string ghiChu)
        {
            this.maPhong = maPhong;
            this.tenLoaiPhong = TenLoaiPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.maDonDep = maDonDep;
            this.ngayDonDep = ngayDonDep;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.ghiChu = ghiChu;
        }

        public PhongDonDep(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.maDonDep = (int)row["MaDonDep"];
            this.ngayDonDep = row["NgayDonDep"].ToString();
            this.thoiGianBatDau = row["ThoiGianBatDau"].ToString();
            this.thoiGianKetThuc = row["ThoiGianKetThuc"].ToString();
            this.ghiChu = row["GhiChuDonDep"].ToString();
        }
    }
}
