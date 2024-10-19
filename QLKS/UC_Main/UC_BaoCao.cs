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

namespace QLKS.UserControls
{
    public partial class UC_BaoCao : UserControl
    {
        public UC_BaoCao()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("Select * from HoaDon");
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
