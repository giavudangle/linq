namespace LinqToEntities
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dtGridProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtGridReceipts = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cxActiveProduct = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductFind = new System.Windows.Forms.RichTextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.txtPriceReceipt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxReceiptCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxProductOrder = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGroupBy_ProductName = new System.Windows.Forms.Button();
            this.btnGroupBy_Category = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFilterNotActive = new System.Windows.Forms.RadioButton();
            this.btnFilterActive = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSortPriceDsc = new System.Windows.Forms.Button();
            this.btnSortPriceAsc = new System.Windows.Forms.Button();
            this.btnSortNameDsc = new System.Windows.Forms.Button();
            this.btnSortCategorytDsc = new System.Windows.Forms.Button();
            this.btnSortCategorytAsc = new System.Windows.Forms.Button();
            this.btnSortNameAsc = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridReceipts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridProducts
            // 
            this.dtGridProducts.AllowUserToAddRows = false;
            this.dtGridProducts.AllowUserToDeleteRows = false;
            this.dtGridProducts.AllowUserToOrderColumns = true;
            this.dtGridProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtGridProducts.Location = new System.Drawing.Point(-1, 57);
            this.dtGridProducts.Name = "dtGridProducts";
            this.dtGridProducts.ReadOnly = true;
            this.dtGridProducts.Size = new System.Drawing.Size(652, 318);
            this.dtGridProducts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductID";
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductCategory";
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductName";
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductPrice";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductStatus";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtGridReceipts
            // 
            this.dtGridReceipts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtGridReceipts.Location = new System.Drawing.Point(-1, 426);
            this.dtGridReceipts.Name = "dtGridReceipts";
            this.dtGridReceipts.Size = new System.Drawing.Size(652, 368);
            this.dtGridReceipts.TabIndex = 1;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReceiptID";
            this.Column6.HeaderText = "Receipt ID";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProductName";
            this.Column7.HeaderText = "Product Name ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProductAmount";
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ProductPrice";
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ReceiptDate";
            this.Column10.HeaderText = "Date";
            this.Column10.Name = "Column10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.cbProductName);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cxActiveProduct);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(671, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFORMATION";
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(139, 100);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(190, 21);
            this.cbProductName.TabIndex = 11;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(139, 62);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(190, 21);
            this.cbCategory.TabIndex = 10;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cxActiveProduct
            // 
            this.cxActiveProduct.AutoSize = true;
            this.cxActiveProduct.Location = new System.Drawing.Point(139, 176);
            this.cxActiveProduct.Name = "cxActiveProduct";
            this.cxActiveProduct.Size = new System.Drawing.Size(56, 17);
            this.cxActiveProduct.TabIndex = 9;
            this.cxActiveProduct.Text = "Active";
            this.cxActiveProduct.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(139, 25);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(190, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtProductFind);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.btnUpdateProduct);
            this.groupBox2.Controls.Add(this.btnCreateProduct);
            this.groupBox2.Location = new System.Drawing.Point(671, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT MANAGEMENT";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(319, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 39);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(319, 82);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 36);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "FIND PRODUCT";
            // 
            // txtProductFind
            // 
            this.txtProductFind.Location = new System.Drawing.Point(109, 82);
            this.txtProductFind.Name = "txtProductFind";
            this.txtProductFind.Size = new System.Drawing.Size(191, 36);
            this.txtProductFind.TabIndex = 4;
            this.txtProductFind.Text = "";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(213, 22);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(84, 39);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(106, 22);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(89, 39);
            this.btnUpdateProduct.TabIndex = 1;
            this.btnUpdateProduct.Text = "UPDATE";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(6, 22);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(94, 39);
            this.btnCreateProduct.TabIndex = 0;
            this.btnCreateProduct.Text = "CREATE";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnStatistic);
            this.groupBox3.Controls.Add(this.txtPriceReceipt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbxReceiptCategory);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numAmount);
            this.groupBox3.Controls.Add(this.cbxProductOrder);
            this.groupBox3.Controls.Add(this.btnAddOrder);
            this.groupBox3.Controls.Add(this.btnCal);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.txtReceiptID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(671, 584);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ORDER INFORMATION";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(277, 119);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(127, 35);
            this.btnStatistic.TabIndex = 28;
            this.btnStatistic.Text = "STATISTIC";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtPriceReceipt
            // 
            this.txtPriceReceipt.Location = new System.Drawing.Point(95, 149);
            this.txtPriceReceipt.Name = "txtPriceReceipt";
            this.txtPriceReceipt.ReadOnly = true;
            this.txtPriceReceipt.Size = new System.Drawing.Size(143, 20);
            this.txtPriceReceipt.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Price :";
            // 
            // cbxReceiptCategory
            // 
            this.cbxReceiptCategory.FormattingEnabled = true;
            this.cbxReceiptCategory.Location = new System.Drawing.Point(95, 54);
            this.cbxReceiptCategory.Name = "cbxReceiptCategory";
            this.cbxReceiptCategory.Size = new System.Drawing.Size(143, 21);
            this.cbxReceiptCategory.TabIndex = 26;
            this.cbxReceiptCategory.SelectedIndexChanged += new System.EventHandler(this.cbxReceiptCategory_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Category :";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(95, 119);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(143, 20);
            this.numAmount.TabIndex = 24;
            // 
            // cbxProductOrder
            // 
            this.cbxProductOrder.FormattingEnabled = true;
            this.cbxProductOrder.Location = new System.Drawing.Point(95, 86);
            this.cbxProductOrder.Name = "cbxProductOrder";
            this.cbxProductOrder.Size = new System.Drawing.Size(143, 21);
            this.cbxProductOrder.TabIndex = 23;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.Location = new System.Drawing.Point(277, 29);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(127, 33);
            this.btnAddOrder.TabIndex = 22;
            this.btnAddOrder.Text = "ADD ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(277, 72);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(127, 35);
            this.btnCal.TabIndex = 20;
            this.btnCal.Text = "CALCULATE";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(95, 174);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 19;
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(95, 29);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(143, 20);
            this.txtReceiptID.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Receipt ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.btnGroupBy_ProductName);
            this.groupBox4.Controls.Add(this.btnGroupBy_Category);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnFilterNotActive);
            this.groupBox4.Controls.Add(this.btnFilterActive);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnSortPriceDsc);
            this.groupBox4.Controls.Add(this.btnSortPriceAsc);
            this.groupBox4.Controls.Add(this.btnSortNameDsc);
            this.groupBox4.Controls.Add(this.btnSortCategorytDsc);
            this.groupBox4.Controls.Add(this.btnSortCategorytAsc);
            this.groupBox4.Controls.Add(this.btnSortNameAsc);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(671, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 171);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FILTER AND SORT";
            // 
            // btnGroupBy_ProductName
            // 
            this.btnGroupBy_ProductName.Location = new System.Drawing.Point(333, 137);
            this.btnGroupBy_ProductName.Name = "btnGroupBy_ProductName";
            this.btnGroupBy_ProductName.Size = new System.Drawing.Size(74, 26);
            this.btnGroupBy_ProductName.TabIndex = 28;
            this.btnGroupBy_ProductName.Text = "Group ";
            this.btnGroupBy_ProductName.UseVisualStyleBackColor = true;
            this.btnGroupBy_ProductName.Click += new System.EventHandler(this.btnGroupBy_ProductName_Click);
            // 
            // btnGroupBy_Category
            // 
            this.btnGroupBy_Category.Location = new System.Drawing.Point(121, 137);
            this.btnGroupBy_Category.Name = "btnGroupBy_Category";
            this.btnGroupBy_Category.Size = new System.Drawing.Size(74, 26);
            this.btnGroupBy_Category.TabIndex = 27;
            this.btnGroupBy_Category.Text = "Group ";
            this.btnGroupBy_Category.UseVisualStyleBackColor = true;
            this.btnGroupBy_Category.Click += new System.EventHandler(this.btnGroupBy_Category_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Group by Product Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Group by Category:";
            // 
            // btnFilterNotActive
            // 
            this.btnFilterNotActive.AutoSize = true;
            this.btnFilterNotActive.Location = new System.Drawing.Point(319, 99);
            this.btnFilterNotActive.Name = "btnFilterNotActive";
            this.btnFilterNotActive.Size = new System.Drawing.Size(72, 17);
            this.btnFilterNotActive.TabIndex = 24;
            this.btnFilterNotActive.TabStop = true;
            this.btnFilterNotActive.Text = "No Active";
            this.btnFilterNotActive.UseVisualStyleBackColor = true;
            this.btnFilterNotActive.CheckedChanged += new System.EventHandler(this.btnFilterNotActive_CheckedChanged);
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.AutoSize = true;
            this.btnFilterActive.Location = new System.Drawing.Point(319, 63);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(55, 17);
            this.btnFilterActive.TabIndex = 23;
            this.btnFilterActive.TabStop = true;
            this.btnFilterActive.Text = "Active";
            this.btnFilterActive.UseVisualStyleBackColor = true;
            this.btnFilterActive.CheckedChanged += new System.EventHandler(this.btnFilterActive_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(316, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Filter Status :";
            // 
            // btnSortPriceDsc
            // 
            this.btnSortPriceDsc.Location = new System.Drawing.Point(206, 99);
            this.btnSortPriceDsc.Name = "btnSortPriceDsc";
            this.btnSortPriceDsc.Size = new System.Drawing.Size(73, 26);
            this.btnSortPriceDsc.TabIndex = 21;
            this.btnSortPriceDsc.Text = "Descending";
            this.btnSortPriceDsc.UseVisualStyleBackColor = true;
            this.btnSortPriceDsc.Click += new System.EventHandler(this.btnSortPriceDsc_Click);
            // 
            // btnSortPriceAsc
            // 
            this.btnSortPriceAsc.Location = new System.Drawing.Point(121, 99);
            this.btnSortPriceAsc.Name = "btnSortPriceAsc";
            this.btnSortPriceAsc.Size = new System.Drawing.Size(74, 26);
            this.btnSortPriceAsc.TabIndex = 20;
            this.btnSortPriceAsc.Text = "Ascending";
            this.btnSortPriceAsc.UseVisualStyleBackColor = true;
            this.btnSortPriceAsc.Click += new System.EventHandler(this.btnSortPriceAsc_Click);
            // 
            // btnSortNameDsc
            // 
            this.btnSortNameDsc.Location = new System.Drawing.Point(206, 19);
            this.btnSortNameDsc.Name = "btnSortNameDsc";
            this.btnSortNameDsc.Size = new System.Drawing.Size(73, 26);
            this.btnSortNameDsc.TabIndex = 17;
            this.btnSortNameDsc.Text = "Descending";
            this.btnSortNameDsc.UseVisualStyleBackColor = true;
            this.btnSortNameDsc.Click += new System.EventHandler(this.btnSortNameDsc_Click);
            // 
            // btnSortCategorytDsc
            // 
            this.btnSortCategorytDsc.Location = new System.Drawing.Point(206, 63);
            this.btnSortCategorytDsc.Name = "btnSortCategorytDsc";
            this.btnSortCategorytDsc.Size = new System.Drawing.Size(73, 26);
            this.btnSortCategorytDsc.TabIndex = 16;
            this.btnSortCategorytDsc.Text = "Descending";
            this.btnSortCategorytDsc.UseVisualStyleBackColor = true;
            this.btnSortCategorytDsc.Click += new System.EventHandler(this.btnSortCategorytDsc_Click);
            // 
            // btnSortCategorytAsc
            // 
            this.btnSortCategorytAsc.Location = new System.Drawing.Point(121, 63);
            this.btnSortCategorytAsc.Name = "btnSortCategorytAsc";
            this.btnSortCategorytAsc.Size = new System.Drawing.Size(74, 26);
            this.btnSortCategorytAsc.TabIndex = 15;
            this.btnSortCategorytAsc.Text = "Ascending";
            this.btnSortCategorytAsc.UseVisualStyleBackColor = true;
            this.btnSortCategorytAsc.Click += new System.EventHandler(this.btnSortCategorytAsc_Click);
            // 
            // btnSortNameAsc
            // 
            this.btnSortNameAsc.Location = new System.Drawing.Point(121, 19);
            this.btnSortNameAsc.Name = "btnSortNameAsc";
            this.btnSortNameAsc.Size = new System.Drawing.Size(74, 26);
            this.btnSortNameAsc.TabIndex = 8;
            this.btnSortNameAsc.Text = "Ascending";
            this.btnSortNameAsc.UseVisualStyleBackColor = true;
            this.btnSortNameAsc.Click += new System.EventHandler(this.btnSortNameAsc_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sort Price :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Sort Category :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Sort Name :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(203, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(280, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(188, 389);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(267, 25);
            this.label20.TabIndex = 9;
            this.label20.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(277, 167);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 32);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 802);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridReceipts);
            this.Controls.Add(this.dtGridProducts);
            this.Name = "MainForm";
            this.Text = "MINI MART";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridReceipts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridProducts;
        private System.Windows.Forms.DataGridView dtGridReceipts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cxActiveProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.ComboBox cbxProductOrder;
        private System.Windows.Forms.ComboBox cbxReceiptCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPriceReceipt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtProductFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSortNameDsc;
        private System.Windows.Forms.Button btnSortCategorytDsc;
        private System.Windows.Forms.Button btnSortNameAsc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton btnFilterActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSortPriceDsc;
        private System.Windows.Forms.Button btnSortPriceAsc;
        private System.Windows.Forms.Button btnSortCategorytAsc;
        private System.Windows.Forms.RadioButton btnFilterNotActive;
        private System.Windows.Forms.Button btnGroupBy_ProductName;
        private System.Windows.Forms.Button btnGroupBy_Category;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnExport;
    }
}

