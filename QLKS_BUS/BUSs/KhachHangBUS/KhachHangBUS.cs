using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs.KhachHangDAL;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.KhachHangBUS
{
    public class KhachHangBUS : IKhachHangBUS
    {
        KhachHangDAL khachHangDAL;
        public KhachHangBUS()
        {
            khachHangDAL = new KhachHangDAL();
        }
        public KhachHangViewModel getKhachHangByCCCD(string CCCD)
        {
            var data = khachHangDAL.GetKHACHHANGs();
            return data.Where(kh => kh.CCCD == CCCD).Select(x => new KhachHangViewModel()
            {
                cccd = x.CCCD,
                tenKH = x.TenKhachHang,
                ngaySinh = x.NgaySinh,
                diaChi = x.DiaChi,
                email = x.Email,
                SDT = x.SDT,
            }).FirstOrDefault();
        }

        public void InsertUpdateKhachHang(KhachHangViewModel kh)
        {
            var khachhangnew = new KHACHHANG() { CCCD = kh.cccd, TenKhachHang = kh.tenKH, NgaySinh = kh.ngaySinh, DiaChi = kh.diaChi, Email = kh.email, SDT = kh.SDT };
            khachHangDAL.InsertUpdateKhacHang(khachhangnew);
        }
    }
}
