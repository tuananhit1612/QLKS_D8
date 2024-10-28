using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormQuanLy;

using QLKS_BUS.BUSs.PhongDangThueBUS;
using QLKS_DAL.DALs.PhieuPhongDangThueDAL;
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
    public partial class UC_PhongDangThue : UserControl
    {
        PhongDangThueBUS phongDangThueBUS;
        public string maPhong { get; set; }

        public UC_PhongDangThue(string MaPhong)
        {
            InitializeComponent();
            this.maPhong = MaPhong;
            phongDangThueBUS = new PhongDangThueBUS();
            ThemThongTin();
        }
        void ThemThongTin()
        {
                var data = phongDangThueBUS.GetPhongDangThueByMaPhong(maPhong);
                lblMaPhong.Text = data.maPhong.ToString();
                lblNgayBatDau.Text = data.ngayBatDau.Value.ToString();
                lblNgayKetThuc.Text = data.ngayDuKienKetThuc.Value.ToString();
                lblTenKhachHang.Text = data.tenKH.ToString();
                lblTinhTrang.Text = data.tinhTrang.ToString();
                lblTenLoaiPhong.Text = data.tenLoaiPhong.ToString();
        }

        private void lblMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            //fBangDieuKhien f = new fBangDieuKhien(maPhong, cCCD, traTruoc, lblNgayBatDau.Text, lblNgayKetThuc.Text,maLoaiPhong, ghiChu, lblTinhTrang.Text);
            //f.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
