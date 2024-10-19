using QLKS.UC_QLKhachSan.DanhSachLoaiPhong;
using QLKS.UC_QLKhachSan.DanhSachPhong;
using QLKS.UC_QLKhachSan.DanhSachTang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_Main
{
    public partial class UC_QuanKhachSan : UserControl
    {
        public UC_QuanKhachSan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void AddUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc);
            uc.BringToFront();
        }
        private void UC_QuanLyPhong_Load(object sender, EventArgs e)
        {
            danhSáchLoạiPhòngToolStripMenuItem.PerformClick();
        }

        private void quảnLýKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DSLoaiPhong uc = new UC_DSLoaiPhong();
            AddUC(uc);
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DanhSachPhong uc = new UC_DanhSachPhong();
            AddUC(uc);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_DanhSachTang uc = new UC_DanhSachTang();
            AddUC(uc);
        }
    }
}
