using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopApp.DAO;
using CoffeeShopApp.DTO; 

namespace CoffeeShopApp
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();

            loadTables();
            return; 
        }

        #region Method
        public void loadTables()
        {
            const int SIZE = 80; 
            List<Table> tables = TableDAO.Instance.LoadTableList();
            foreach (Table table in tables) 
            {
                Button button = new Button();
                button.Text = table.Name + Environment.NewLine + table.Status;
                button.Width = SIZE; button.Height = SIZE; 
                if(table.Status != "Empty")
                    button.BackColor = Color.WhiteSmoke; 
                else
                    button.BackColor = Color.DarkGray; 
                flowLayoutPanelTable.Controls.Add(button);
            }
            return; 
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<CoffeeShopApp.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (CoffeeShopApp.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }
            #endregion

        #region events 
            private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {

        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            ShowBill(tableID);
        }


        #endregion

        private void comboBoxSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
