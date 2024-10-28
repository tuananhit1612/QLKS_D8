using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.ViewModels
{
    public class PhieuThuePhongViewModel
    {
        public int SoPhieuThuePhong { get; set; }
        public int MaPhong { get; set; }
        public int MaLoaiPhong { get; set; }
        public decimal TraTruoc { get; set; }
        public DateTime NgayThuePhong { get; set; }
        public DateTime NgayDuKienTraPhong { get; set; }
        public string GhiChu { get; set; }
        public string TinhTrang { get; set; }
        public int MaNhanVien { get; set; }
        public string CCCD { get; set; }
    }
}
