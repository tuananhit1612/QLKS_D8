using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace QLKS.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance 
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        public KhachHangDAO() { }

        public List<KhachHang> CheckKhachHang(string cccd)
        {
            List<KhachHang> data = new List<KhachHang>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("exec TTA_CheckKhachHang @cccd =" + cccd);
            foreach (DataRow item in dt.Rows)
            { 
                KhachHang kh = new KhachHang(item);
                data.Add(kh);
            }
            return data;
        }
       
    }
}
