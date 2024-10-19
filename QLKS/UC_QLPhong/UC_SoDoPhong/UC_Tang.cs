using QLKS.DAO;
using QLKS.DTO;

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
        private string loaiPhong { get; set; }
        public UC_Tang()
        {
            InitializeComponent();
            this.loaiPhong = loaiPhong;
            //AllRooms(SoTang);
        }
        public void ThemSoTang()
        {
            lblTang.Text = SoTang;
        }
        private void ThemPhongTrong(int MaPhong) 
        {
            UC_PhongTrong uc = new UC_PhongTrong(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);

        }
        private void ThemDangDonDep(int MaPhong)
        {

            UC_PhongDonDep uc = new UC_PhongDonDep(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemDangSuaChua(int MaPhong)
        {
            UC_PhongSuaChua uc = new UC_PhongSuaChua(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongDatTruoc(int MaPhong)
        {

            UC_PhongDatTruoc uc = new UC_PhongDatTruoc(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongDangThue(int MaPhong)
        {

            UC_PhongDangThue uc = new UC_PhongDangThue(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        private void ThemPhongHetHan(int MaPhong)
        {

            UC_PhongHetHan uc = new UC_PhongHetHan(MaPhong);
            flowLayoutPanel1.Controls.Add(uc);
        }
        public void AllRooms(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            //string CurTang = lblTang.Text;
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(),loaiPhong);
            foreach (Phong phong in data)
            {
                switch (phong.TinhTang) 
                {
                    case "Trống":
                        ThemPhongTrong((int)phong.MaPhong);
                        break;
                    case "Đang sửa chữa":
                        ThemDangSuaChua((int)phong.MaPhong);
                        break;
                    case "Đang dọn dẹp":
                        ThemDangDonDep((int)phong.MaPhong);
                        break;
                    case "Đã đặt trước":
                        ThemPhongDatTruoc((int)phong.MaPhong);
                        break;
                    case "Đang Thuê":
                        ThemPhongDangThue((int)phong.MaPhong);
                        break;
                    case "Hết Hạn":
                        ThemPhongHetHan((int)phong.MaPhong);
                        break;
                }
            }
            
        }
        public void XuLyPhongDangThue(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(),loaiPhong);
            foreach (Phong phong in data)
            {
                if (phong.TinhTang == "Đang Thuê")
                {
                    ThemPhongDangThue((int)phong.MaPhong);
                }
            }

        }
        public void XuLyPhongHetHan(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(), loaiPhong);
            foreach (Phong phong in data)
            {
                if (phong.TinhTang == "Hết Hạn")
                {
                    ThemPhongHetHan((int)phong.MaPhong);
                }
            }

        }

        public void XuLyPhongDonDep(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(), loaiPhong);
            foreach (Phong phong in data)
            {
                if (phong.TinhTang == "Đang dọn dẹp")
                {
                    ThemDangDonDep((int)phong.MaPhong);
                }
            }

        }
        public void XuLyPhongTrong(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(), loaiPhong);
            foreach (Phong phong in data)
            {
                if(phong.TinhTang == "Trống")
                {
                    ThemPhongTrong((int)phong.MaPhong);
                }
            }

        }
        public void XuLyPhongSuaChua(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(), loaiPhong);
            foreach (Phong phong in data)
            {
                if (phong.TinhTang == "Đang sửa chữa")
                {
                    ThemDangSuaChua((int)phong.MaPhong);
                }
            }

        }
        public void XuLyPhongDatTruoc(int SoTang)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Phong> data = PhongDAO.Instance.ListPhong(SoTang.ToString(), loaiPhong);
            foreach (Phong phong in data)
            {
                if (phong.TinhTang == "Đã đặt trước")
                {
                    
                    ThemPhongDatTruoc((int)phong.MaPhong);
                }
            }

        }

        private void PanelLoaiPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Tang_Load(object sender, EventArgs e)
        {

        }
    }
}
