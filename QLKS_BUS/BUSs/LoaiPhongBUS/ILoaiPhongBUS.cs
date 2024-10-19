using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.LoaiPhongBus
{
    public interface ILoaiPhongBUS
    {
        List<LoaiPhongViewModel> GetAllLoaiPhong();
        int DemLoaiPhongTrongByMaLoaiPhong(string maLoaiPhong);
        int DemLoaiPhongByMaLoaiPhong(string maLoaiPhong);
    }
}
