using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormQuanLy;
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
        public string maPhong { get; set; }
        public UC_PhongTrong(string MaPhong)
        {
            this.maPhong = MaPhong;
            InitializeComponent();
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
            //trangThai = lblTinhTrang.Text;
            //fBangDieuKhien f = new fBangDieuKhien(maPhong, lblLoaiPhong.Text, trangThai, giaPhong, maLoaiPhong);
            //f.ShowDialog();
        }
    }
}
