using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs.PhieuBaoTriPhongDAL;
using QLKS_DAL.DALs.PhieuDonDepPhongDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongBaoTriBUS
{
    public class PhongBaoTriBUS : IPhongBaoTriBUS
    {
        PhieuBaoTriPhongDAL phieuBaoTriPhongDAL;
        public PhongBaoTriBUS()
        {
            phieuBaoTriPhongDAL = new PhieuBaoTriPhongDAL();
        }
        public PhongDangBaoTriViewModel GetPhongBaoTriByMaPhong(string maPhong)
        {
            var data = phieuBaoTriPhongDAL.GetListPhieuBaoTriPhong();
            return data.Where(x => x.MaPhong.ToString() == maPhong).Select(p => new PhongDangBaoTriViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.PHONG.LOAIPHONG.TenLoaiPhong, // 1-1
                tinhTrang = p.TinhTrang,
                moTa = p.PHONG.PHIEUDONDEPPHONGs.FirstOrDefault()?.MoTa ?? "", // vì do quan hệ maphong đang là khóa phụ ,1 phòng có thể có nhiều phieudonphong,nên khi truy xuất tới nó có thể là 1 tập hợp nên cần FirstOrDefault để lấy ra cái đầu tiên , th Dat thiet ke csdl ngu qua
                ngayGioBaoTri = p.NgayGioBaoTri,
                ngayGioBaoTriKetThuc = p.NgayGioKetThuc,
            }).FirstOrDefault();
        }
    }
}
