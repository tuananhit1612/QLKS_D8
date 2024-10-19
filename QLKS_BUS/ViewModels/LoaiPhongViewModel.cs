using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.ViewModels
{
    public class LoaiPhongViewModel
    {
        public int maLoaiPhong { get; set; }
        public string tienNghi { get; set; }
        public string dacTrung { get; set; }
        public string moTa { get; set; }
        public string tenLoaiPhong { get; set; }
        public int soNguoi { get; set; }
        public string dienTich { get; set; }
        public string hinhAnh { get; set; }
        public decimal donGia { get; set; }
    }
}
