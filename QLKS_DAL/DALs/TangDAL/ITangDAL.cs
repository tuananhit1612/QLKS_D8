using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs.TangDAL
{
    internal interface ITangDAL
    {
        List<TANG> GetListTang();
    }
}
