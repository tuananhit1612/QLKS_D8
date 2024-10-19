using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class ChiTietLoaiPhong
    {
        private int maLoaiPhong;
        private string tenLoaiPhong;
        private decimal dienTichPhong;
        private string moTa;
        private int soNguoi;
        private string hinhAnh;
        private decimal giaPhong;
        private string coSoVatChat;
        private string dacTrung;
        private string tienNghi;
        private int tongPhong;
        private int tongPhongTrong;

        public int MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public decimal DienTichPhong { get => dienTichPhong; set => dienTichPhong = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string CoSoVatChat { get => coSoVatChat; set => coSoVatChat = value; }
        public string DacTrung { get => dacTrung; set => dacTrung = value; }
        public string TienNghi { get => tienNghi; set => tienNghi = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public int TongPhong { get => tongPhong; set => tongPhong = value; }
        public int TongPhongTrong { get => tongPhongTrong; set => tongPhongTrong = value; }

        public ChiTietLoaiPhong(int maLoaiPhong, string tenLoaiPhong, decimal dienTichPhong, string moTa,int soNguoi, string hinhAnh, decimal giaPhong, string coSoVatChat, string dacTrung, string tienNghi , int tongPhong , int tongPhongTrong)
        {
            this.maLoaiPhong = maLoaiPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.dienTichPhong = dienTichPhong;
            this.moTa = moTa;
            this.soNguoi = soNguoi;
            this.hinhAnh = hinhAnh;
            this.giaPhong = giaPhong;
            this.coSoVatChat = coSoVatChat;
            this.dacTrung = dacTrung;
            this.tienNghi = tienNghi;
            this.tongPhong = tongPhong;
            this.tongPhongTrong = tongPhongTrong;
        }

        public ChiTietLoaiPhong(DataRow row)
        {
            this.maLoaiPhong = (int)row["MaLoaiPhong"];
            this.tenLoaiPhong = row["TenLoaiPhong"].ToString();
            this.dienTichPhong = (decimal)row["DienTichPhong"];
            this.moTa = row["MoTa"].ToString();
            this.SoNguoi = (int)row["SoNguoi"];
            this.hinhAnh = row["HinhAnh"].ToString();
            this.giaPhong =  Convert.ToDecimal(row["GiaPhong"]);
            this.coSoVatChat = row["CoSoVatChat"].ToString();
            this.dacTrung = row["DacTrung"].ToString();
            this.tienNghi = row["TienNghi"].ToString();
            this.tongPhong = (int)row["TongSoLuongPhong"];
            this.tongPhongTrong = (int)row["SoLuongPhongConTrong"];
        }

    }
}
