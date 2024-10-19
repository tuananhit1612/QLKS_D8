using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance 
        {
            get
            {
                if(instance == null) instance = new DichVuDAO();
                return instance;
            } 
            set => instance = value; 
        }
        public DichVuDAO() { }

        public List<DichVu> LoadDichVu(int maDichVu)
        { 
            List<DichVu> data = new List<DichVu>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from DichVu where MaLoaiDichVu =" + maDichVu);
            foreach(DataRow item in dt.Rows)
            {
                DichVu dv = new DichVu(item);
                data.Add(dv);
            }
            return data;

        }
    }
}
