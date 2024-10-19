using QLKS_BUS.BUSs.LoaiPhongBus;
using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.LoaiPhongBUS
{
    public class LoaiPhongBUS : ILoaiPhongBUS
    {
        LoaiPhongDAL _loaiPhongDAl;
        List<LOAIPHONG> loaiPhong;
        public LoaiPhongBUS()
        {
            _loaiPhongDAl = new LoaiPhongDAL();
            loaiPhong = _loaiPhongDAl.GetListLoaiPhong();
        }

        public int DemLoaiPhongByMaLoaiPhong(string maLoaiPhong)
        {
            return loaiPhong.Where(x => x.MaLoaiPhong.ToString() == maLoaiPhong).SelectMany(x => x.PHONGs).Count();
        }

        public int DemLoaiPhongTrongByMaLoaiPhong(string maLoaiPhong)
        {
            return loaiPhong.Where(x => x.MaLoaiPhong.ToString() == maLoaiPhong).SelectMany(x => x.PHONGs).Where(x=>x.TinhTrang == "Trống").Count();
        }

        public List<LoaiPhongViewModel> GetAllLoaiPhong()
        {
           
            return loaiPhong.Select(x => new LoaiPhongViewModel()
            {
                maLoaiPhong = x.MaLoaiPhong,
                tenLoaiPhong = x.TenLoaiPhong,
                dienTich = x.DienTich,
                moTa = x.MoTa,
                hinhAnh = x.HinhAnh,
                donGia = x.DonGia,
                soNguoi = x.SoNguoi,
                dacTrung = string.Join(",", x.CHITIETDACTRUNGPHONGs.Select(dt => dt.DACTRUNGPHONG.TenDacTrung)),
                tienNghi = string.Join(",", x.CHITIETTIENNGHIs.Select(tn => tn.TIENNGHI.TenTienNghi))
            }).ToList();
            
        }
    }
}
