using QLKS.DAO;
using QLKS_BUS.BUSs.KhachHangBUS;
using QLKS_BUS.ViewModels;
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
        KhachHangBUS khachHangBUS;
        public fThemKhachHang(string cCCD)
        {
            InitializeComponent();
            this.CCCD= cCCD;
            txtCCCD.Text = cCCD;
            khachHangBUS = new KhachHangBUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            DateTime NgaySinh;
            string DiaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;
            string Email = txtEmail.Text;
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
            try
            {
                KhachHangViewModel kh = new KhachHangViewModel() { cccd = txtCCCD.Text, tenKH = txtTenKhachHang.Text, ngaySinh = NgaySinh, diaChi = DiaChi, email = Email, SDT = txtSDT.Text };
                khachHangBUS.InsertUpdateKhachHang(kh);
                MessageBox.Show("Thêm khách hàng mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khách hàng mới thất bại +\n" + ex,"Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
