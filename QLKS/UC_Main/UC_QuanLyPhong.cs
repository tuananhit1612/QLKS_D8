using QLKS.UC_QLKhachSan.UC_SoDoPhong;
using QLKS.UC_QLPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QLKS.UC_Main
{
    public partial class UC_QuanLyPhong : UserControl
    {
        public UC_QuanLyPhong()
        {
            InitializeComponent();
        }
        private void AddUserConTrol(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            bunifuPanel2.Controls.Clear();
            bunifuPanel2.Controls.Add(uc);
            uc.BringToFront();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {

        }
        private void UC_QuanLyPhong_Load(object sender, EventArgs e)
        {
            UC_SoDo soDo = new UC_SoDo();
            AddUserConTrol(soDo);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            UC_QuanLyDonDep qldd = new UC_QuanLyDonDep();
            AddUserConTrol(qldd);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            ContextMenuStrip.Show(bunifuImageButton3, new System.Drawing.Point(0, bunifuImageButton3.Height));
        }

        private void toolStripMenuItem_Booking_Click(object sender, EventArgs e)
        {
            UC_Booking ucbk = new UC_Booking();
            AddUserConTrol(ucbk);
        }

        private void toolStripMenuItem_CheckOut_Click(object sender, EventArgs e)
        {
            UC_CheckOut ucco = new UC_CheckOut();
            AddUserConTrol(ucco);
        }

        private void toolStripMenuItem_Status_Click(object sender, EventArgs e)
        {
            UC_QLPhong.UC_PhongDangThue ttp = new UC_QLPhong.UC_PhongDangThue();
            AddUserConTrol(ttp);
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_SoDoPhong_Click(object sender, EventArgs e)
        {
            UC_SoDo sd = new UC_SoDo();
            AddUserConTrol(sd);
        }
    }
}
