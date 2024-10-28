using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhieuPhanPhongDAL
{
    public class PhieuPhanPhongDAL : IPhieuPhanPhongDAL
    {
        public void InsertOrUpdatePPPDAL(PHIEUPHANPHONG ppp)
        {
            QLKS_DBContext.Instance.PHIEUPHANPHONGs.AddOrUpdate(ppp);
            QLKS_DBContext.Instance.SaveChanges();

        }
    }
}
