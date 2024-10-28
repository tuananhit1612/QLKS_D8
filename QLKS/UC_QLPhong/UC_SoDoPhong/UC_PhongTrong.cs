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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.UC_SoDoPhong
{
    public partial class UC_PhongTrong : UserControl
    {
        PhongBUS _phongBUS;
        public string maPhong { get; set; }
        public string loaiPhong { get; set; }
        public UC_PhongTrong(string MaPhong)
        {
            this.maPhong = MaPhong;
            InitializeComponent();
            _phongBUS = new PhongBUS();
            ThemThongTinMaPhong();
        }
        public UC_PhongTrong(string MaPhong,string loaiPhong)
        {
            this.maPhong = MaPhong;
            this.loaiPhong = loaiPhong;
            InitializeComponent();
            _phongBUS = new PhongBUS();
            ThemThongTinMaPhongLoaiPhong();
        }
        private void lblSoNguoi_Click(object sender, EventArgs e)
        {

        }
        private void ThemThongTinMaPhongLoaiPhong()
        {
            var phong = _phongBUS.GetPhongTrongByMaPhongLoaiPhong(maPhong,loaiPhong);
            lblLoaiPhong.Text = phong.tenLoaiPhong;
            lblMaPhong.Text = phong.maPhong;
            lblTinhTrang.Text = phong.tinhTrang;
        }
        private void ThemThongTinMaPhong()
        {
            var phong = _phongBUS.GetPhongTrongByMaPhong(maPhong);
            lblLoaiPhong.Text = phong.tenLoaiPhong;
            lblMaPhong.Text = phong.maPhong;
            lblTinhTrang.Text = phong.tinhTrang;
        }
        private void UC_PhongTrong_Click(object sender, EventArgs e)
        {
           
        }

        private void UC_PhongTrong_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            fBangDieuKhien f = new fBangDieuKhien(maPhong);
            f.ShowDialog();
        }
    }
}
