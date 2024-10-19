using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    
    internal class DataProvider
    {
        private static DataProvider instance;

        internal static DataProvider Instance 
        { get { 
                if (instance == null) 
                    instance = new DataProvider();
                return DataProvider.instance;
               } 
          private set => instance = value; 
        }
        private DataProvider() { }
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        public DataTable ExecuteQuery(string query , object[] parameter = null)
        {
            DataTable dt= new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i++]);

                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i++]);
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i++]);
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
