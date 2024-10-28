using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.PhongDAL
{
    public interface IPhongDAL
    {
        List<PHONG> GetListPhong();
        void InserOrUpdatePhongDAL(PHONG p);
    }
}
