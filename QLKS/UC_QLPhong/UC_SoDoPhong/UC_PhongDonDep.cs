using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongBUS;
using QLKS_BUS.BUSs.PhongDonDepBUS;
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
    public partial class UC_PhongDonDep : UserControl
    {
        PhongDonDepBUS _phongDonDepBUS;
        private string maPhong { get; set; }
        public UC_PhongDonDep(string MaPhong)
        {
            InitializeComponent();
            this.maPhong = MaPhong;
            _phongDonDepBUS = new PhongDonDepBUS();
            AddThongTin();
        }
        void AddThongTin()
        {
            var phong = _phongDonDepBUS.GetPhongDonDepByMaPhong(maPhong);
            lblTenLoaiPhong.Text = phong.tenLoaiPhong;
            lblMaPhong.Text = phong.maPhong;
            lblTinhTrang.Text = phong.tinhTrang;
            lblThoiGiamBatDau.Text = phong.ngayGioDonDep?.ToString("dd/MM/yy") ?? "01/01/2000";
            lblThoiGianKetThuc.Text = phong.ngayGioDonDep?.ToString("dd/MM/yy") ?? "01/01/2000";
        }
    }
}
