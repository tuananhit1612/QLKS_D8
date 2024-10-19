using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UC_Main
{
    public partial class UC_Booking : UserControl
    {
        public UC_Booking()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            guna2DataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("TTA_DSPhongDatTruoc");
        }
    }
}
