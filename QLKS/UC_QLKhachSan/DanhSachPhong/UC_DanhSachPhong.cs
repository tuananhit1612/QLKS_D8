using QLKS_BUS.BUSs.PhongBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QLKS.UC_QLKhachSan.DanhSachPhong
{
    public partial class UC_DanhSachPhong : UserControl
    {
        PhongBUS phongBUS;
        public UC_DanhSachPhong()
        {
            InitializeComponent();
            phongBUS = new PhongBUS();
        }
        private void PopulateDataGridView()
        {
            dgvPhong.Rows.Clear();
            var groupedPhong = phongBUS.GetAllPhong().GroupBy(p => p.tang).OrderBy(g => g.Key);
            foreach (var group in groupedPhong)
            {
                DataGridViewRow rowHeader = new DataGridViewRow();
                rowHeader.CreateCells(dgvPhong);
                rowHeader.Cells[0].Value = $"Tầng {group.Key} ({group.Count()} phòng)";
                rowHeader.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                rowHeader.DefaultCellStyle.BackColor = Color.LightGray;
                rowHeader.Cells[3] = new DataGridViewTextBoxCell();
                rowHeader.Cells[3].Value = "";
                dgvPhong.Rows.Add(rowHeader);
                foreach (var phong in group)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPhong, phong.maPhong, phong.tenLoaiPhong, phong.tang);
                    dgvPhong.Rows.Add(row);
                }
            }
            dgvPhong.Columns[3].ReadOnly = false;
        }

        private void UC_DanhSachPhong_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
