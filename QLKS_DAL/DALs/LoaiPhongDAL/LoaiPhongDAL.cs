using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_DAL.DALs
{
    public class LoaiPhongDAL : ILoaiPhongDAL
    {
        public LoaiPhongDAL() 
        { 
        }
        public List<LOAIPHONG> GetListLoaiPhong()
        {
           return QLKS_DBContext.Instance.LOAIPHONGs.ToList();
        }

    }
}
