using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UpdateTrangThaiPhong
{
    public partial class UC_NhanPhong : UserControl
    {
        private int maPhong;
        public UC_NhanPhong(int maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            lblMaPhong.Text = maPhong.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
