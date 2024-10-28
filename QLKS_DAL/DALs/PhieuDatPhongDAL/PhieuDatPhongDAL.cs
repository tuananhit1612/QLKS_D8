using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhieuDatPhongDAl
{
    public class PhieuDatPhongDAL : IPhieuDatPhongDAL
    {
        public List<PHIEUDATPHONG> getPhieuDatPhong()
        {
            return QLKS_DBContext.Instance.PHIEUDATPHONGs.ToList();
        }
    }
}
