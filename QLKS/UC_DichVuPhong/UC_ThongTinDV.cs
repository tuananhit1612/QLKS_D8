using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_DichVuPhong
{
    public partial class UC_ThongTinDV : UserControl
    {
        public event EventHandler DichVuClicked;
        private int maDichVu;
        private string tenDichVu;
        private decimal gia;
        private string hinhAnh;
        private int soLuong;


        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public UC_ThongTinDV(int maDichVu, string tenDichVu, decimal gia, string hinhAnh)
        {
            this.MaDichVu= maDichVu;
            this.TenDichVu= tenDichVu;
            this.Gia= gia;
            this.HinhAnh= hinhAnh;
            soLuong = 1;
            InitializeComponent();
            

        }
        private Image GetImageFromResources(string imageName)
        {
            var resourceManager = Properties.Resources.ResourceManager;
            var image = resourceManager.GetObject(imageName) as Image;
            return image;
        }
        private void UC_ThongTinDV_Load(object sender, EventArgs e)
        {
            try
            {
                string relativePath = $"..\\..\\HinhAnhDichVu\\{HinhAnh}";
                string fullPath = Path.GetFullPath(relativePath);
                pictureBox1.ImageLocation = fullPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
            }
            
            lblTen.Text = TenDichVu;
            lblGia.Text = Gia.ToString("N0") + " VNĐ";
        }

        private void UC_ThongTinDV_Click(object sender, EventArgs e)
        {
            //DichVuClicked?.Invoke(this, EventArgs.Empty);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            soLuong = (int)guna2NumericUpDown1.Value;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DichVuClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
