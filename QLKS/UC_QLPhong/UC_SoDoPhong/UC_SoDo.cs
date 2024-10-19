using QLKS.DAO;
using QLKS.DTO;
using QLKS_BUS.BUSs.PhongBUS;
using QLKS_BUS.BUSs.TangBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.UC_SoDoPhong
{
    public partial class UC_SoDo : UserControl
    {
        PhongBUS _phongBUS;
        TangBUS _tangBUS;
        public UC_SoDo()
        {
            InitializeComponent();
            _phongBUS = new PhongBUS();
            _tangBUS= new TangBUS();
            AddFloors(0);
            ThemThaiPhong();

        }
        private void ThemThaiPhong()
        {
            string LoaiPhong = cmbLoaiPhong.Text;
            btnAll.LabelText = "(" + _phongBUS.DemTrangThaiPhong(0,LoaiPhong).ToString() + ")"; // 0 là tất cả trạng thái nha...
            btnPhongTrong.LabelText = "(" + _phongBUS.DemTrangThaiPhong(1, LoaiPhong).ToString() + ")"; // 1 trống
            btnDangThue.LabelText = "(" + _phongBUS.DemTrangThaiPhong(2, LoaiPhong).ToString() + ")"; // 2 đang thuê
            btnDatTruoc.LabelText = "(" + _phongBUS.DemTrangThaiPhong(3, LoaiPhong).ToString() + ")"; // 3 đặt trước
            btnHetHan.LabelText = "(" + _phongBUS.DemTrangThaiPhong(4, LoaiPhong).ToString() + ")"; // 4 hết hạn
            btnSuaChua.LabelText = "(" + _phongBUS.DemTrangThaiPhong(5, LoaiPhong).ToString() + ")"; // 5 bảo trì
            btnDonDep.LabelText = "(" + _phongBUS.DemTrangThaiPhong(6, LoaiPhong).ToString() + ")"; //6 dọn dẹp
        }
        private void AddFloors(int k)
        {
            //Phong phong = new Phong();
            //flowLayoutPanel1.Controls.Clear();
            //for (int i = 1; i <= phong.SoTang; i++)
            //{
            //    UC_Tang uc = new UC_Tang(i,cmbLoaiPhong.Text);
            //    switch(k)
            //    {
            //        case 0: uc.AllRooms(i); break;
            //        case 1: uc.XuLyPhongTrong(i); break;
            //        case 2: uc.XuLyPhongDatTruoc(i); break;
            //        case 3: uc.XuLyPhongDonDep(i); break;
            //        case 4: uc.XuLyPhongHetHan(i); break;
            //        case 5: uc.XuLyPhongSuaChua(i); break;
            //        case 6: uc.XuLyPhongDangThue(i); break;
            //    }
                
            //    flowLayoutPanel1.Controls.Add(uc);

            //}
            var tang = _tangBUS.GetALLTang();
            foreach(var t in tang)
            {
                UC_Tang uc = new UC_Tang();
                uc.SoTang = t.maTang;
                uc.ThemSoTang();
                flowLayoutPanel1.Controls.Add(uc);
            }

        }
        public void Refresh()
        {
            AddFloors(0);
        }
        private void UC_SoDo_Load(object sender, EventArgs e)
        {
            cmbLoaiPhong.SelectedIndex = 0;
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AddFloors(0);
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            AddFloors(1);
        }

        private void btnDangThue_Click(object sender, EventArgs e)
        {
            AddFloors(6);
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            AddFloors(2);
        }

        private void btnHetHan_Click(object sender, EventArgs e)
        {
            AddFloors(4);
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            AddFloors(5);
        }

        private void btnDonDep_Click(object sender, EventArgs e)
        {
            AddFloors(3);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AddFloors(0);
            ThemThaiPhong();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFloors(0);
            ThemThaiPhong();
        }
    }
}
