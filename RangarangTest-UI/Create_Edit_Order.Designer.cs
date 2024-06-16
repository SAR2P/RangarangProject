namespace RangarangTest_UI
{
    partial class Create_Edit_Order
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
            buttonPanel = new Panel();
            Cancel = new Button();
            btnRegister = new Button();
            itemsPanel = new Panel();
            lblName = new Label();
            lblCustomerText = new Label();
            btnDeleteOD = new Button();
            btnEditOD = new Button();
            btnCreateOD = new Button();
            createOrder_dateTimePicker = new DateTimePicker();
            customerComboBox = new ComboBox();
            panel2 = new Panel();
            OD_DataGrid = new DataGridView();
            buttonPanel.SuspendLayout();
            itemsPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OD_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(Cancel);
            buttonPanel.Controls.Add(btnRegister);
            buttonPanel.Controls.Add(itemsPanel);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(0, 0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(956, 246);
            buttonPanel.TabIndex = 0;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(616, 20);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(112, 34);
            Cancel.TabIndex = 3;
            Cancel.Text = "انصراف";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(786, 20);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "ثبت نهایی";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // itemsPanel
            // 
            itemsPanel.Controls.Add(lblName);
            itemsPanel.Controls.Add(lblCustomerText);
            itemsPanel.Controls.Add(btnDeleteOD);
            itemsPanel.Controls.Add(btnEditOD);
            itemsPanel.Controls.Add(btnCreateOD);
            itemsPanel.Controls.Add(createOrder_dateTimePicker);
            itemsPanel.Controls.Add(customerComboBox);
            itemsPanel.Dock = DockStyle.Bottom;
            itemsPanel.Location = new Point(0, 71);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(956, 175);
            itemsPanel.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(446, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 25);
            lblName.TabIndex = 6;
            lblName.Text = "تاریخ";
            // 
            // lblCustomerText
            // 
            lblCustomerText.AutoSize = true;
            lblCustomerText.Location = new Point(850, 39);
            lblCustomerText.Name = "lblCustomerText";
            lblCustomerText.Size = new Size(64, 25);
            lblCustomerText.TabIndex = 5;
            lblCustomerText.Text = "مشتری";
            // 
            // btnDeleteOD
            // 
            btnDeleteOD.Location = new Point(507, 134);
            btnDeleteOD.Name = "btnDeleteOD";
            btnDeleteOD.Size = new Size(112, 34);
            btnDeleteOD.TabIndex = 4;
            btnDeleteOD.Text = "حذف";
            btnDeleteOD.UseVisualStyleBackColor = true;
            btnDeleteOD.Click += btnDeleteOD_Click;
            // 
            // btnEditOD
            // 
            btnEditOD.Location = new Point(649, 134);
            btnEditOD.Name = "btnEditOD";
            btnEditOD.Size = new Size(112, 34);
            btnEditOD.TabIndex = 3;
            btnEditOD.Text = "ویرایش";
            btnEditOD.UseVisualStyleBackColor = true;
            btnEditOD.Click += btnEditOD_Click;
            // 
            // btnCreateOD
            // 
            btnCreateOD.Location = new Point(786, 134);
            btnCreateOD.Name = "btnCreateOD";
            btnCreateOD.Size = new Size(112, 34);
            btnCreateOD.TabIndex = 2;
            btnCreateOD.Text = "ایجاد";
            btnCreateOD.UseVisualStyleBackColor = true;
            btnCreateOD.Click += btnCreateOD_Click;
            // 
            // createOrder_dateTimePicker
            // 
            createOrder_dateTimePicker.Location = new Point(97, 42);
            createOrder_dateTimePicker.Name = "createOrder_dateTimePicker";
            createOrder_dateTimePicker.Size = new Size(300, 31);
            createOrder_dateTimePicker.TabIndex = 1;
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(625, 31);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(182, 33);
            customerComboBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(OD_DataGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 566);
            panel2.TabIndex = 0;
            // 
            // OD_DataGrid
            // 
            OD_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OD_DataGrid.Dock = DockStyle.Bottom;
            OD_DataGrid.Location = new Point(0, 245);
            OD_DataGrid.Name = "OD_DataGrid";
            OD_DataGrid.RowHeadersWidth = 62;
            OD_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OD_DataGrid.Size = new Size(956, 321);
            OD_DataGrid.TabIndex = 0;
            OD_DataGrid.CellContentClick += OD_DataGrid_CellContentClick;
            // 
            // Create_Edit_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 566);
            Controls.Add(buttonPanel);
            Controls.Add(panel2);
            Name = "Create_Edit_Order";
            Text = "Create_Edit_Order";
            Load += Create_Edit_Order_Load;
            buttonPanel.ResumeLayout(false);
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OD_DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private Panel itemsPanel;
        private Panel panel2;
        private Button Cancel;
        private Button btnRegister;
        private Button btnDeleteOD;
        private Button btnEditOD;
        private Button btnCreateOD;
        private DateTimePicker createOrder_dateTimePicker;
        private ComboBox customerComboBox;
        private Label lblName;
        private Label lblCustomerText;
        private DataGridView OD_DataGrid;
    }
}