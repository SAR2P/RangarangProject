namespace UI
{
    partial class Orde
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
            OnlydataGridView = new DataGridView();
            buttonsPanel = new Panel();
            btnExit = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            panelSearch = new Panel();
            lblPersonName = new Label();
            lblEnd = new Label();
            lblStart = new Label();
            startTimeDatePicker = new DateTimePicker();
            endTimeDatePicker = new DateTimePicker();
            textBox1 = new TextBox();
            lblSearchText = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)OnlydataGridView).BeginInit();
            buttonsPanel.SuspendLayout();
            panelSearch.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // OnlydataGridView
            // 
            OnlydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OnlydataGridView.Dock = DockStyle.Fill;
            OnlydataGridView.Location = new Point(0, 0);
            OnlydataGridView.Name = "OnlydataGridView";
            OnlydataGridView.RowHeadersWidth = 62;
            OnlydataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OnlydataGridView.Size = new Size(1320, 370);
            OnlydataGridView.TabIndex = 0;
            OnlydataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnExit);
            buttonsPanel.Controls.Add(btnSearch);
            buttonsPanel.Controls.Add(btnDelete);
            buttonsPanel.Controls.Add(btnEdit);
            buttonsPanel.Controls.Add(btnCreate);
            buttonsPanel.Dock = DockStyle.Top;
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(1320, 77);
            buttonsPanel.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(599, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button5_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(736, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button4_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(872, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button3_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1010, 30);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1143, 30);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "ایجاد";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button1_Click;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(lblPersonName);
            panelSearch.Controls.Add(lblEnd);
            panelSearch.Controls.Add(lblStart);
            panelSearch.Controls.Add(startTimeDatePicker);
            panelSearch.Controls.Add(endTimeDatePicker);
            panelSearch.Controls.Add(textBox1);
            panelSearch.Controls.Add(lblSearchText);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(0, 77);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1320, 550);
            panelSearch.TabIndex = 2;
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Location = new Point(1174, 52);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(91, 25);
            lblPersonName.TabIndex = 8;
            lblPersonName.Text = "نام مشتری";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(599, 132);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(66, 25);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "تا تاریخ";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(1078, 127);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(68, 25);
            lblStart.TabIndex = 6;
            lblStart.Text = "از تاریخ";
            // 
            // startTimeDatePicker
            // 
            startTimeDatePicker.Location = new Point(761, 127);
            startTimeDatePicker.Name = "startTimeDatePicker";
            startTimeDatePicker.Size = new Size(300, 31);
            startTimeDatePicker.TabIndex = 5;
            // 
            // endTimeDatePicker
            // 
            endTimeDatePicker.Location = new Point(275, 127);
            endTimeDatePicker.Name = "endTimeDatePicker";
            endTimeDatePicker.Size = new Size(300, 31);
            endTimeDatePicker.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(913, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(209, 34);
            textBox1.TabIndex = 1;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Location = new Point(1244, 3);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(64, 25);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "جستجو";
            // 
            // panel3
            // 
            panel3.Controls.Add(OnlydataGridView);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(1320, 370);
            panel3.TabIndex = 3;
            // 
            // Orde
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 627);
            Controls.Add(panel3);
            Controls.Add(panelSearch);
            Controls.Add(buttonsPanel);
            Name = "Orde";
            Text = "Order App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)OnlydataGridView).EndInit();
            buttonsPanel.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OnlydataGridView;
        private Panel buttonsPanel;
        private Panel panelSearch;
        private Panel panel3;
        private Button btnExit;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCreate;
        private Label lblPersonName;
        private Label lblEnd;
        private Label lblStart;
        private DateTimePicker startTimeDatePicker;
        private DateTimePicker endTimeDatePicker;
        private TextBox textBox1;
        private Label lblSearchText;
    }
}
