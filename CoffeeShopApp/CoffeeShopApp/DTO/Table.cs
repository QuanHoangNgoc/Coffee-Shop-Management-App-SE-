using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DTO
{
    public class Table
    {
        private int id = 0;
        private string name = "Noname";
        private string status = "Empty";

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public Table(int id = 0, string name = "Noname", string status = "Empty") 
        { 
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public Table(DataRow row) 
        {
            this.id = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.status = row["status"].ToString();
        }
    }
}
