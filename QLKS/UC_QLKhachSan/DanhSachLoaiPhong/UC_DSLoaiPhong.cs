using QLKS.DAO;
using QLKS.DTO;
using QLKS.UC_QLPhong.UC_LinhTinh;
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
using QLKS_BUS.ViewModels;
using QLKS_BUS.BUSs.LoaiPhongBUS;
using Guna.UI2.WinForms;
using System.IO;

namespace QLKS.UC_QLKhachSan.DanhSachLoaiPhong
{
    public partial class UC_DSLoaiPhong : UserControl
    {
        public event EventHandler RoomClicked;
        private LoaiPhongBUS _loaiPhongBUS;
        public UC_DSLoaiPhong()
        {
            InitializeComponent();
            _loaiPhongBUS = new LoaiPhongBUS();
        }
        private void AddRooms()
        {
            List<LoaiPhongViewModel> listLoaiPhong = _loaiPhongBUS.GetAllLoaiPhong();
            UC_LoaiPhong ucfirst = null;
            foreach (LoaiPhongViewModel item in listLoaiPhong)
            {
                UC_LoaiPhong uc = new UC_LoaiPhong();
                uc.TenLoaiPhong = item.tenLoaiPhong;
                uc.DienTichPhong = item.dienTich;
                uc.MoTa = item.moTa;
                uc.SoNguoi = item.soNguoi.ToString();
                uc.PhongTrong = _loaiPhongBUS.DemLoaiPhongTrongByMaLoaiPhong(item.maLoaiPhong.ToString());
                uc.TongPhong = _loaiPhongBUS.DemLoaiPhongByMaLoaiPhong(item.maLoaiPhong.ToString());
                uc.giaPhong = item.donGia.ToString("N0") + " VNĐ";
                uc.HinhAnhPhong = item.hinhAnh;
                uc.DacTrung = item.dacTrung;
                uc.TienNghi = item.tienNghi;
                uc.RoomClicked += new EventHandler(this.UC_LoaiPhong_RoomClicked);
                if (ucfirst == null) ucfirst = uc;
                FLPanelListRoom.Controls.Add(uc);
            }
            UC_LoaiPhong_RoomClicked(ucfirst, EventArgs.Empty);
        }
        private static List<string> TachChuoi(string chuoi)
        {
            List<string> data = new List<string>();
            if (chuoi != null)
            {
                string[] parts = chuoi.Split(new string[] { "," }, StringSplitOptions.None);
                data.AddRange(parts);
            }
            return data;
        }
        public void UC_LoaiPhong_RoomClicked(object sender, EventArgs e)
        {
            UC_LoaiPhong roomControl = sender as UC_LoaiPhong;
            if (roomControl != null)
            {
                lblTenLoaiPhong.Text = roomControl.TenLoaiPhong;
                lblPhongTrong.Text = roomControl.PhongTrong.ToString();
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "HinhAnhPhong", roomControl.HinhAnhPhong);
                pictureBox2.Image = Image.FromFile(imagePath);
                lblSize.Text = roomControl.DienTichPhong.ToString();
                lblSoNguoi.Text = roomControl.SoNguoi.ToString();
                lblMoTa.Text = roomControl.MoTa.ToString();
                // Add list đặc trưng phòng
                string DacTrungList = roomControl.DacTrung;
                List<string> dataDacTrung = TachChuoi(DacTrungList);
                panelDacTrung.Controls.Clear();
                foreach (string item in dataDacTrung)
                {
                    UC_DatTrung uc = new UC_DatTrung();
                    uc.DacTrungPhong = item;
                    panelDacTrung.Controls.Add(uc);
                }
                //
                // Add list TienNghi
                string TNList = roomControl.TienNghi;
                List<string> dataTN = TachChuoi(TNList);
                panelTienNghi.Controls.Clear();
                foreach (string item in dataTN)
                {
                    UC_TienNghi uc = new UC_TienNghi();
                    uc.TienNghiPhong = item;
                    uc.AddTienNghi(item);
                    panelTienNghi.Controls.Add(uc);
                }
                //

            }
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_DSLoaiPhong_Load(object sender, EventArgs e)
        {
            AddRooms();
        }

        private void FLPanelListRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLPanelListRoom_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
    
}
