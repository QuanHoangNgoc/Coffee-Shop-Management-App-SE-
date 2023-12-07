using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        //private DataProvider() {}; 

        //! change on user computer 
        //private string connectionString = "Data Source=.\\sqlexpress; Initial Catalog=CoffeeShop; Integrated Security=True";
        
        private string connectionString = "Data Source=LAPTOP-7S3B342J;Initial Catalog=CoffeeShop;Integrated Security=True";
        public DataTable executeQuery(string sql, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using(SqlConnection conn = new SqlConnection(connectionString)) 
            { 
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //have 2 version 
                if(parameters != null) 
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0; 
                    foreach(string para in listPara)
                    {
                        if (para.Contains("@")) 
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i]); 
                            i++; 
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }

            return data;    
        }

        public int executeNonQuery(string sql, object[] parameters = null)
        {
            int data = 0; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //have 2 version 
                if (parameters != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i]);
                            i++;
                        }
                    }
                }
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //adapter.Fill(data);
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return data;
        }

        public object executeScalar(string sql, object[] parameters = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //have 2 version 
                if (parameters != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameters[i]);
                            i++;
                        }
                    }
                }
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //adapter.Fill(data);
                data = cmd.ExecuteScalar();
                conn.Close();
            }

            return data;
        }
    }
}
