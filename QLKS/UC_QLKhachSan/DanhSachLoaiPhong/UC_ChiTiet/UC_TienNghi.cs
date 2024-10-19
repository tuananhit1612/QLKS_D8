using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_QLPhong.UC_LinhTinh
{
    public partial class UC_TienNghi : UserControl
    {
        public UC_TienNghi()
        {
            InitializeComponent();
        }
        public string TienNghiPhong
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public void AddIcon(int n)
        {
            pictureBox1.ImageLocation = $"C:\\Users\\tuana\\source\\repos\\QLKS\\QLKS\\Resources\\{n}.png";
            
        }
        public void AddTienNghi(string TienNghi)
        {
            switch (TienNghi)
            {
                case "Tivi":
                    AddIcon(1);
                    break;
                case "Wifi miễn phí":
                    AddIcon(2);
                    break;
                case "Máy sấy tóc":
                    AddIcon(3);
                    break;
                case "Máy pha cà phê":
                    AddIcon(4);
                    break;
                case "Tủ Lạnh":
                    AddIcon(5);
                    break;
                case "Điều hòa nhiệt độ":
                    AddIcon(6);
                    break;
            }
        }
    }
}
