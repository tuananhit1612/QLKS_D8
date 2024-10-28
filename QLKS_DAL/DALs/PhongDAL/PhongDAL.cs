using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public void InserOrUpdatePhongDAL(PHONG p)
        {
            QLKS_DBContext.Instance.PHONGs.AddOrUpdate(p);
            QLKS_DBContext.Instance.SaveChanges();
        }
    }
}
