using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs.PhieuDatPhongDAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongDatTruocBUS
{
    public class PhongDatTruocBUS : IPhongDatTruocBUS
    {
        PhieuDatPhongDAL phieuDatPhongDAL;
        public PhongDatTruocBUS()
        {
            phieuDatPhongDAL = new PhieuDatPhongDAL();
        }
        public PhongDatTruocViewModel getPhongDatTruocByMaPhong(string maPhong)
        {
            var data = phieuDatPhongDAL.getPhieuDatPhong();
            return data.Where(x => x.MaPhong.ToString() == maPhong).Select(p => new PhongDatTruocViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.PHONG.LOAIPHONG.TenLoaiPhong, // 1-1
                tinhTrang = p.PHONG.TinhTrang,
                loai = p.PHIEUPHANPHONGs.FirstOrDefault().Loai,
                ngayBatDau = p.NgayNhanPhong,
                tenKH = p.KHACHHANG.TenKhachHang,
                ngayKetThuc = p.NgayDuKienTraPhong,
            }).FirstOrDefault();
        }
    }
}
