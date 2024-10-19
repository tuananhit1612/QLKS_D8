using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.TangDAL
{
    public class TangDAL : ITangDAL
    {
        public List<TANG> GetListTang()
        {
            return QLKS_DBContext.Instance.TANGs.ToList();
        }
    }
}
