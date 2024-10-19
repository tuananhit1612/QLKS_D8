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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
