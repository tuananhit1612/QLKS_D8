using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongBaoTriBUS
{
    public interface IPhongBaoTriBUS
    {
        PhongDangBaoTriViewModel GetPhongBaoTriByMaPhong(string maPhong);
    }
}
