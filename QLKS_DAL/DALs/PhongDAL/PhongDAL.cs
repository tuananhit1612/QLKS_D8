using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhongDAL
{
    public  class PhongDAL : IPhongDAL
    {
        public List<PHONG> GetListPhong()
        {
            return QLKS_DBContext.Instance.PHONGs.ToList();
        }
    }
}
