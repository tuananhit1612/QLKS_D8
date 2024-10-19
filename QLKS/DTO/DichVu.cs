using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class DichVu
    {
        private int maDichVu;
        private int maLoaiDichVu;
        private string tenDichVu;
        private decimal gia;
        private string hinhAnh;

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public int MaLoaiDichVu { get => maLoaiDichVu; set => maLoaiDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public DichVu() { }
        public DichVu(int maDichVu, int maLoaiDichVu, string tenDichVu, decimal gia, string hinhAnh)
        {
            this.MaDichVu = maDichVu;
            this.MaLoaiDichVu = maLoaiDichVu;
            this.TenDichVu = tenDichVu;
            this.Gia = gia;
            this.HinhAnh = hinhAnh;
        }
        public DichVu(DataRow row)
        {
            this.MaDichVu = (int)row["MaDichVu"];
            this.MaLoaiDichVu = (int)row["MaLoaiDichVu"];
            this.TenDichVu = row["TenDichVu"].ToString();
            this.Gia = Convert.ToDecimal(row["Gia"]);
            this.HinhAnh = row["HinhAnh"].ToString();
        }
    }
}
