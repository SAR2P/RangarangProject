namespace RangarangTest_UI
{
    partial class Create_Edit_OrderDetails
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
            btnSave = new Button();
            btnCancel = new Button();
            productComboBox = new ComboBox();
            txtPPrice = new TextBox();
            txtTotalPrice = new TextBox();
            lblPName = new Label();
            lblPrice = new Label();
            lblCount = new Label();
            lblPTotalPrice = new Label();
            lblRial = new Label();
            productNumericBox = new NumericUpDown();
            lbltotalrial = new Label();
            ((System.ComponentModel.ISupportInitialize)productNumericBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(539, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(362, 24);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "انصراف";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(307, 126);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(182, 33);
            productComboBox.TabIndex = 2;
            productComboBox.SelectedIndexChanged += productComboBox_SelectedIndexChanged;
            // 
            // txtPPrice
            // 
            txtPPrice.Location = new Point(307, 193);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(182, 31);
            txtPPrice.TabIndex = 3;
            txtPPrice.TextChanged += txtPPrice_TextChanged;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(307, 325);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(182, 31);
            txtTotalPrice.TabIndex = 5;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(595, 126);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(41, 25);
            lblPName.TabIndex = 6;
            lblPName.Text = "کالا:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(561, 193);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(98, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "قیمت واحد:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(595, 267);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(56, 25);
            lblCount.TabIndex = 8;
            lblCount.Text = "تعداد:";
            // 
            // lblPTotalPrice
            // 
            lblPTotalPrice.AutoSize = true;
            lblPTotalPrice.Location = new Point(584, 331);
            lblPTotalPrice.Name = "lblPTotalPrice";
            lblPTotalPrice.Size = new Size(75, 25);
            lblPTotalPrice.TabIndex = 9;
            lblPTotalPrice.Text = "جمع کل:";
            // 
            // lblRial
            // 
            lblRial.AutoSize = true;
            lblRial.Location = new Point(238, 193);
            lblRial.Name = "lblRial";
            lblRial.Size = new Size(45, 25);
            lblRial.TabIndex = 10;
            lblRial.Text = "ریال";
            // 
            // productNumericBox
            // 
            productNumericBox.Location = new Point(307, 261);
            productNumericBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            productNumericBox.Name = "productNumericBox";
            productNumericBox.Size = new Size(182, 31);
            productNumericBox.TabIndex = 11;
            productNumericBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            productNumericBox.ValueChanged += productNumericBox_ValueChanged;
            // 
            // lbltotalrial
            // 
            lbltotalrial.AutoSize = true;
            lbltotalrial.Location = new Point(238, 331);
            lbltotalrial.Name = "lbltotalrial";
            lbltotalrial.Size = new Size(45, 25);
            lbltotalrial.TabIndex = 10;
            lbltotalrial.Text = "ریال";
            // 
            // Create_Edit_OrderDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 476);
            Controls.Add(productNumericBox);
            Controls.Add(lbltotalrial);
            Controls.Add(lblRial);
            Controls.Add(lblPTotalPrice);
            Controls.Add(lblCount);
            Controls.Add(lblPrice);
            Controls.Add(lblPName);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtPPrice);
            Controls.Add(productComboBox);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "Create_Edit_OrderDetails";
            RightToLeft = RightToLeft.Yes;
            Text = "Create_Edit_OrderDetails";
            Load += Create_Edit_OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)productNumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private ComboBox productComboBox;
        private TextBox txtPPrice;
        private TextBox textBox2;
        private TextBox txtTotalPrice;
        private Label lblPName;
        private Label lblPrice;
        private Label lblCount;
        private Label lblPTotalPrice;
        private Label lblRial;
        private NumericUpDown productNumericBox;
        private Label lbltotalrial;
    }
}