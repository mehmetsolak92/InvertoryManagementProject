namespace InvertoryManagementProject
{
    partial class scr_ProductsAddEdit
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            btnSave = new Button();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            lblProductID = new Label();
            lblProductName = new Label();
            txtProductCode = new TextBox();
            lblProductCode = new Label();
            btnCodeRefresh = new Button();
            txtSellingPrice = new TextBox();
            lblSellingPrice = new Label();
            cmbSellingCurrency = new ComboBox();
            cmbBuyingCurrency = new ComboBox();
            txtBuyingPrice = new TextBox();
            lblBuyingPrice = new Label();
            cmbProductUnit = new ComboBox();
            lblProductUnit = new Label();
            cmbProductBrand = new ComboBox();
            lblProductBrand = new Label();
            cmbProductSupplier = new ComboBox();
            lblProductSupplier = new Label();
            cmbProductSubCategory = new ComboBox();
            lblProductSubCategory = new Label();
            cmbProductCategory = new ComboBox();
            lblProductCategory = new Label();
            cmbProductType = new ComboBox();
            lblProductType = new Label();
            txtNote = new TextBox();
            lblNote = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(401, 411);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "ÇIKIŞ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(256, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 46);
            btnSave.TabIndex = 22;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Calibri", 9F);
            txtProductName.Location = new Point(179, 58);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(148, 22);
            txtProductName.TabIndex = 27;
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtProductID.Location = new Point(179, 18);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(148, 23);
            txtProductID.TabIndex = 26;
            txtProductID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductID
            // 
            lblProductID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductID.ForeColor = Color.White;
            lblProductID.Location = new Point(52, 18);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(121, 31);
            lblProductID.TabIndex = 25;
            lblProductID.Text = "Ürün ID:";
            lblProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(52, 58);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(121, 31);
            lblProductName.TabIndex = 24;
            lblProductName.Text = "Ürün Adı:";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductCode
            // 
            txtProductCode.Enabled = false;
            txtProductCode.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtProductCode.Location = new Point(179, 98);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(148, 23);
            txtProductCode.TabIndex = 29;
            // 
            // lblProductCode
            // 
            lblProductCode.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductCode.ForeColor = Color.White;
            lblProductCode.Location = new Point(52, 98);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(121, 31);
            lblProductCode.TabIndex = 28;
            lblProductCode.Text = "Ürün Kodu:";
            lblProductCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCodeRefresh
            // 
            btnCodeRefresh.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_view_refresh_16;
            btnCodeRefresh.Location = new Point(149, 98);
            btnCodeRefresh.Name = "btnCodeRefresh";
            btnCodeRefresh.Size = new Size(24, 24);
            btnCodeRefresh.TabIndex = 30;
            btnCodeRefresh.UseVisualStyleBackColor = true;
            btnCodeRefresh.Click += btnCodeRefresh_Click;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSellingPrice.Location = new Point(179, 138);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(71, 23);
            txtSellingPrice.TabIndex = 32;
            txtSellingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSellingPrice.ForeColor = Color.White;
            lblSellingPrice.Location = new Point(52, 138);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(121, 31);
            lblSellingPrice.TabIndex = 31;
            lblSellingPrice.Text = "Satış Fiyatı:";
            lblSellingPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSellingCurrency
            // 
            cmbSellingCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSellingCurrency.FormattingEnabled = true;
            cmbSellingCurrency.Location = new Point(257, 138);
            cmbSellingCurrency.Name = "cmbSellingCurrency";
            cmbSellingCurrency.Size = new Size(70, 23);
            cmbSellingCurrency.TabIndex = 33;
            // 
            // cmbBuyingCurrency
            // 
            cmbBuyingCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuyingCurrency.FormattingEnabled = true;
            cmbBuyingCurrency.Location = new Point(257, 178);
            cmbBuyingCurrency.Name = "cmbBuyingCurrency";
            cmbBuyingCurrency.Size = new Size(70, 23);
            cmbBuyingCurrency.TabIndex = 36;
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBuyingPrice.Location = new Point(179, 178);
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.Size = new Size(71, 23);
            txtBuyingPrice.TabIndex = 35;
            txtBuyingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuyingPrice
            // 
            lblBuyingPrice.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBuyingPrice.ForeColor = Color.White;
            lblBuyingPrice.Location = new Point(52, 178);
            lblBuyingPrice.Name = "lblBuyingPrice";
            lblBuyingPrice.Size = new Size(121, 31);
            lblBuyingPrice.TabIndex = 34;
            lblBuyingPrice.Text = "Alış Fiyatı:";
            lblBuyingPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductUnit
            // 
            cmbProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductUnit.FormattingEnabled = true;
            cmbProductUnit.Location = new Point(179, 218);
            cmbProductUnit.Name = "cmbProductUnit";
            cmbProductUnit.Size = new Size(148, 23);
            cmbProductUnit.TabIndex = 39;
            // 
            // lblProductUnit
            // 
            lblProductUnit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductUnit.ForeColor = Color.White;
            lblProductUnit.Location = new Point(52, 218);
            lblProductUnit.Name = "lblProductUnit";
            lblProductUnit.Size = new Size(121, 31);
            lblProductUnit.TabIndex = 37;
            lblProductUnit.Text = "Ürün Birimi:";
            lblProductUnit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductBrand
            // 
            cmbProductBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductBrand.FormattingEnabled = true;
            cmbProductBrand.Location = new Point(519, 18);
            cmbProductBrand.Name = "cmbProductBrand";
            cmbProductBrand.Size = new Size(148, 23);
            cmbProductBrand.TabIndex = 41;
            // 
            // lblProductBrand
            // 
            lblProductBrand.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductBrand.ForeColor = Color.White;
            lblProductBrand.Location = new Point(392, 18);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(121, 31);
            lblProductBrand.TabIndex = 40;
            lblProductBrand.Text = "Marka:";
            lblProductBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductSupplier
            // 
            cmbProductSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductSupplier.FormattingEnabled = true;
            cmbProductSupplier.Location = new Point(519, 58);
            cmbProductSupplier.Name = "cmbProductSupplier";
            cmbProductSupplier.Size = new Size(148, 23);
            cmbProductSupplier.TabIndex = 43;
            // 
            // lblProductSupplier
            // 
            lblProductSupplier.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductSupplier.ForeColor = Color.White;
            lblProductSupplier.Location = new Point(392, 58);
            lblProductSupplier.Name = "lblProductSupplier";
            lblProductSupplier.Size = new Size(121, 31);
            lblProductSupplier.TabIndex = 42;
            lblProductSupplier.Text = "Tedarikçi:";
            lblProductSupplier.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductSubCategory
            // 
            cmbProductSubCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductSubCategory.Enabled = false;
            cmbProductSubCategory.FormattingEnabled = true;
            cmbProductSubCategory.Location = new Point(519, 138);
            cmbProductSubCategory.Name = "cmbProductSubCategory";
            cmbProductSubCategory.Size = new Size(148, 23);
            cmbProductSubCategory.TabIndex = 47;
            // 
            // lblProductSubCategory
            // 
            lblProductSubCategory.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductSubCategory.ForeColor = Color.White;
            lblProductSubCategory.Location = new Point(392, 138);
            lblProductSubCategory.Name = "lblProductSubCategory";
            lblProductSubCategory.Size = new Size(121, 31);
            lblProductSubCategory.TabIndex = 46;
            lblProductSubCategory.Text = "Alt Kategori:";
            lblProductSubCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.Location = new Point(519, 98);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(148, 23);
            cmbProductCategory.TabIndex = 45;
            cmbProductCategory.SelectedIndexChanged += cmbProductCategory_SelectedIndexChanged;
            // 
            // lblProductCategory
            // 
            lblProductCategory.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductCategory.ForeColor = Color.White;
            lblProductCategory.Location = new Point(392, 98);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(121, 31);
            lblProductCategory.TabIndex = 44;
            lblProductCategory.Text = "Kategori:";
            lblProductCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductType
            // 
            cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(519, 178);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(148, 23);
            cmbProductType.TabIndex = 49;
            // 
            // lblProductType
            // 
            lblProductType.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductType.ForeColor = Color.White;
            lblProductType.Location = new Point(392, 178);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(121, 31);
            lblProductType.TabIndex = 48;
            lblProductType.Text = "Ürün Tipi:";
            lblProductType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(256, 290);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(275, 103);
            txtNote.TabIndex = 50;
            // 
            // lblNote
            // 
            lblNote.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNote.ForeColor = Color.White;
            lblNote.Location = new Point(257, 256);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(121, 31);
            lblNote.TabIndex = 51;
            lblNote.Text = "Not:";
            lblNote.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // scr_ProductsAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 35, 45);
            ClientSize = new Size(770, 469);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(cmbProductType);
            Controls.Add(lblProductType);
            Controls.Add(cmbProductSubCategory);
            Controls.Add(lblProductSubCategory);
            Controls.Add(cmbProductCategory);
            Controls.Add(lblProductCategory);
            Controls.Add(cmbProductSupplier);
            Controls.Add(lblProductSupplier);
            Controls.Add(cmbProductBrand);
            Controls.Add(lblProductBrand);
            Controls.Add(cmbProductUnit);
            Controls.Add(lblProductUnit);
            Controls.Add(cmbBuyingCurrency);
            Controls.Add(txtBuyingPrice);
            Controls.Add(lblBuyingPrice);
            Controls.Add(cmbSellingCurrency);
            Controls.Add(txtSellingPrice);
            Controls.Add(lblSellingPrice);
            Controls.Add(btnCodeRefresh);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lblProductID);
            Controls.Add(lblProductName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "scr_ProductsAddEdit";
            Text = "scr_ProductsAddEdit";
            Load += scr_ProductsAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label lblProductID;
        private Label lblProductName;
        private TextBox txtProductCode;
        private Label lblProductCode;
        private Button btnCodeRefresh;
        private TextBox txtSellingPrice;
        private Label lblSellingPrice;
        private ComboBox cmbSellingCurrency;
        private ComboBox cmbBuyingCurrency;
        private TextBox txtBuyingPrice;
        private Label lblBuyingPrice;
        private ComboBox cmbProductUnit;
        private Label lblProductUnit;
        private ComboBox cmbProductBrand;
        private Label lblProductBrand;
        private ComboBox cmbProductSupplier;
        private Label lblProductSupplier;
        private ComboBox cmbProductSubCategory;
        private Label lblProductSubCategory;
        private ComboBox cmbProductCategory;
        private Label lblProductCategory;
        private ComboBox cmbProductType;
        private Label lblProductType;
        private TextBox txtNote;
        private Label lblNote;
        private ErrorProvider errorProvider1;
    }
}