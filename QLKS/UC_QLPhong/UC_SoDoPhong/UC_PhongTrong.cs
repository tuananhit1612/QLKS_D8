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
    public partial class UC_PhongTrong : UserControl
    {
        public int maLoaiPhong { get; set; }
        public int maPhong { get; set; }
        public string trangThai { get; set; }
        public decimal giaPhong { get; set; }
        public UC_PhongTrong(int maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            AddThongTin();
        }
        void AddThongTin()
        {
            List<PhongTrong> data = PhongDAO.Instance.GetPhongTrong(maPhong);
            if (data.Count > 0)
            {
                lblMaPhong.Text = data[0].MaPhong.ToString();
                lblLoaiPhong.Text = data[0].TenLoaiPhong.ToString();
                //lblSoNguoi.Text = data[0].SoNguoi.ToString();
                lblTinhTrang.Text = data[0].TinhTrang.ToString();
                giaPhong = data[0].GiaPhong;
                maLoaiPhong = data[0].MaLoaiPhong;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho phòng này.");
            }
        }

        private void lblSoNguoi_Click(object sender, EventArgs e)
        {

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
            trangThai = lblTinhTrang.Text;
            fBangDieuKhien f = new fBangDieuKhien(maPhong, lblLoaiPhong.Text, trangThai, giaPhong, maLoaiPhong);
            f.ShowDialog();
        }
    }
}
