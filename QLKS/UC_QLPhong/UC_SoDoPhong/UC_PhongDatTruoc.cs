using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongDangThueBUS;
using QLKS_BUS.BUSs.PhongDatTruocBUS;
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
    public partial class UC_PhongDatTruoc : UserControl
    {
        PhongDatTruocBUS phongDatTruocBUS;
        public string MaPhong { get; set; }
        public UC_PhongDatTruoc(string maPhong)
        {
            InitializeComponent();
            this.MaPhong = maPhong;
            phongDatTruocBUS = new PhongDatTruocBUS();
            ThemThongTin();
        }
        void ThemThongTin()
        {
            var data = phongDatTruocBUS.getPhongDatTruocByMaPhong(MaPhong);

            lblMaPhong.Text = data.maPhong.ToString();
            lblNgayNhanPhong.Text = data.ngayBatDau.Value.ToString();
            lblTenKhachHang.Text = data.tenKH.ToString();
            lblTinhTrang.Text = data.tinhTrang.ToString();

            lblTenLoaiPhong.Text = data.tenLoaiPhong.ToString();
        }

        private void lblTenLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
