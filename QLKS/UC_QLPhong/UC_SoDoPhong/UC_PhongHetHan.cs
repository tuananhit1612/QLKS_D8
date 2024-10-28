using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormQuanLy;
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
    public partial class UC_PhongHetHan : UserControl
    {
        PhongBUS phongBUS;
        public string maPhong { get; set; }
        public UC_PhongHetHan(string MaPhong)
        {
            InitializeComponent();
            this.maPhong = MaPhong;
            phongBUS = new PhongBUS();
            ThemThongTin();


        }
        void ThemThongTin()
        {
            var data = phongBUS.GetPhongHetHanByMaPhong(maPhong);
            lblMaPhong.Text = data.maPhong;
            lblNgayBatDau.Text = data.ngayBatDau?.ToString("dd/MM/yyyy") ?? "01/01/2000";
            lblTenKhachHang.Text = data.tenKH;
            lblTinhTrang.Text = data.tinhTrang.ToString();
            lblTenLoaiPhong.Text = data.tenLoaiPhong.ToString();
            lblLoai.Text = data.loai;
        }

        private void UC_PhongHetHan_Load(object sender, EventArgs e)
        {

        }

        private void UC_PhongHetHan_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //fTraPhong f = new fTraPhong(maPhong, cCCD, lblTenKhachHang.Text, lblTenLoaiPhong.Text, giaPhong, lblNgayBatDau.Text, lblNgayKetThuc.Text,traTruoc);
            //f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
