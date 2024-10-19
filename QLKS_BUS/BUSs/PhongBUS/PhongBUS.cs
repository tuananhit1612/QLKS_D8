using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs;
using QLKS_DAL.DALs.PhongDAL;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongBUS
{
    public class PhongBUS : IPhongBUS
    {
        PhongDAL _Phong;
        List<PHONG> phong;
        public PhongBUS() 
        { 
            _Phong = new PhongDAL();
            phong = _Phong.GetListPhong();
        }

        public int DemTrangThaiPhong(int k , string loaiphong)
        {
            string trangthai;
            switch (k)
            {
                case 0:
                    trangthai = null;
                    break;
                case 1:
                    trangthai = "Trống";
                    break;
                case 2:
                    trangthai = "Đang Thuê";
                    break;
                case 3:
                    trangthai = "Đã đặt trước";
                    break;
                case 4:
                    trangthai = "Hết Hạn";
                    break;
                case 5:
                    trangthai = "Đang bảo trì";
                    break;
                case 6:
                    trangthai = "Đang dọn dẹp";
                    break;
                default: return -1;

            }
            
            var tmpPhong = phong;
            if(!loaiphong.Contains("Tất Cả"))
            {
                tmpPhong = tmpPhong.Where(p => p.LOAIPHONG.TenLoaiPhong.Contains(loaiphong)).ToList();
            }

            if(trangthai != null)
            {
                tmpPhong = tmpPhong.Where(p=>p.TinhTrang.Contains(trangthai)).ToList();
            }
            return tmpPhong.Count;
            
        }

        public List<PhongViewModel> GetAllPhong()
        {
            return phong.Select(x => new PhongViewModel()
            {
                maPhong = x.MaPhong.ToString(),
                tang = x.MaTang.ToString(),
                tenLoaiPhong = x.LOAIPHONG.TenLoaiPhong,

            }).ToList();
        }

        public List<PhongViewModel> GetAllPhongByTang(string soTang)
        {
             
        }
    }
}
