using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhieuBaoTriPhongDAL
{
    public class PhieuBaoTriPhongDAL : IPhieuBaoTriPhongDAL
    {
        public List<PHIEUBAOTRIPHONG> GetListPhieuBaoTriPhong()
        {
            return QLKS_DBContext.Instance.PHIEUBAOTRIPHONGs.ToList();
        }
    }
}
