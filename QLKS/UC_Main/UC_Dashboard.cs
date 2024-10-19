using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_Main
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            lblDangThue.Text = PhongDAO.Instance.DemSoPhongDangThue("Tất Cả").ToString();
            lblHetHan.Text = PhongDAO.Instance.DemSoPhongHetHan("Tất Cả").ToString();
            lblPhongDatTruoc.Text = PhongDAO.Instance.DemSoPhongDaDat("Tất Cả").ToString();
            lblTongKhach.Text = DataProvider.Instance.ExecuteScalar("SELECT (SELECT COUNT(DISTINCT CCCD) FROM PhongDangThue) + (SELECT COUNT(DISTINCT CCCD) FROM PhongHetHan) AS TongKhach").ToString();
        }
    }
}
