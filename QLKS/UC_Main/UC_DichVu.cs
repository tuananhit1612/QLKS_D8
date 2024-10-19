using QLKS.DAO;
using QLKS.DTO;
using QLKS.UC_DichVuPhong;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class main : UserControl
    {
        DataTable dt;
        private decimal tongTien =0;
        public main()
        {
            InitializeComponent();
        }

        private void UC_DichVu_Load(object sender, EventArgs e)
        {
            txtMaPhong.Focus();
            btnDoAn.PerformClick();
            dt = new DataTable();
            dt.Columns.Add("MaDichVu", typeof(int));
            dt.Columns.Add("TenDichVu", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("Gia", typeof(decimal));
            guna2DataGridView1.DataSource = dt;
        }
        private void AddThongTinDichVu(int k)
        {
            flowLayoutPanel1.Controls.Clear();
            List<DichVu> data = DichVuDAO.Instance.LoadDichVu(k);
            foreach (DichVu item in data)
            {
               
                UC_ThongTinDV uc = new UC_ThongTinDV(item.MaDichVu,item.TenDichVu,item.Gia,item.HinhAnh);
                uc.DichVuClicked += UC_ThongTinDV_DichVuClicked;
                flowLayoutPanel1.Controls.Add(uc);

            }

        }
        private void UC_ThongTinDV_DichVuClicked(object sender, EventArgs e)
        {
            UC_ThongTinDV dvControl = sender as UC_ThongTinDV;
            if (dvControl != null)
            {
                dt.Rows.Add(dvControl.MaDichVu, dvControl.TenDichVu, dvControl.SoLuong, dvControl.Gia);
                tongTien += Convert.ToDecimal(dvControl.Gia * dvControl.SoLuong);
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }
        private void btnDoAn_Click(object sender, EventArgs e)
        {
            AddThongTinDichVu(1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AddThongTinDichVu(2);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            AddThongTinDichVu(3);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == guna2DataGridView1.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {

                decimal gia = (decimal)guna2DataGridView1.Rows[e.RowIndex].Cells["gia"].Value;
                int soluong = (int)guna2DataGridView1.Rows[e.RowIndex].Cells["soLuong"].Value;
                tongTien -= Convert.ToDecimal(gia * soluong);
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maphong = txtMaPhong.Text;
            int check = (int)DataProvider.Instance.ExecuteScalar("Select count(*) from Phong where  MaPhong = " + maphong + " AND TinhTrang = N'Đang Thuê'");
            if(check > 0)
            {
                MessageBox.Show("Mã phòng hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mã phòng sai hoặc tình trạng phòng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count <= 0)
            {
                MessageBox.Show("Hiện chưa có dịch vụ nào được thêm vào");
                return;
            }
            DateTime ngayLap = DateTime.Now;
            try

            {
                string maCTDV = DataProvider.Instance.ExecuteScalar("select ISNULL(Max(MaChiTietDV),0)+1 from ChiTietDichVu").ToString();
                foreach (DataRow dr in dt.Rows)
                {
                    int check = DataProvider.Instance.ExecuteNonQuery("EXEC InsertChiTietDichVu @MaChiTietDV , @MaPhong , @MaDichVu , @SoLuong , @NgaySuDung", new object[] { maCTDV, txtMaPhong.Text, dr["MaDichVu"], dr["SoLuong"], ngayLap });
                }
                MessageBox.Show("Thêm thành công");
                dt.Rows.Clear();
                txtMaPhong.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
