using QLKS_BUS.BUSs.TangBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.DanhSachTang
{
    public partial class UC_DanhSachTang : UserControl
    {
        TangBUS _tangBus;
        public UC_DanhSachTang()
        {
            InitializeComponent();
            _tangBus = new TangBUS();
        }

        private void UC_DanhSachTang_Load(object sender, EventArgs e)
        {
            dgvTang.DataSource = _tangBus.GetALLTang();
        }
    }
}
