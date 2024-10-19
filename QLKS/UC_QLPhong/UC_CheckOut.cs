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

namespace QLKS.UC_QLPhong
{
    public partial class UC_CheckOut : UserControl
    {
        public UC_CheckOut()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            guna2DataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("TTA_DSPhongHetHan");
        }
    }
}
