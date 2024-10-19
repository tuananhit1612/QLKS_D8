using QLKS_BUS.ViewModels;
using QLKS_DAL.DALs.TangDAL;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.TangBUS
{
    public class TangBUS : ITangBUS
    {
        TangDAL _Tang;
        List<TANG> tang;
        public TangBUS() 
        {
            _Tang = new TangDAL();
            tang = _Tang.GetListTang();
        }
        public List<TangViewModel> GetALLTang()
        {
            return tang.Select(tang => new TangViewModel()
            {
                maTang = tang.MaTang.ToString(),
                tenTang= tang.TenTang,
                tinhTrang = tang.TrangThai
            }).ToList();
        }
    }
}
