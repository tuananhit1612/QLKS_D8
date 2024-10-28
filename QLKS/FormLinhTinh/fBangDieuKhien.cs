using QLKS.DAO;
using QLKS.FormLinhTinh;
using QLKS.UC_QLKhachSan.UC_SoDoPhong;
using QLKS.UpdateTrangThaiPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.FormQuanLy
{
    public partial class fBangDieuKhien : Form
    {
        private string maPhong { get; set; }
        private string tinhTrang { get; set; }
        public fBangDieuKhien(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            //this.tinhTrang = tinhTrang;
        }
        public fBangDieuKhien(string maPhong,string tenLoaiPhong, string tinhTrang,decimal giaPhong,int maLoaiPhong)
        {
            //this.maPhong = maPhong;
            //this.tinhTrang = tinhTrang;
            //this.giaPhong = giaPhong;
            //this.tenLoaiPhong = tenLoaiPhong;
            //this.maLoaiPhong = maLoaiPhong;
            InitializeComponent();
            
            //lblMaPhong.Text = maPhong.ToString();
            //lblTrangThai.Text = tinhTrang;
            
        }
        public fBangDieuKhien(int maPhong, string cccd, decimal traTruoc, string ngayBatDau, string ngayKetThuc,int maLoaiPhong,string ghiChu,string tinhTrang)
        {
            //this.maPhong = maPhong;
            //this.cCCD = cccd;
            //this.traTruoc = traTruoc;
            //this.ngayBatDau = ngayBatDau;
            //this.ngayKetThuc = ngayKetThuc;
            //this.maLoaiPhong = maLoaiPhong;
            //this.ghiChu = ghiChu;
            InitializeComponent();

            //lblMaPhong.Text = maPhong.ToString();
            //lblTrangThai.Text = tinhTrang;

        }

        private void BangDieuKhien_Load(object sender, EventArgs e)
        {
            lblMaPhong.Text = maPhong;
            string status = lblTrangThai.Text;
            switch(status)
            {
                case "Trống":
                    lblTrong.ForeColor = Color.Red;
                    btnTrong.Enabled = false;
                    lblHetHan.ForeColor = Color.Red;
                    btnHetHan.Enabled = false;
                    break;
                case "Đã đặt trước":
                    lblDatTruoc.ForeColor = Color.Red;
                    btnDatTruoc.Enabled = false;
                    lblHetHan.ForeColor = Color.Red;
                    btnHetHan.Enabled = false;
                    lblSuaChua.ForeColor= Color.Red;
                    btnSuaChua.Enabled= false;
                    lblDonDep.ForeColor= Color.Red;
                    btnDonDep.Enabled = false;
                    break;
                case "Đang Thuê":
                    lblDangThue.ForeColor = Color.Red;
                    btnDangThue.Enabled = false;
                    lblDatTruoc.ForeColor= Color.Red;
                    btnDatTruoc.Enabled = false;
                    lblTrong.ForeColor= Color.Red;
                    btnTrong.Enabled = false;
                    break;
                case "Hết Hạn":
                    lblHetHan.ForeColor= Color.Red;
                    btnHetHan.Enabled = false;
                    break;
                case "Đang sửa chữa":
                    lblSuaChua.ForeColor = Color.Red;
                    btnSuaChua.Enabled = false;
                    lblHetHan.ForeColor = Color.Red;
                    btnHetHan.Enabled= false;
                    break;
                case "Đang dọn dẹp":
                    lblDonDep.ForeColor= Color.Red;
                    btnDonDep.Enabled = false;
                    lblHetHan.ForeColor = Color.Red;
                    btnHetHan.Enabled = false;
                    break;
            }
        }

        private void btnDangThue_Click(object sender, EventArgs e)
        {
            fNhanPhong f = new fNhanPhong(maPhong);
            this.Close();
            f.ShowDialog();


        }

        private void btnHetHan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnTrong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {

        }

        private void btnDonDep_Click(object sender, EventArgs e)
        {

        }
    }
}
