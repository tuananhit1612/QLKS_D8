using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.DanhSachLoaiPhong
{
    public partial class UC_LoaiPhong : UserControl
    {
        public event EventHandler RoomClicked;
        private string hinhAnh;
        public UC_LoaiPhong()
        {
            InitializeComponent();
        }

        public string TenLoaiPhong { get { return lblTenLoaiPhong.Text; } set { lblTenLoaiPhong.Text = value; } }
        public string DienTichPhong { get { return lblSize.Text; } set { lblSize.Text = value; } }
        public string MoTa { get { return lblMoTa.Text; } set { lblMoTa.Text = value; } }
        public string SoNguoi { get { return lblSoNguoi.Text; } set { lblSoNguoi.Text = value; } }
        public string giaPhong { get { return lblGiaPhong.Text; } set { lblGiaPhong.Text = value; } }
        public string HinhAnhPhong
        {
            set
            {
                try
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "HinhAnhPhong", value);
                    guna2PictureBox1.Image = Image.FromFile(imagePath);
                    guna2PictureBox1.Refresh();
                    hinhAnh = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
            get
            {
                return hinhAnh;
            }
        }
        public string DacTrung { get; internal set; }
        public string CoSoVatChat { get; internal set; }
        public string TienNghi { get; internal set; }
        public int PhongTrong { get; internal set; }
        public int TongPhong { get; internal set; }

        private void UC_LoaiPhong_Load(object sender, EventArgs e)
        {
            lblPhongTrong.Text = $"{PhongTrong}/{TongPhong} phòng";
            if(TongPhong - PhongTrong <= 5)
            {
                lblPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
            else
            {
                lblPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            RoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PanelLoaiPhong_Click(object sender, EventArgs e)
        {
            RoomClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblTenLoaiPhong_Click(object sender, EventArgs e)
        {
            RoomClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
