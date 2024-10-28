using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongBaoTriBUS;
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

    public partial class UC_PhongSuaChua : UserControl
    {
        PhongBaoTriBUS phongBaoTriBUS;
        private string maPhong { get; set; }
        public UC_PhongSuaChua(string MaPhong)
        {
            InitializeComponent();
            this.maPhong = MaPhong;
            phongBaoTriBUS = new PhongBaoTriBUS();
            AddThongTin();
        }
        void AddThongTin()
        {
            var phong = phongBaoTriBUS.GetPhongBaoTriByMaPhong(maPhong);
            lblTenLoaiPhong.Text = phong.tenLoaiPhong;
            lblMaPhong.Text = phong.maPhong;
            lblTinhTrang.Text = phong.tinhTrang;
            lblThoiGiamBatDau.Text = phong.ngayGioBaoTri?.ToString("dd/MM/yy") ?? "N/A";
            lblThoiGianKetThuc.Text = phong.ngayGioBaoTriKetThuc?.ToString("dd/MM/yy") ?? "N/A";


        }
    }
}
