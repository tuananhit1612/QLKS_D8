using Microsoft.SqlServer.Server;
using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhongDangThueBUS
{
    public interface IPhongDangThueBUS
    {
        PhongDangThueViewModel GetPhongDangThueByMaPhong(string maPhong);
        void InsertOrUpdatePhongThueBUS(PhieuThuePhongViewModel phong);
    }
}
