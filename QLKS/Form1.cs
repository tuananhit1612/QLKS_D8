using QLKS.UC_QLKhachSan.DanhSachLoaiPhong;
using QLKS.UC_QLKhachSan.DanhSachPhong;

using QLKS_BUS.BUSs.LoaiPhongBUS;
using QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_DanhSachPhong uc = new UC_DanhSachPhong();
            panel1.Controls.Add(uc);
        }
    }
}
