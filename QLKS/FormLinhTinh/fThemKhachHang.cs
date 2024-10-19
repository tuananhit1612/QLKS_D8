using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.FormLinhTinh
{
    public partial class fThemKhachHang : Form
    {
        public string CCCD;
        public fThemKhachHang(string cCCD)
        {
            InitializeComponent();
            this.CCCD= cCCD;
            txtCCCD.Text = cCCD;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenKH = txtTenKhachHang.Text;
            DateTime NgaySinh;
            string DiaChi = txtDiaChi.Text;
            string SDT = txtSDT.Text;
            string email = txtEmail.Text;
            try
            {
                
                NgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ngày sinh không đúng định dạng dd/MM/yyyy");
                return;
            }
            NgaySinh = NgaySinh.Date;
            int ans = DataProvider.Instance.ExecuteNonQuery("EXEC AddKhachHang @TenKhachHang , @CCCD , @NgaySinh , @DiaChi , @SoDienThoai , @Email",new object[] {TenKH,CCCD,NgaySinh,DiaChi,SDT,email});
            if(ans > 0)
            {
                MessageBox.Show("Thêm Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm Khách Hàng Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtNgaySinh.Clear();
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            txtSDT.Clear();
        }
    }
}
