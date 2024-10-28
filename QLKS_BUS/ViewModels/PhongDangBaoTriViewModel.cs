using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.ViewModels
{
    public class PhongDangBaoTriViewModel : PhongViewModel
    {
        public DateTime? ngayGioBaoTri { get; set; }
        public DateTime? ngayGioBaoTriKetThuc { get; set; }
        public string moTa { get; set; }
    }
}
