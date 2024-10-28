using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.KhachHangDAL
{
    public class KhachHangDAL : IKhachHangDAL
    {
        public List<KHACHHANG> GetKHACHHANGs()
        {
            return QLKS_DBContext.Instance.KHACHHANGs.ToList();
        }

        public void InsertUpdateKhacHang(KHACHHANG kh)
        {
            QLKS_DBContext.Instance.KHACHHANGs.AddOrUpdate(kh);
            QLKS_DBContext.Instance.SaveChanges();
        }
    }
}
