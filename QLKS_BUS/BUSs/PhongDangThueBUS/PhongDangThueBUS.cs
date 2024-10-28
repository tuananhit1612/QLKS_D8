using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs.PhieuDonDepPhongDAL;
using QLKS_DAL.DALs.PhieuPhongDangThueDAL;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongDangThueBUS
{
    public class PhongDangThueBUS : IPhongDangThueBUS
    {
        PhieuThuePhongDAL phieuThuePhongDAL;
        public PhongDangThueBUS()
        {
            phieuThuePhongDAL = new PhieuThuePhongDAL();
        }
        public PhongDangThueViewModel GetPhongDangThueByMaPhong(string maPhong)
        {
            var data = phieuThuePhongDAL.GetPHIEUTHUEPHONGs();
            return data.Where(x => x.MaPhong.ToString() == maPhong).Select(p => new PhongDangThueViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.PHONG.LOAIPHONG.TenLoaiPhong, // 1-1
                tinhTrang = p.TinhTrang,
                loai = p.PHIEUPHANPHONGs.FirstOrDefault().Loai,
                ngayBatDau = p.NgayThuePhong,
                tenKH = p.KHACHHANG.TenKhachHang,
                ngayDuKienKetThuc = p.NgayDuKienTraPhong,
            }).FirstOrDefault();
        }

        public void InsertOrUpdatePhongThueBUS(PhieuThuePhongViewModel phong)
        {
            PHIEUTHUEPHONG phieuThuePhong = new PHIEUTHUEPHONG() {SoPhieuThuePhong = phong.SoPhieuThuePhong,MaPhong = phong.MaPhong,MaLoaiPhong = phong.MaLoaiPhong,TraTruoc = phong.TraTruoc,NgayThuePhong = phong.NgayThuePhong,NgayDuKienTraPhong = phong.NgayDuKienTraPhong,GhiChu = phong.GhiChu,TinhTrang = phong.TinhTrang,MaNhanVien = phong.MaNhanVien,CCCD = phong.CCCD};
            phieuThuePhongDAL.InsertOrUpdatePTP(phieuThuePhong);
        }
    }
}
