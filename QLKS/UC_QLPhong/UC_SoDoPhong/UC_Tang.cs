using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.UC_SoDoPhong
{
    public partial class UC_Tang : UserControl
    {
        public string SoTang { get; set; }
        PhongBUS _phongBUS;
        
        public UC_Tang()
        {
            InitializeComponent();
            _phongBUS = new PhongBUS();
            //AllRooms(SoTang);
        }
        public void ThemSoTang()
        {
            lblTang.Text = SoTang;
        }
        private void ThemPhongTrong(string MaPhong) 
        {
            UC_PhongTrong uc = new UC_PhongTrong(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);

        }
        private void ThemDangDonDep(string MaPhong)
        {

            UC_PhongDonDep uc = new UC_PhongDonDep(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemDangSuaChua(string MaPhong)
        {
            UC_PhongSuaChua uc = new UC_PhongSuaChua(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongDatTruoc(string MaPhong)
        {

            UC_PhongDatTruoc uc = new UC_PhongDatTruoc(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongDangThue(string MaPhong)
        {

            UC_PhongDangThue uc = new UC_PhongDangThue(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongHetHan(string MaPhong)
        {

            UC_PhongHetHan uc = new UC_PhongHetHan(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }

        private void PanelLoaiPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Tang_Load(object sender, EventArgs e)
        {
            var listPhongInTang = _phongBUS.GetAllPhongByTang(lblTang.Text);
            foreach(var phong in listPhongInTang)
            {
                switch (phong.tinhTrang)
                {
                    case "Trống":
                        ThemPhongTrong(phong.maPhong);
                        break;
                    case "Đang sửa chữa":
                        ThemDangSuaChua(phong.maPhong);
                        break;
                    case "Đang dọn dẹp":
                        ThemDangDonDep(phong.maPhong);
                        break;
                    case "Đã đặt trước":
                        ThemPhongDatTruoc(phong.maPhong);
                        break;
                    case "Đang Thuê":
                        ThemPhongDangThue(phong.maPhong);
                        break;
                    case "Hết Hạn":
                        ThemPhongHetHan(phong.maPhong);
                        break;
                }
            }
        }
    }
}
