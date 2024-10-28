using QLKS_BUS.ViewModels;

using QLKS_DAL.DALs.PhongDAL;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


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
            return phong.Where(x=>x.MaTang.ToString() == soTang).Select(p => new PhongViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tinhTrang = p.TinhTrang,
            }).ToList();
        }
        public List<PhongViewModel> GetAllPhongByTangLoaiPhong(string soTang,string loaiPhong)
        {
            var data = phong.Where(x => x.MaTang.ToString() == soTang).ToList();
            
            if (loaiPhong != "Tất Cả")
            {
               data = data.Where(x=>x.LOAIPHONG.TenLoaiPhong == loaiPhong).ToList();
            }
            return data.Select(x => new PhongViewModel()
            {
                maPhong= x.MaPhong.ToString(),
                tenLoaiPhong = x.LOAIPHONG.TenLoaiPhong,
                tinhTrang= x.TinhTrang,
            }).ToList();
           
        }

        public PhongViewModel GetPhongByMaPhong(string maPhong)
        {
            return phong.Where(x => x.MaPhong.ToString() == maPhong).Select(p => new PhongViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.LOAIPHONG.TenLoaiPhong,
                tinhTrang = p.TinhTrang,
                tang = p.MaTang.ToString(),
                maLoaiPhong  = p.MaLoaiPhong.ToString(),
                giaPhong = p.LOAIPHONG.DonGia,
                
            }).FirstOrDefault();
        }

        public PhongHetHanViewModel GetPhongHetHanByMaPhong(string maPhong)
        {
            return phong.Where(x => x.MaPhong.ToString() == maPhong).Select(p => new PhongHetHanViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.LOAIPHONG.TenLoaiPhong, // 1-1
                tinhTrang = p.TinhTrang,
                loai = p.PHIEUPHANPHONGs.FirstOrDefault().Loai,
                ngayBatDau = p.PHIEUDATPHONGs.FirstOrDefault().SoPhieuDatPhong != null
                      ? p.PHIEUDATPHONGs.FirstOrDefault().NgayNhanPhong
                      : p.PHIEUTHUEPHONGs.FirstOrDefault() != null
                      ? p.PHIEUTHUEPHONGs.FirstOrDefault().NgayThuePhong
                      : (DateTime?)null,
                tenKH = p.PHIEUDATPHONGs.FirstOrDefault().SoPhieuDatPhong != null
                      ? p.PHIEUDATPHONGs.FirstOrDefault().KHACHHANG.TenKhachHang
                      : p.PHIEUDATPHONGs.FirstOrDefault() != null
                      ? p.PHIEUDATPHONGs.FirstOrDefault().KHACHHANG.TenKhachHang
                      : null,
            }).FirstOrDefault();
        }

        public PhongViewModel GetPhongTrongByMaPhong(string maPhong)
        {
            return phong.Where(x=>x.MaPhong.ToString() == maPhong && x.TinhTrang.Contains("Trống")).Select(p => new PhongViewModel()
            {
                maPhong= p.MaPhong.ToString(),
                tenLoaiPhong = p.LOAIPHONG.TenLoaiPhong,
                tinhTrang = p.TinhTrang
            }).FirstOrDefault();
        }

        public PhongViewModel GetPhongTrongByMaPhongLoaiPhong(string maPhong, string loaiPhong)
        {
            return phong.Where(x => x.MaPhong.ToString() == maPhong && x.TinhTrang.Contains("Trống") && x.LOAIPHONG.TenLoaiPhong.Contains(loaiPhong)).Select(p => new PhongViewModel()
            {
                maPhong = p.MaPhong.ToString(),
                tenLoaiPhong = p.LOAIPHONG.TenLoaiPhong,
                tinhTrang = p.TinhTrang
            }).FirstOrDefault();
        }

        public void InserOrUpdatePhongBUS(PhongViewModel p)
        {
           PHONG PhongNew = new PHONG() { MaPhong = Int32.Parse(p.maPhong),TinhTrang = p.tinhTrang,MaTang = Byte.Parse(p.tang),MaLoaiPhong = Int32.Parse(p.maLoaiPhong)};
            _Phong.InserOrUpdatePhongDAL(PhongNew);
        }
    }
}
