using QLKS.DAO;
using QLKS.DTO;
using QLKS.UC_QLKhachSan.UC_SoDoPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fTraPhong : Form
    {
        private int maPhong { get; set; }
        private string cCCD { get; set; }
        private string tenKhachHang { get; set; }
        private string tenLoaiPhong { get; set; }
        private decimal giaPhong { get; set; }
        private string ngayBatDau { get; set; }
        private string ngayKetThuc { get; set; }
        private string ngayLap { get; set; }
        private string hinhThucTra { get; set; }
        private string maHoaDon { get; set; }
        private decimal traTruoc { get; set; }

        public decimal tongTienPhong,tongTienDichVu, tienPhuThu, tienGiamTru, tienTraTruoc,tongTien;
        public fTraPhong(int maPhong,string cCCD,string tenKhachHang,string tenLoaiPhong, decimal giaPhong,string ngayBatDau,string ngayKetThuc,decimal traTruoc)
        {
            this.maPhong = maPhong;
            this.cCCD = cCCD;
            this.tenKhachHang = tenKhachHang;
            this.tenLoaiPhong = tenLoaiPhong;
            this.giaPhong = giaPhong;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.traTruoc = traTruoc;
            maHoaDon = DataProvider.Instance.ExecuteScalar("select ISNULL(Max(MaHoaDon),0)+1 from HoaDon").ToString();
            ngayLap = DateTime.Now.ToString("dd/MM/yyyy");
            InitializeComponent();
            txtTraTruoc.Text = traTruoc.ToString();
            LoadDichVu();
            LoadData();

            hinhThucTra = cmbhttt.Text;
            if (guna2DataGridView1.Rows.Count > 0)
            {
                guna2DataGridView1.Visible = true;
            }
            else
            {
                label8.Visible = true;
            }

        }
        private void TinhTienPhong()
        {
            tienPhuThu = Convert.ToDecimal(txtPhuThu.Text);
            tienGiamTru = Convert.ToDecimal(txtGiamTru.Text);
            tienTraTruoc = Convert.ToDecimal(txtTraTruoc.Text);
            tongTien = tongTienPhong + tongTienDichVu + tienPhuThu - tienGiamTru - tienTraTruoc;
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void LoadData()
        {
            // Khach Hàng
            lblMaPhong.Text = maPhong.ToString();
            lblCCCD.Text = cCCD.ToString();
            lblGiaPhong.Text = giaPhong.ToString("N0");
            lblKhachHang.Text = tenKhachHang;
            lblLoaiPhong.Text = tenLoaiPhong.ToString();
            lblNgayTraPhongDuKien.Text= ngayKetThuc.ToString();
            lblNgayNhanPhong.Text = ngayBatDau.ToString();
            lblThoiGianHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblMaHoaDon.Text = maHoaDon;
            // Tiền Phòng
            // Chuyển đổi nội dung của Label từ chuỗi sang DateTime
            DateTime thoiGianHienTai = DateTime.ParseExact(lblThoiGianHienTai.Text, "dd/MM/yyyy", null);
            DateTime ngayNhanPhong = DateTime.ParseExact(lblNgayNhanPhong.Text, "dd/MM/yyyy", null);
            DateTime ngayTraPhong = DateTime.ParseExact(lblNgayTraPhongDuKien.Text, "dd/MM/yyyy", null);
            if(ngayTraPhong == thoiGianHienTai)
            {
                label10.Text = "Trả Phòng Đúng Hạn";
            }
            else if(ngayTraPhong > thoiGianHienTai)
            {
                label10.Text = "Trả Phòng Sớm";
            }
            else
            {
                label10.Text = "Trả Phòng Quá Hạn";
            }
            // Tính tổng số ngày đã ở
            TimeSpan soNgayO = ngayTraPhong - ngayNhanPhong;
            int songay = soNgayO.Days;
            lblNgayBatDau.Text = ngayBatDau.ToString();
            lblNgayKetThuc.Text = ngayKetThuc.ToString();
            lblTongNgay.Text = songay.ToString() + " Ngày";
            tongTienPhong = songay * giaPhong;
            lblTongTienPhong.Text = tongTienPhong.ToString("N0") + " VNĐ";
            //////////////
            TinhTienPhong();
            



        }
        private void LoadDichVu()
        {
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("select  dv.TenDichVu,ctdv.SoLuong,dv.Gia,ctdv.NgaySuDung,Gia*SoLuong as [Thành Tiền] from DichVu dv ,ChiTietDichVu ctdv where dv.MaDichVu = ctdv.MaDichVu and MaPhong = " + maPhong);
            foreach(DataGridViewRow  row in guna2DataGridView1.Rows )
            {
                if (row.Cells["Thành Tiền"].Value != null)
                {
                    
                    tongTienDichVu += Convert.ToDecimal(row.Cells["Thành Tiền"].Value);
                }
            }
            lblTienDichVu.Text = tongTienDichVu.ToString("N0") + " VNĐ";

        }
        private void TraPhong_Load(object sender, EventArgs e)
        {
            cmbhttt.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblas_Click(object sender, EventArgs e)
        {

        }

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamTru_TextChanged(object sender, EventArgs e)
        {
            TinhTienPhong();
        }

        private void btnTraPhong_Click_1(object sender, EventArgs e)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("delete PhongHetHan where MaPhong = " + maPhong + "");
            if (check == 0)
            {
                MessageBox.Show("Quá trình trả phòng thất bại , vui lòng kiểm tra lại thông tin");
                return;
            }
            check = DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatTinhTrangPhong @maPhong , @tinhTrang", new object[] { maPhong, "Trống" });
            if (check == 0)
            {
                MessageBox.Show("Quá trình trả phòng thất bại , vui lòng kiểm tra lại thông tin");
                return;
            }
            try
            {
                DateTime NgayLap = DateTime.ParseExact(ngayLap, "dd/MM/yyyy", null);
                DateTime NgayBatDau = DateTime.ParseExact(ngayBatDau, "dd/MM/yyyy", null);
                DateTime NgayKetThuc = DateTime.ParseExact(ngayKetThuc, "dd/MM/yyyy", null);
                check = DataProvider.Instance.ExecuteNonQuery("EXEC AddHoaDon @MaPhong , @CCCD , @NgayLap , @NgayBatDau , @NgayKetThuc , @TraTruoc , @GiamTru , @PhuThu , @HinhThucTra , @TongTienPhong , @TongTienDichVu , @ThanhTien", new object[] { maPhong, cCCD, NgayLap, NgayBatDau, NgayKetThuc, tienTraTruoc, tienGiamTru, tienPhuThu, hinhThucTra, tongTienPhong, tongTienDichVu, tongTien });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Trả Phòng Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UC_SoDo uc = new UC_SoDo();
            uc.Refresh();
            this.Close();
        }

        private void txtTraTruoc_TextChanged(object sender, EventArgs e)
        {
            TinhTienPhong();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTraTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            TinhTienPhong();
        }
    }
}
