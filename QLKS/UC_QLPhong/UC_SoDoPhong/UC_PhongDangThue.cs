using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormQuanLy;
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
        public string maPhong { get; set; }
        public int maLoaiPhong { get; set; }
        public string cCCD { get; set; }
        public string tenKhachHang { get; set; }
        public string tenLoaiPhong { get; set; }
        public decimal giaPhong { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        private decimal traTruoc { get; set; }
        private string ghiChu { get; set; }
        public UC_PhongDangThue(string MaPhong)
        {
            InitializeComponent();
            maPhong = MaPhong;
            ThemThongTin();
        }
        void ThemThongTin()
        {
            //List<PhongDangThue> data = PhongDAO.Instance.GetPhongDangThue(maPhong);
            //if (data.Count > 0)
            //{
            //    lblMaPhong.Text = data[0].MaPhong.ToString();

            //    lblNgayBatDau.Text = data[0].NgayBatDau.ToString("dd/MM/yyyy");
            //    lblNgayKetThuc.Text = data[0].NgayKetThuc.ToString("dd/MM/yyyy");
            //    lblTenKhachHang.Text = data[0].TenKhachHang.ToString();
            //    lblTinhTrang.Text = data[0].TinhTrang.ToString();
                
            //    lblTenLoaiPhong.Text = data[0].TenLoaiPhong.ToString();
            //    maLoaiPhong = data[0].MaLoaiPhong;
            //    cCCD = data[0].CCCD;
            //    traTruoc = data[0].TraTruoc;
            //    ghiChu = data[0].GhiChu;

            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cho phòng này.");
            //}
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
