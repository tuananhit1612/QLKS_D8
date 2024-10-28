using QLKS_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.BUSs.PhieuPhanPhongBUS
{
    public interface IPhieuPhanPhongBUS
    {
        void InsertOrUpdatePPPBus(PhieuPhanPhongViewModel p);
    }
}
