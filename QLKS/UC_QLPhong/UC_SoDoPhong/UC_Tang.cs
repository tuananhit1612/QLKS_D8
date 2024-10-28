using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongBUS;
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

namespace QLKS.UC_QLKhachSan.UC_SoDoPhong
{
    public partial class UC_Tang : UserControl
    {
        public string trangthai { get; set; }
        public string loaiPhong { get; set; }
        public string soTang { get; set; }
        PhongBUS _phongBUS;
        
        public UC_Tang(string soTang,string loaiPhong)
        {
            InitializeComponent();
            _phongBUS = new PhongBUS();
            this.soTang = soTang;
            this.loaiPhong= loaiPhong;
            lblTang.Text = soTang;
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
        public void XuLyPhongDangThue()
        {
            
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(soTang, loaiPhong);

            foreach (var phong in data)
            {
               //MessageBox.Show(phong.tinhTrang);

                if (phong.tinhTrang == "Đang Thuê")
                {
                    ThemPhongDangThue(phong.maPhong);
                }
            }

        }
        public void XuLyPhongHetHan(string SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(soTang, loaiPhong);

            foreach (var phong in data)
            {
                if (phong.tinhTrang == "Hết Hạn")
                {
                    ThemPhongHetHan(phong.maPhong);
                }
            }

        }

        public void XuLyPhongDonDep(string SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(soTang, loaiPhong);

            foreach (var phong in data)
            {
                if (phong.tinhTrang == "Đang dọn dẹp")
                {
                    ThemDangDonDep(phong.maPhong);
                }
            }

        }
        public void XuLyPhongTrong(string SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(SoTang, loaiPhong);
            
            foreach (var phong in data)
            {
                if (phong.tinhTrang == "Trống")
                {
                    ThemPhongTrong(phong.maPhong);
                }
            }

        }
        public void XuLyPhongSuaChua(string SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(soTang, loaiPhong);

            foreach (var phong in data)
            {
                if (phong.tinhTrang == "Đang bảo trì")
                {
                    ThemDangSuaChua(phong.maPhong);
                }
            }

        }
        public void XuLyPhongDatTruoc(string SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = _phongBUS.GetAllPhongByTangLoaiPhong(soTang, loaiPhong);

            foreach (var phong in data)
            {
                if (phong.tinhTrang == "Đã đặt trước")
                {
                    ThemPhongDatTruoc(phong.maPhong);
                }
            }

        }
        public void XuLyTatCaPhongByTang(string soTang)
        {
            var listPhongInTang = _phongBUS.GetAllPhongByTangLoaiPhong(soTang,loaiPhong);
            foreach (var phong in listPhongInTang)
            {
                switch (phong.tinhTrang)
                {
                    case "Trống":
                        ThemPhongTrong(phong.maPhong);
                        break;
                    case "Đang bảo trì":
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
        private void UC_Tang_Load(object sender, EventArgs e)
        {
           
        }
    }
}
