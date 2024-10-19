using QLKS.DAO;
using QLKS.DTO;
using QLKS.FormLinhTinh;
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
    public partial class fNhanPhong : Form
    {
        DataTable dataTable;
        private int maPhong;
        private string tenLoaiPhong;
        private decimal giaPhong;
        private int maLoaiPhong;
        private string cccd;
        public fNhanPhong(int maPhong,string tenLoaiPhong , decimal giaPhong , int maLoaiPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.giaPhong = giaPhong;
            this.maLoaiPhong = maLoaiPhong;
        }


        private void NhanPhong_Load(object sender, EventArgs e)
        {
            lblMaPhong.Text = maPhong.ToString() ;
            txtLoaiPhong.Text = tenLoaiPhong.ToString() ;
            txtGiaPhong.Text = giaPhong.ToString() ;
            txtNgayHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtGioHienTai.Text = DateTime.Now.ToString("HH:mm");

            dataTable = new DataTable();
            dataTable.Columns.Add("CCCD", typeof(string));
            dataTable.Columns.Add("TenKhachHang", typeof(string));
            dataTable.Columns.Add("NgaySinh", typeof(DateTime));
            dataTable.Columns.Add("DiaChi", typeof(string));
            dataTable.Columns.Add("SoDienThoai", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            guna2DataGridView1.DataSource = dataTable;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanPhong_Shown(object sender, EventArgs e)
        {
            
        }

        private void txtGiaPhong_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCCCD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtNgaySinh.Clear();
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            txtSDT.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            cccd = txtCCCD.Text;
            string TenKH = txtTenKhachHang.Text;
            DateTime NgaySinh;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            string email = txtEmail.Text;
            NgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            NgaySinh = NgaySinh.Date;
            dataTable.Rows.Add(cccd, TenKH, NgaySinh, DiaChi, SDT, email);
            label4.Text = dataTable.Rows.Count.ToString();
            btnNhanPhong.Enabled = true;
            ClearAll();
            
            
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<KhachHang> data = KhachHangDAO.Instance.CheckKhachHang(txtCCCD.Text);
            if (data.Count > 0)
            {
                btnThem.Enabled = true;
                txtDiaChi.Text = data[0].DiaChi;
                txtEmail.Text = data[0].Email;
                txtNgaySinh.Text = data[0].NgaySinh.Date.ToString("dd/MM/yyyy");
                txtSDT.Text = data[0].SoDienThoai;
                txtTenKhachHang.Text = data[0].TenKhachHang;

            }
            else
            {
                DialogResult result = MessageBox.Show("Không thể tìm thấy CCCD trong dữ liệu. Bạn có muốn thêm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    fThemKhachHang f = new fThemKhachHang(txtCCCD.Text);
                    DialogResult rs = f.ShowDialog();
                    if (rs == DialogResult.Yes)
                    {
                        btnTimKiem.PerformClick();
                    }
                }
            }
        }

        private void txtCCCD_TextChanged_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["xoakh"].Index && e.RowIndex >= 0)
            {
                // Xóa hàng được chọn
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            label4.Text = dataTable.Rows.Count.ToString();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (txtNgayTraPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Ngày Trả Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayTraPhong.Focus();
                return;
            }
            if (txtGioTraPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Giờ Trả Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioTraPhong.Focus();
                return;
            }
            if (dataTable.Rows.Count > 0)
            {
                
                int tratuoc = int.Parse(txtTraTruoc.Text);
                string ghichu = txtGhiChu.Text;
                DateTime NgayBatDau, NgayKetThuc;
                try
                {

                    NgayBatDau = DateTime.ParseExact(txtNgayHienTai.Text, "dd/MM/yyyy", null);
                    NgayKetThuc = DateTime.ParseExact(txtNgayTraPhong.Text, "dd/MM/yyyy", null);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ngày không đúng định dạng dd/MM/yyyy");
                    return;
                }
                NgayBatDau = NgayBatDau.Date;
                NgayKetThuc = NgayKetThuc.Date;
                int check_CapNhatPhong = DataProvider.Instance.ExecuteNonQuery("EXEC CapNhatTinhTrangPhong @maPhong , @tinhTrang", new object[] { maPhong, "Đang Thuê" });
                if (check_CapNhatPhong > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int check_NhanPhong = DataProvider.Instance.ExecuteNonQuery("EXEC AddPhongDangThue @MaPhong , @MaLoaiPhong , @CCCD , @TraTruoc , @NgayBatDau , @NgayKetThuc , @GhiChu", new object[] { maPhong, maLoaiPhong, row["CCCD"], tratuoc, NgayBatDau, NgayKetThuc, ghichu });
                        if (check_NhanPhong > 0)
                        {
                            MessageBox.Show("Nhận Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nhận Phòng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Nhận Phòng thất bại , vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
