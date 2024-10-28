using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhieuPhongDangThueDAL
{
    public class PhieuThuePhongDAL : IPhieuThuePhongDAL
    {
        public List<PHIEUTHUEPHONG> GetPHIEUTHUEPHONGs()
        {
            return QLKS_DBContext.Instance.PHIEUTHUEPHONGs.ToList();
        }

        public void InsertOrUpdatePTP(PHIEUTHUEPHONG ptp)
        {
            QLKS_DBContext.Instance.PHIEUTHUEPHONGs.Add(ptp);
            QLKS_DBContext.Instance.SaveChanges();
        }
    }
}
