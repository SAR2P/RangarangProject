namespace RangarangTest_UI
{
    partial class OrderAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelBtns = new Panel();
            btnExit = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            panelSearch = new Panel();
            lblsearch = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblPersonName = new Label();
            EndTimePicker = new DateTimePicker();
            StartdateTimePicker = new DateTimePicker();
            ComboPersonBox = new ComboBox();
            panelDataGrid = new Panel();
            DG_RelatedOrders = new DataGridView();
            PanelBtns.SuspendLayout();
            panelSearch.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_RelatedOrders).BeginInit();
            SuspendLayout();
            // 
            // PanelBtns
            // 
            PanelBtns.Controls.Add(btnExit);
            PanelBtns.Controls.Add(btnSearch);
            PanelBtns.Controls.Add(btnDelete);
            PanelBtns.Controls.Add(btnEdit);
            PanelBtns.Controls.Add(btnCreate);
            PanelBtns.Controls.Add(panelSearch);
            PanelBtns.Dock = DockStyle.Top;
            PanelBtns.Location = new Point(0, 0);
            PanelBtns.Name = "PanelBtns";
            PanelBtns.Size = new Size(1256, 222);
            PanelBtns.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(277, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(411, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(680, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(811, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "ایجاد";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(lblsearch);
            panelSearch.Controls.Add(lblEndDate);
            panelSearch.Controls.Add(lblStartDate);
            panelSearch.Controls.Add(lblPersonName);
            panelSearch.Controls.Add(EndTimePicker);
            panelSearch.Controls.Add(StartdateTimePicker);
            panelSearch.Controls.Add(ComboPersonBox);
            panelSearch.Dock = DockStyle.Bottom;
            panelSearch.Location = new Point(0, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1256, 142);
            panelSearch.TabIndex = 2;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(1148, 19);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(64, 25);
            lblsearch.TabIndex = 6;
            lblsearch.Text = "جستجو";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(380, 100);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(66, 25);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "تا تاریخ";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(864, 99);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(68, 25);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "از تاریخ";
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Location = new Point(990, 27);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(64, 25);
            lblPersonName.TabIndex = 3;
            lblPersonName.Text = "مشتری";
            // 
            // EndTimePicker
            // 
            EndTimePicker.Location = new Point(47, 93);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(300, 31);
            EndTimePicker.TabIndex = 2;
            // 
            // StartdateTimePicker
            // 
            StartdateTimePicker.CustomFormat = "MMM dd YYYY ";
            StartdateTimePicker.Location = new Point(516, 94);
            StartdateTimePicker.Name = "StartdateTimePicker";
            StartdateTimePicker.Size = new Size(300, 31);
            StartdateTimePicker.TabIndex = 1;
            StartdateTimePicker.Value = new DateTime(2024, 6, 15, 0, 0, 0, 0);
            // 
            // ComboPersonBox
            // 
            ComboPersonBox.FormattingEnabled = true;
            ComboPersonBox.Location = new Point(767, 19);
            ComboPersonBox.Name = "ComboPersonBox";
            ComboPersonBox.Size = new Size(182, 33);
            ComboPersonBox.TabIndex = 0;
            ComboPersonBox.SelectedIndexChanged += ComboPersonBox_SelectedIndexChanged;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(DG_RelatedOrders);
            panelDataGrid.Dock = DockStyle.Fill;
            panelDataGrid.Location = new Point(0, 222);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1256, 378);
            panelDataGrid.TabIndex = 1;
            // 
            // DG_RelatedOrders
            // 
            DG_RelatedOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_RelatedOrders.Dock = DockStyle.Fill;
            DG_RelatedOrders.Location = new Point(0, 0);
            DG_RelatedOrders.Name = "DG_RelatedOrders";
            DG_RelatedOrders.RowHeadersWidth = 62;
            DG_RelatedOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_RelatedOrders.Size = new Size(1256, 378);
            DG_RelatedOrders.TabIndex = 0;
            DG_RelatedOrders.CellContentClick += DG_RelatedOrders_CellContentClick;
            // 
            // OrderAppForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 600);
            Controls.Add(panelDataGrid);
            Controls.Add(PanelBtns);
            Name = "OrderAppForm";
            Text = "OrderApp";
            Load += OrderAppForm_Load;
            PanelBtns.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DG_RelatedOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBtns;
        private Button btnCreate;
        private Panel panelSearch;
        private DateTimePicker EndTimePicker;
        private DateTimePicker StartdateTimePicker;
        private ComboBox ComboPersonBox;
        private Panel panelDataGrid;
        private DataGridView DG_RelatedOrders;
        private Button btnExit;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblsearch;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblPersonName;
    }
}
