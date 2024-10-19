using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Phong
    {
        private int soTang = 8;
        private int maPhong;
        private string tinhTang;

        public int SoTang { get => soTang; set => soTang = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string TinhTang { get => tinhTang; set => tinhTang = value; }


        public Phong() { }
        public Phong(int maPhong, string tinhTang)
        {
            this.maPhong = maPhong;
            this.tinhTang = tinhTang;
        }
        public Phong(DataRow row)
        {
            this.maPhong = (int)row["MaPhong"];
            this.tinhTang = row["TinhTrang"].ToString();
        }
    }
}
