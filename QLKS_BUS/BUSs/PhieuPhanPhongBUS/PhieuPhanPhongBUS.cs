using QLKS_BUS.ViewModels;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhieuPhanPhongBUS
{
    public class PhieuPhanPhongBUS : IPhieuPhanPhongBUS
    {
        public void InsertOrUpdatePPPBus(PhieuPhanPhongViewModel p)
        {
            PHIEUPHANPHONG ppp = new PHIEUPHANPHONG() { SoPhieuPP = p.SoPhieuPP, SoPhieuThuePhong = p.SoPhieuThuePhong, GhiChu = p.GhiChu, Loai = "Thuê Trực Tiếp", MaPhong = p.MaPhong, SoPhieuDatPhong = null,TinhTrang = "Đang thuê" };
        }
    }
}
