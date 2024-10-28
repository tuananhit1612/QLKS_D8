using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.ViewModels
{
    public class PhongDangDonDepViewModel : PhongViewModel
    {
        public DateTime? ngayGioDonDep { get;set; }
        public DateTime? ngayGioKetThuc { get; set; }
        public string moTa { get; set; }
    }
}
