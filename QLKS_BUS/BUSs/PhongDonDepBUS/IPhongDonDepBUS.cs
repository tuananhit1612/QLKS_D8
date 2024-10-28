using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongDonDepBUS
{
    public interface IPhongDonDepBUS
    {
        PhongDangDonDepViewModel GetPhongDonDepByMaPhong(string maPhong);
    }
}
