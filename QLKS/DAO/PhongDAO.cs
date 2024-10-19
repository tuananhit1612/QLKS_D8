using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLKS.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance 
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        
        }


       public PhongDAO() { }

       public List<Phong> ListPhong (string Tang,string loaiPhong) {
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select * from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.Tang = " + Tang;
            }
            else
            {
                query = "select * from phong p, loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.Tang = " + Tang + " and lp.TenLoaiPhong = N'" + loaiPhong + "'";

            }
            List<Phong> dataPhong = new List<Phong>();
            DataTable data =  DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Phong dtphong = new Phong(item);
                dataPhong.Add(dtphong);
            }
            return dataPhong;
        }
        public List<PhongTrong> GetPhongTrong(int MaPhong)
        {
            List<PhongTrong> dataPhongTrong = new List<PhongTrong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongDangTrong @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongTrong dtphongtrong = new PhongTrong(item);
                dataPhongTrong.Add(dtphongtrong);
            }
            return dataPhongTrong;
        }
        public List<PhongSuaChua> GetPhongSuaChua(int MaPhong)
        {
            List<PhongSuaChua> dataPhongSuaChua= new List<PhongSuaChua>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongDangSuaChua @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongSuaChua dtphong = new PhongSuaChua(item);
                dataPhongSuaChua.Add(dtphong);
            }
            return dataPhongSuaChua;
        }
        public List<PhongDonDep> GetPhongDonDep(int MaPhong)
        {
            List<PhongDonDep> dataPhongDonDep = new List<PhongDonDep>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongDangDonDep @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongDonDep dtphong = new PhongDonDep(item);
                dataPhongDonDep.Add(dtphong);
            }
            return dataPhongDonDep;
        }
        public List<PhongDatTruoc> GetPhongDatTruoc(int MaPhong)
        {
            List<PhongDatTruoc> dtDatTruoc = new List<PhongDatTruoc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongDatTruoc @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongDatTruoc dtphong = new PhongDatTruoc(item);
                dtDatTruoc.Add(dtphong);
            }
            return dtDatTruoc;

        }
        public List<PhongDangThue> GetPhongDangThue(int MaPhong)
        {
            List<PhongDangThue> dtDangThue = new List<PhongDangThue>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongDangThue @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongDangThue dtphong = new PhongDangThue(item);
                dtDangThue.Add(dtphong);
            }
            return dtDangThue;

        }
        public List<PhongHetHan> GetPhongHetHan(int MaPhong)
        {
            List<PhongHetHan> dtHetHan = new List<PhongHetHan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec TTA_PhongHetHan @maPhong = " + MaPhong);
            foreach (DataRow item in data.Rows)
            {
                PhongHetHan dtphong = new PhongHetHan(item);
                dtHetHan.Add(dtphong);
            }
            return dtHetHan;

        }
        public int DemSoPhong(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if(loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and lp.TenLoaiPhong = N'"+ loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }
        public int DemSoPhongTrong(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Trống'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Trống' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }
        public int DemSoPhongDaDat(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đã đặt trước'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đã đặt trước' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }

        public int DemSoPhongDangThue(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang Thuê'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang Thuê' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }

        public int DemSoPhongDangDonDep(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang dọn dẹp'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang dọn dẹp' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }

        public int DemSoPhongDangSuaChua(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang sửa chữa'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Đang sửa chữa' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }

        public int DemSoPhongHetHan(string loaiPhong)
        {
            int cnt = 0;
            string query;
            if (loaiPhong == "Tất Cả")
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Hết Hạn'";
            }
            else
            {
                query = "select count(*) from phong p,loaiphong lp where p.MaLoaiPhong = lp.MaLoaiPhong and p.TinhTrang = N'Hết Hạn' and lp.TenLoaiPhong = N'" + loaiPhong + "'";
            }
            cnt = (int)DataProvider.Instance.ExecuteScalar(query);
            return cnt;
        }
    }
}
