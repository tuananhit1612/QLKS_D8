using QLKS.FormQuanLy;
using QLKS.UC_Main;
using QLKS.UC_QLKhachSan.DanhSachLoaiPhong;
using QLKS.UserControls;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        
        private void AddUserConTrol(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ClearButtonImage()
        {
            this.BtnDashBoard.Image = global::QLKS.Properties.Resources.menu__1_;
            this.BtnQLKhachSan.Image = global::QLKS.Properties.Resources.hotel__2_1;
            this.BtnQLPhong.Image = global::QLKS.Properties.Resources.rooms1;
            this.BtnDichVuPhong.Image = global::QLKS.Properties.Resources.room_service__1_;
            this.BtnBaoCao.Image = global::QLKS.Properties.Resources.document;
            this.BtnNhanVien.Image = global::QLKS.Properties.Resources.consultant;

        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            fCustomDialog customDialog = new fCustomDialog();
            DialogResult result = customDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            ClearButtonImage();
            this.BtnBaoCao.Image = global::QLKS.Properties.Resources.document__1_;
            UC_BaoCao ucbc = new UC_BaoCao();
            AddUserConTrol(ucbc);
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            ClearButtonImage();
            this.BtnNhanVien.Image = global::QLKS.Properties.Resources.consultant__1_;
            UC_NhanVien ucnv = new UC_NhanVien();
            AddUserConTrol(ucnv);
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            ClearButtonImage();
            this.BtnDashBoard.Image = global::QLKS.Properties.Resources.menu__2_;
            //this.BtnDoanhThu.ImageActive = 
            UC_Dashboard uc = new UC_Dashboard();
            AddUserConTrol(uc);
        }

        private void BtnQLPhong_Click(object sender, EventArgs e)
        {
            ClearButtonImage();

            UC_QuanLyPhong qlks = new UC_QuanLyPhong();
            AddUserConTrol(qlks);
            BtnQLPhong.Image = global::QLKS.Properties.Resources.rooms__1_2;
            

        }

        private void BtnQLKhachSan_Click(object sender, EventArgs e)
        {
            ClearButtonImage();
            BtnQLKhachSan.Image = global::QLKS.Properties.Resources.hotel__3_;
            UC_QuanKhachSan qlp = new UC_QuanKhachSan();
            AddUserConTrol(qlp);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BtnDashBoard.PerformClick();
        }

        private void BtnDichVuPhong_Click(object sender, EventArgs e)
        {
            ClearButtonImage();
            BtnDichVuPhong.Image = global::QLKS.Properties.Resources.serverces;
            main uc = new main();
            AddUserConTrol(uc);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            AddUserConTrol(uc);
        }

        private void PanelMain_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
