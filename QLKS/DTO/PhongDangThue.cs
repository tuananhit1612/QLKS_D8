using System;
using System.Data;

namespace QLKS.DTO
{
    public class PhongDangThue
    {
        private int maThue;
        private int maPhong;
        private string cCCD;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string ghiChu;
        private string tenLoaiPhong;
        private int tang;
        private string tinhTrang;
        private string tenKhachHang;
        private int maLoaiPhong;
        private decimal traTruoc = 0;


        public int MaThue { get => maThue; set => maThue = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime NgayBatDau { get => ngayBatDau.Date; set => ngayBatDau = value.Date; }
        public DateTime NgayKetThuc { get => ngayKetThuc.Date; set => ngayKetThuc = value.Date; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public decimal TraTruoc { get => traTruoc; set => traTruoc = value; }

        public PhongDangThue() { }

        public PhongDangThue(int maThue, int maPhong, string CCCD, DateTime ngayBatDau, DateTime ngayKetThuc, string ghiChu, string tenLoaiPhong, int tang, string tinhTrang, string tenKhachHang , int maLoaiPhong , decimal traTruoc)
        {
            this.maThue = maThue;
            this.maPhong = maPhong;
            this.cCCD = CCCD;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.ghiChu = ghiChu;
            this.tenLoaiPhong = tenLoaiPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.tenKhachHang = tenKhachHang;
            this.maLoaiPhong = maLoaiPhong;
            this.traTruoc = traTruoc;
        }

        public PhongDangThue(DataRow row)
        {
            this.maThue = (int)row["MaThue"];
            this.maPhong = (int)row["MaPhong"];
            this.cCCD = row["CCCD"].ToString();
            this.ngayBatDau = (DateTime)row["NgayBatDau"];
            this.ngayKetThuc = (DateTime)row["NgayKetThuc"];
            this.ghiChu = row["GhiChu"].ToString();
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.tenKhachHang = row["TenKhachHang"].ToString();
            this.maLoaiPhong = (int)row["MaLoaiPhong"];
            this.traTruoc = Convert.ToDecimal(row["TraTruoc"]);

        }
    }
}
