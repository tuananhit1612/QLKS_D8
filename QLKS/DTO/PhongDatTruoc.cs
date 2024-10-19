using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhongDatTruoc
    {
        private int maPhong;
        private string tenLoaiPhong;
        private int tang;
        private string tinhTrang;
        private int maDatPhong;
        private string ngayDatPhong;
        private string ngayDen;
        private string ngayDi;
        private string ghiChu;
        private string cCCD;
        private string tenKhachHang;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int MaDatPhong { get => maDatPhong; set => maDatPhong = value; }
        public string NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public string NgayDen { get => ngayDen; set => ngayDen = value; }
        public string NgayDi { get => ngayDi; set => ngayDi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }

        public PhongDatTruoc() { }

        public PhongDatTruoc(int maPhong, string tenLoaiPhong, int tang, string tinhTrang, int maDatPhong, string ngayDatPhong, string ngayDen, string ngayDi, string ghiChu, string cCCD, string tenKhachHang)
        {
            this.maPhong = maPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.maDatPhong = maDatPhong;
            this.ngayDatPhong = ngayDatPhong;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
            this.ghiChu = ghiChu;
            this.cCCD = cCCD;
            this.tenKhachHang = tenKhachHang;
        }

        public PhongDatTruoc(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.maDatPhong = (int)row["MaDatPhong"];
            this.ngayDatPhong = row["NgayDatPhong"].ToString();
            this.ngayDen = row["NgayDen"].ToString();
            this.ngayDi = row["NgayDi"].ToString();
            this.ghiChu = row["GhiChu"].ToString();
            this.cCCD    = row["CCCD"].ToString();
            this.tenKhachHang = row["TenKhachHang"].ToString();
        }
    }
}
