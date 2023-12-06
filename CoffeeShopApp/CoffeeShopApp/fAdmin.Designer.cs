namespace CoffeeShopApp
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlFood = new System.Windows.Forms.TabControl();
            this.tabPageBill = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.buttonBillView = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.tabPageFood = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonShowFood = new System.Windows.Forms.Button();
            this.buttonEditFood = new System.Windows.Forms.Button();
            this.buttonDeleteFood = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSearchNameFood = new System.Windows.Forms.TextBox();
            this.buttonSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonShowCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonShowAccount = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControlFood.SuspendLayout();
            this.tabPageBill.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.tabPageFood.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.tabPageAccount.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlFood);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 580);
            this.panel1.TabIndex = 0;
            // 
            // tabControlFood
            // 
            this.tabControlFood.Controls.Add(this.tabPageBill);
            this.tabControlFood.Controls.Add(this.tabPageFood);
            this.tabControlFood.Controls.Add(this.tabPageCategory);
            this.tabControlFood.Controls.Add(this.tabPageAccount);
            this.tabControlFood.Location = new System.Drawing.Point(7, 8);
            this.tabControlFood.Name = "tabControlFood";
            this.tabControlFood.SelectedIndex = 0;
            this.tabControlFood.Size = new System.Drawing.Size(962, 571);
            this.tabControlFood.TabIndex = 0;
            // 
            // tabPageBill
            // 
            this.tabPageBill.Controls.Add(this.panel3);
            this.tabPageBill.Controls.Add(this.panel2);
            this.tabPageBill.Location = new System.Drawing.Point(4, 25);
            this.tabPageBill.Name = "tabPageBill";
            this.tabPageBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBill.Size = new System.Drawing.Size(954, 542);
            this.tabPageBill.TabIndex = 0;
            this.tabPageBill.Text = "Doanh thu";
            this.tabPageBill.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonExportFile);
            this.panel3.Controls.Add(this.buttonBillView);
            this.panel3.Controls.Add(this.dateTimePickerToDate);
            this.panel3.Controls.Add(this.dateTimePickerFromDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 66);
            this.panel3.TabIndex = 1;
            // 
            // buttonExportFile
            // 
            this.buttonExportFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExportFile.Location = new System.Drawing.Point(445, 0);
            this.buttonExportFile.Name = "buttonExportFile";
            this.buttonExportFile.Size = new System.Drawing.Size(166, 66);
            this.buttonExportFile.TabIndex = 5;
            this.buttonExportFile.Text = "Xuất File";
            this.buttonExportFile.UseVisualStyleBackColor = false;
            // 
            // buttonBillView
            // 
            this.buttonBillView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBillView.Location = new System.Drawing.Point(273, 0);
            this.buttonBillView.Name = "buttonBillView";
            this.buttonBillView.Size = new System.Drawing.Size(166, 66);
            this.buttonBillView.TabIndex = 4;
            this.buttonBillView.Text = "Thống kê";
            this.buttonBillView.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(3, 37);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerToDate.TabIndex = 1;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerFromDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewBill);
            this.panel2.Location = new System.Drawing.Point(4, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 473);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(2, 7);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(940, 461);
            this.dataGridViewBill.TabIndex = 0;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // tabPageFood
            // 
            this.tabPageFood.Controls.Add(this.panel5);
            this.tabPageFood.Location = new System.Drawing.Point(4, 25);
            this.tabPageFood.Name = "tabPageFood";
            this.tabPageFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFood.Size = new System.Drawing.Size(954, 542);
            this.tabPageFood.TabIndex = 1;
            this.tabPageFood.Text = "Sản phẩm ";
            this.tabPageFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(952, 540);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonShowFood);
            this.panel7.Controls.Add(this.buttonEditFood);
            this.panel7.Controls.Add(this.buttonDeleteFood);
            this.panel7.Controls.Add(this.buttonAddFood);
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(572, 91);
            this.panel7.TabIndex = 3;
            // 
            // buttonShowFood
            // 
            this.buttonShowFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowFood.Location = new System.Drawing.Point(376, 3);
            this.buttonShowFood.Name = "buttonShowFood";
            this.buttonShowFood.Size = new System.Drawing.Size(109, 85);
            this.buttonShowFood.TabIndex = 6;
            this.buttonShowFood.Text = "Xem";
            this.buttonShowFood.UseVisualStyleBackColor = false;
            // 
            // buttonEditFood
            // 
            this.buttonEditFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditFood.Location = new System.Drawing.Point(263, 3);
            this.buttonEditFood.Name = "buttonEditFood";
            this.buttonEditFood.Size = new System.Drawing.Size(107, 85);
            this.buttonEditFood.TabIndex = 5;
            this.buttonEditFood.Text = "Chỉnh sửa";
            this.buttonEditFood.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeleteFood.Location = new System.Drawing.Point(145, 3);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.Size = new System.Drawing.Size(112, 85);
            this.buttonDeleteFood.TabIndex = 4;
            this.buttonDeleteFood.Text = "Xóa ";
            this.buttonDeleteFood.UseVisualStyleBackColor = false;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddFood.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(136, 85);
            this.buttonAddFood.TabIndex = 3;
            this.buttonAddFood.Text = "Thêm";
            this.buttonAddFood.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxSearchNameFood);
            this.panel6.Controls.Add(this.buttonSearchFood);
            this.panel6.Location = new System.Drawing.Point(583, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 91);
            this.panel6.TabIndex = 2;
            // 
            // textBoxSearchNameFood
            // 
            this.textBoxSearchNameFood.Location = new System.Drawing.Point(3, 34);
            this.textBoxSearchNameFood.Name = "textBoxSearchNameFood";
            this.textBoxSearchNameFood.Size = new System.Drawing.Size(243, 22);
            this.textBoxSearchNameFood.TabIndex = 8;
            this.textBoxSearchNameFood.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearchFood
            // 
            this.buttonSearchFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSearchFood.Location = new System.Drawing.Point(252, 3);
            this.buttonSearchFood.Name = "buttonSearchFood";
            this.buttonSearchFood.Size = new System.Drawing.Size(109, 85);
            this.buttonSearchFood.TabIndex = 7;
            this.buttonSearchFood.Text = "Tìm kiếm";
            this.buttonSearchFood.UseVisualStyleBackColor = false;
            this.buttonSearchFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewFood);
            this.panel4.Location = new System.Drawing.Point(4, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 438);
            this.panel4.TabIndex = 0;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(-2, 3);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersWidth = 51;
            this.dataGridViewFood.RowTemplate.Height = 24;
            this.dataGridViewFood.Size = new System.Drawing.Size(942, 427);
            this.dataGridViewFood.TabIndex = 0;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.panel8);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(954, 542);
            this.tabPageCategory.TabIndex = 2;
            this.tabPageCategory.Text = "Danh mục";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(1, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(952, 540);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonShowCategory);
            this.panel9.Controls.Add(this.buttonEditCategory);
            this.panel9.Controls.Add(this.buttonDeleteCategory);
            this.panel9.Controls.Add(this.buttonAddCategory);
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(572, 91);
            this.panel9.TabIndex = 3;
            // 
            // buttonShowCategory
            // 
            this.buttonShowCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowCategory.Location = new System.Drawing.Point(376, 3);
            this.buttonShowCategory.Name = "buttonShowCategory";
            this.buttonShowCategory.Size = new System.Drawing.Size(109, 85);
            this.buttonShowCategory.TabIndex = 6;
            this.buttonShowCategory.Text = "Xem";
            this.buttonShowCategory.UseVisualStyleBackColor = false;
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditCategory.Location = new System.Drawing.Point(263, 3);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(107, 85);
            this.buttonEditCategory.TabIndex = 5;
            this.buttonEditCategory.Text = "Chỉnh sửa";
            this.buttonEditCategory.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(145, 3);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(112, 85);
            this.buttonDeleteCategory.TabIndex = 4;
            this.buttonDeleteCategory.Text = "Xóa ";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddCategory.Location = new System.Drawing.Point(3, 3);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(136, 85);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "Thêm";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dataGridViewCategory);
            this.panel11.Location = new System.Drawing.Point(4, 102);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(943, 438);
            this.panel11.TabIndex = 0;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(-2, 3);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(942, 427);
            this.dataGridViewCategory.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.panel10);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(954, 542);
            this.tabPageAccount.TabIndex = 3;
            this.tabPageAccount.Text = "Tài khoản ";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            this.tabPageAccount.Click += new System.EventHandler(this.tabPageAccount_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Location = new System.Drawing.Point(1, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(952, 540);
            this.panel10.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.buttonShowAccount);
            this.panel12.Controls.Add(this.buttonEditAccount);
            this.panel12.Controls.Add(this.buttonDeleteAccount);
            this.panel12.Controls.Add(this.buttonAddAccount);
            this.panel12.Location = new System.Drawing.Point(5, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(572, 91);
            this.panel12.TabIndex = 3;
            // 
            // buttonShowAccount
            // 
            this.buttonShowAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowAccount.Location = new System.Drawing.Point(376, 3);
            this.buttonShowAccount.Name = "buttonShowAccount";
            this.buttonShowAccount.Size = new System.Drawing.Size(109, 85);
            this.buttonShowAccount.TabIndex = 6;
            this.buttonShowAccount.Text = "Xem";
            this.buttonShowAccount.UseVisualStyleBackColor = false;
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditAccount.Location = new System.Drawing.Point(263, 3);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(107, 85);
            this.buttonEditAccount.TabIndex = 5;
            this.buttonEditAccount.Text = "Chỉnh sửa";
            this.buttonEditAccount.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(145, 3);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(112, 85);
            this.buttonDeleteAccount.TabIndex = 4;
            this.buttonDeleteAccount.Text = "Xóa ";
            this.buttonDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddAccount.Location = new System.Drawing.Point(3, 3);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(136, 85);
            this.buttonAddAccount.TabIndex = 3;
            this.buttonAddAccount.Text = "Thêm";
            this.buttonAddAccount.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dataGridViewAccount);
            this.panel14.Location = new System.Drawing.Point(4, 102);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(943, 438);
            this.panel14.TabIndex = 0;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(-2, 3);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowHeadersWidth = 51;
            this.dataGridViewAccount.RowTemplate.Height = 24;
            this.dataGridViewAccount.Size = new System.Drawing.Size(942, 427);
            this.dataGridViewAccount.TabIndex = 0;
            this.dataGridViewAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellContentClick);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 586);
            this.Controls.Add(this.panel1);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.tabControlFood.ResumeLayout(false);
            this.tabPageBill.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.tabPageFood.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.tabPageAccount.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlFood;
        private System.Windows.Forms.TabPage tabPageBill;
        private System.Windows.Forms.TabPage tabPageFood;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button buttonBillView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonShowFood;
        private System.Windows.Forms.Button buttonEditFood;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.Button buttonSearchFood;
        private System.Windows.Forms.TextBox textBoxSearchNameFood;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Button buttonExportFile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonShowCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonShowAccount;
        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
    }
}