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
    public partial class UC_PhongHetHan : UserControl
    {
        public int maPhong { get; set; }
        public string cCCD { get; set; }
        public string tenKhachHang { get; set; }
        public string tenLoaiPhong { get; set; }
        public decimal giaPhong { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        private decimal traTruoc { get; set; }
        public UC_PhongHetHan(int MaPhong)
        {
            InitializeComponent();
            maPhong = MaPhong;
            ThemThongTin();
            
        }
        void ThemThongTin()
        {
            List<PhongHetHan> data = PhongDAO.Instance.GetPhongHetHan(maPhong);
            if (data.Count > 0)
            {
                lblMaPhong.Text = data[0].MaPhong.ToString();
                lblNgayBatDau.Text = data[0].NgayBatDau.ToString("dd/MM/yyyy");
                lblNgayKetThuc.Text = data[0].NgayKetThuc.ToString("dd/MM/yyyy");
                lblTenKhachHang.Text = data[0].TenKhachHang.ToString();
                lblTinhTrang.Text = data[0].TinhTrang.ToString();
                lblTenLoaiPhong.Text = data[0].TenLoaiPhong.ToString();
                cCCD = data[0].CCCD.ToString();
                giaPhong = data[0].GiaPhong;
                traTruoc = data[0].TraTruoc;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho phòng này.");
            }
        }

        private void UC_PhongHetHan_Load(object sender, EventArgs e)
        {

        }

        private void UC_PhongHetHan_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            fTraPhong f = new fTraPhong(maPhong, cCCD, lblTenKhachHang.Text, lblTenLoaiPhong.Text, giaPhong, lblNgayBatDau.Text, lblNgayKetThuc.Text,traTruoc);
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
