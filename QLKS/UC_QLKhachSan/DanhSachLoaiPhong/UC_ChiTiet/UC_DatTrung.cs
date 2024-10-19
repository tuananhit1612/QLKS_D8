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
  
    public partial class UC_DatTrung : UserControl
    {
        public UC_DatTrung()
        {
            InitializeComponent();
        }
        public string DacTrungPhong
        {
            get 
            {
                return label1.Text;
            }
            set
            {
                label1.Text= value;
            }
        }
    }
}
