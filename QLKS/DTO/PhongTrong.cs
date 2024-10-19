using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhongTrong
    {
        private int maPhong;
        private string tenLoaiPhong;
        private int tang;
        private string tinhTrang;
        private int soNguoi;
        private decimal giaPhong;
        private int maLoaiPhong;

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }
        public int MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }

        public PhongTrong() { }
        public PhongTrong(int maPhong, string tenLoaiPhong, int tang, string tinhTrang, int soNguoi, decimal giaPhong,  int maLoaiPhong)
        {
            this.maPhong = maPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.tang = tang;
            this.tinhTrang = tinhTrang;
            this.soNguoi = soNguoi;
            this.giaPhong = giaPhong;
            this.maLoaiPhong = maLoaiPhong;
            this.maLoaiPhong = maLoaiPhong;
        }
        public PhongTrong(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.tang = (int)row["Tang"];
            this.tinhTrang = row["TinhTrang"].ToString();
            this.soNguoi = (int)row["SoNguoi"];
            this.giaPhong = Convert.ToDecimal(row["GiaPhong"]);
            this.maLoaiPhong = (int)row["MaLoaiPhong"];
        }
    }
}
