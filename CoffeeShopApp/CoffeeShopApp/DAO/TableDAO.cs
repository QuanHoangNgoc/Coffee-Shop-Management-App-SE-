using CoffeeShopApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp.DAO
{
    public class TableDAO
    {
        private static TableDAO instance = new TableDAO();

        public static TableDAO Instance { get => instance; private set => instance = value; }
        //public TableDAO() { }; 
        /** Singleton Class */

        public List<Table> LoadTableList()
        {
            List<Table> tables = new List<Table>();
            string sql = "Select * from dbo.TableFood where (isDeleted = 0)";
            DataTable date = DataProvider.Instance.executeQuery(sql); 
            
            foreach (DataRow row in date.Rows)
            {
                Table tabe = new Table(row); 
                tables.Add(tabe);
            }
            return tables;
        }
    }
}
