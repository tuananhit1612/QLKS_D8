using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongBUS
{
    public interface IPhongBUS
    {
        List<PhongViewModel> GetAllPhong();
        List<PhongViewModel> GetAllPhongByTang(string soTang);
        PhongViewModel GetPhongTrongByMaPhong(string maPhong);
        PhongViewModel GetPhongByMaPhong(string maPhong);
        PhongViewModel GetPhongTrongByMaPhongLoaiPhong(string maPhong,string loaiPhong);
        PhongHetHanViewModel GetPhongHetHanByMaPhong(string maPhong);
        int DemTrangThaiPhong(int k,string loaiphong);

        void InserOrUpdatePhongBUS(PhongViewModel p);
    }
}
