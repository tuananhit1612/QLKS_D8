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
    public partial class UC_PhongDonDep : UserControl
    {
        public string MaPhong { get; set; }
        public UC_PhongDonDep(string maPhong)
        {
            InitializeComponent();
            MaPhong = maPhong;
            AddThongTin();
        }
        void AddThongTin()
        {
            //List<PhongDonDep> data = PhongDAO.Instance.GetPhongDonDep(MaPhong);
            //if (data.Count > 0)
            //{
            //    lblMaPhong.Text = data[0].MaPhong.ToString();
            //    lblTenLoaiPhong.Text = data[0].TenLoaiPhong.ToString();
            //    lblTinhTrang.Text = data[0].TinhTrang.ToString();
            //    //lblGhiChu.Text = data[0].GhiChu.ToString();
            //    //lblNgayDonDep.Text = data[0].NgayDonDep.ToString();
            //    lblThoiGiamBatDau.Text = data[0].ThoiGianBatDau.ToString();
            //    lblThoiGianKetThuc.Text = data[0].ThoiGianKetThuc.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu cho phòng này.");
            //}
        }
    }
}
