using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.KhachHangDAL
{
    public interface IKhachHangDAL
    {
        List<KHACHHANG> GetKHACHHANGs();
        void InsertUpdateKhacHang(KHACHHANG kh);
    }
}
