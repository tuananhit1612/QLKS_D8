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
        private int maPhong;
        private string cCCD;
        private string tinhTrang;
        private decimal giaPhong;
        private string tenLoaiPhong;
        private int maLoaiPhong;
        private decimal traTruoc;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string ghiChu;
        public fBangDieuKhien(int maPhong,string tenLoaiPhong, string tinhTrang,decimal giaPhong,int maLoaiPhong)
        {
            this.maPhong = maPhong;
            this.tinhTrang = tinhTrang;
            this.giaPhong = giaPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.maLoaiPhong = maLoaiPhong;
            InitializeComponent();
            
            lblMaPhong.Text = maPhong.ToString();
            lblTrangThai.Text = tinhTrang;
            
        }
        public fBangDieuKhien(int maPhong, string cccd, decimal traTruoc, string ngayBatDau, string ngayKetThuc,int maLoaiPhong,string ghiChu,string tinhTrang)
        {
            this.maPhong = maPhong;
            this.cCCD = cccd;
            this.traTruoc = traTruoc;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maLoaiPhong = maLoaiPhong;
            this.ghiChu = ghiChu;
            InitializeComponent();

            lblMaPhong.Text = maPhong.ToString();
            lblTrangThai.Text = tinhTrang;

        }

        private void BangDieuKhien_Load(object sender, EventArgs e)
        {
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
            fNhanPhong f = new fNhanPhong(maPhong,tenLoaiPhong,giaPhong, maLoaiPhong);
            this.Close();
            f.ShowDialog();

            
        }

        private void btnHetHan_Click(object sender, EventArgs e)
        {
            
            try
            {
               int check = DataProvider.Instance.ExecuteNonQuery("Delete PhongDangThue where MaPhong = " + maPhong);
                check = DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatTinhTrangPhong @tinhTrang , @maPhong", new object[] { maPhong, "Hết Hạn"});
                DateTime NgayBatDau = DateTime.ParseExact(ngayBatDau, "dd/MM/yyyy", null);
                DateTime NgayKetThuc = DateTime.ParseExact(ngayKetThuc, "dd/MM/yyyy", null);
                check = DataProvider.Instance.ExecuteNonQuery("EXEC InsertPhongHetHan @MaPhong , @CCCD , @TraTruoc , @NgayBatDau , @NgayKetThuc , @MaLoaiPhong , @GhiChu", new object[] {maPhong,cCCD,traTruoc, NgayBatDau, NgayKetThuc, maLoaiPhong,ghiChu});
                MessageBox.Show("Cập Nhật Tình Trạng Phòng Thành Công");
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
