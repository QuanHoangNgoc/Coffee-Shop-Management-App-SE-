using CoffeeShopApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeShopApp
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadAccountList();
            return;
        }

        private void loadAccountList()
        {
            const string sqlQuery = "select userName as N'Tên đăng nhập', " +
                "displayName as N'Tên hiển thị', " +
                "type as N'Admin' " +
            "from dbo.Account where dbo.Account.isDeleted = 0 "; 

            dataGridViewAccount.DataSource = DataProvider.Instance.executeQuery(sqlQuery);
            return; 
        }
        
        private void tabPageAccount_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
