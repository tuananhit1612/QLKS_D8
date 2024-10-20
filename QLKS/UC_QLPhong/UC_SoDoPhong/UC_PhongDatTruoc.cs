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
    public partial class UC_PhongDatTruoc : UserControl
    {
        public string MaPhong { get; set; }
        public UC_PhongDatTruoc(string maPhong)
        {
            InitializeComponent();
            MaPhong = maPhong;
            ThemThongTin();
        }
        void ThemThongTin()
        {
            //List<PhongDatTruoc> data = PhongDAO.Instance.GetPhongDatTruoc(MaPhong);
            //if (data.Count > 0)
            //{
            //    lblMaPhong.Text = data[0].MaPhong.ToString();
            //    lblNgayNhanPhong.Text = data[0].NgayDen.ToString();
            //    lblTenKhachHang.Text = data[0].TenKhachHang.ToString();
            //    lblTinhTrang.Text = data[0].TinhTrang.ToString();
            //    lblTenLoaiPhong.Text = data[0].TenLoaiPhong.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cho phòng này. "+MaPhong+"");
            //}
        }

        private void lblTenLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
