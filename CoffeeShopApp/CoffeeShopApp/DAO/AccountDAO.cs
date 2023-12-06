using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;    
        //private AccountDAO() { };

        public static AccountDAO Instance { 
            get { if(instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }  
        }
        /* "Combo Singleton" */ 

        public bool checkLogin(string username, string password)
        {
            string sql = "select * " +
                "from dbo.Account " +
                "where (isDeleted = 0 and username like N'{0}' and password like N'{1}') ";
            //! "not distine upper and lower case"  
            sql = String.Format(sql, username, password);   
            DataTable dataTable = DataProvider.Instance.executeQuery(sql);  
            return dataTable.Rows.Count > 0; 
        }
    }
}
