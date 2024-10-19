using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhongHetHan
    {
        private int maPhong;
        private int tang;
        private string cCCD;
        private string tinhTrang;
        private int maHetHan;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string ghiChu;
        private string tenLoaiPhong;
        private string tenKhachHang;
        private decimal giaPhong;
        private decimal traTruoc;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int MaHetHan { get => maHetHan; set => maHetHan = value; }
        public DateTime NgayBatDau { get => ngayBatDau.Date; set => ngayBatDau = value.Date; }
        public DateTime NgayKetThuc { get => ngayKetThuc.Date; set => ngayKetThuc = value.Date; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }
        public decimal TraTruoc { get => traTruoc; set => traTruoc = value; }

        public PhongHetHan(int maPhong, int tang, string tinhTrang, int maHetHan, DateTime ngayBatDau, DateTime ngayKetThuc, string ghiChu, string tenLoaiPhong, string tenKhachHang , string cCCD , decimal giaPhong , decimal traTruoc)
        {
            this.maPhong = maPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.maHetHan = maHetHan;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.ghiChu = ghiChu;
            this.tenLoaiPhong = tenLoaiPhong;
            this.tenKhachHang = tenKhachHang;
            this.cCCD = cCCD;
            this.giaPhong= giaPhong;
            this.traTruoc = traTruoc;
        }   

        public PhongHetHan(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.maHetHan = (int)row["MaHetHan"];
            this.ngayBatDau = (DateTime)row["NgayBatDau"];
            this.ngayKetThuc = (DateTime)row["NgayKetThuc"];
            this.ghiChu = row["GhiChu"].ToString();
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.tenKhachHang = row["TenKhachHang"].ToString();
            this.cCCD = row["CCCD"].ToString() ;
            this.giaPhong = Convert.ToDecimal(row["GiaPhong"]);
            this.traTruoc = Convert.ToDecimal(row["TraTruoc"]);
        }
    }
}
