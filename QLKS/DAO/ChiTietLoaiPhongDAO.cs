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
    public class ChiTietLoaiPhongDAO
    {
        private static ChiTietLoaiPhongDAO instance;

        internal static ChiTietLoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietLoaiPhongDAO();
                return ChiTietLoaiPhongDAO.instance;
            }
            private set => instance = value;
        }
        private ChiTietLoaiPhongDAO() { }

        public List<ChiTietLoaiPhong> LoadChiTietLoaiPhong()
        {

            List<ChiTietLoaiPhong> dataCTLP = new List<ChiTietLoaiPhong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("TTA_ListLoaiPhong");
            //MessageBox.Show($"Số lượng dòng: {data.Rows.Count}");
            foreach (DataRow item in data.Rows)
            {
                ChiTietLoaiPhong ctlp = new ChiTietLoaiPhong(item);
                dataCTLP.Add(ctlp);
            }
            return dataCTLP;
        }
     
    }
}
