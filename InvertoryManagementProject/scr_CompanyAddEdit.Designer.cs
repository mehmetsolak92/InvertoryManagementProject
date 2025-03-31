namespace InvertoryManagementProject
{
    partial class scr_CompanyAddEdit
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
            lblCompanyName = new Label();
            lblCargoType = new Label();
            lblCompanyID = new Label();
            lblPaymentType = new Label();
            lblCity = new Label();
            lblDistrict = new Label();
            lblAdress = new Label();
            txtAddress = new TextBox();
            txtCompanyID = new TextBox();
            txtCompanyName = new TextBox();
            cmbCargoType = new ComboBox();
            cmbPaymentType = new ComboBox();
            cmbCity = new ComboBox();
            cmbDistrict = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCompanyName.ForeColor = Color.White;
            lblCompanyName.Location = new Point(52, 58);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(121, 31);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "Firma Adı:";
            lblCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCargoType
            // 
            lblCargoType.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCargoType.ForeColor = Color.White;
            lblCargoType.Location = new Point(52, 98);
            lblCargoType.Name = "lblCargoType";
            lblCargoType.Size = new Size(121, 31);
            lblCargoType.TabIndex = 1;
            lblCargoType.Text = "Kargo Tipi:";
            lblCargoType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCompanyID
            // 
            lblCompanyID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCompanyID.ForeColor = Color.White;
            lblCompanyID.Location = new Point(52, 18);
            lblCompanyID.Name = "lblCompanyID";
            lblCompanyID.Size = new Size(121, 31);
            lblCompanyID.TabIndex = 2;
            lblCompanyID.Text = "Firma ID:";
            lblCompanyID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPaymentType
            // 
            lblPaymentType.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPaymentType.ForeColor = Color.White;
            lblPaymentType.Location = new Point(52, 138);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(121, 31);
            lblPaymentType.TabIndex = 3;
            lblPaymentType.Text = "Ödeme Şekli:";
            lblPaymentType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            lblCity.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(52, 178);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(121, 31);
            lblCity.TabIndex = 4;
            lblCity.Text = "Şehir:";
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDistrict
            // 
            lblDistrict.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDistrict.ForeColor = Color.White;
            lblDistrict.Location = new Point(52, 218);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(121, 31);
            lblDistrict.TabIndex = 5;
            lblDistrict.Text = "İlçe:";
            lblDistrict.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdress
            // 
            lblAdress.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdress.ForeColor = Color.White;
            lblAdress.Location = new Point(52, 258);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(121, 31);
            lblAdress.TabIndex = 6;
            lblAdress.Text = "Adres:";
            lblAdress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAddress.Location = new Point(52, 292);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(275, 109);
            txtAddress.TabIndex = 7;
            // 
            // txtCompanyID
            // 
            txtCompanyID.Enabled = false;
            txtCompanyID.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCompanyID.Location = new Point(179, 18);
            txtCompanyID.Name = "txtCompanyID";
            txtCompanyID.Size = new Size(148, 23);
            txtCompanyID.TabIndex = 8;
            txtCompanyID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Calibri", 9F);
            txtCompanyName.Location = new Point(179, 58);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(148, 22);
            txtCompanyName.TabIndex = 9;
            // 
            // cmbCargoType
            // 
            cmbCargoType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargoType.Font = new Font("Calibri", 9F);
            cmbCargoType.FormattingEnabled = true;
            cmbCargoType.Location = new Point(179, 98);
            cmbCargoType.Name = "cmbCargoType";
            cmbCargoType.Size = new Size(148, 22);
            cmbCargoType.TabIndex = 10;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.Font = new Font("Calibri", 9F);
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(179, 138);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(148, 22);
            cmbPaymentType.TabIndex = 11;
            // 
            // cmbCity
            // 
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.Font = new Font("Calibri", 9F);
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(179, 178);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(148, 22);
            cmbCity.TabIndex = 12;
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            // 
            // cmbDistrict
            // 
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.Font = new Font("Calibri", 9F);
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Location = new Point(179, 218);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(148, 22);
            cmbDistrict.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(52, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 46);
            btnSave.TabIndex = 14;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(197, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "ÇIKIŞ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // scr_CompanyAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 35, 45);
            ClientSize = new Size(375, 477);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbDistrict);
            Controls.Add(cmbCity);
            Controls.Add(cmbPaymentType);
            Controls.Add(cmbCargoType);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCompanyID);
            Controls.Add(txtAddress);
            Controls.Add(lblAdress);
            Controls.Add(lblDistrict);
            Controls.Add(lblCity);
            Controls.Add(lblPaymentType);
            Controls.Add(lblCompanyID);
            Controls.Add(lblCargoType);
            Controls.Add(lblCompanyName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "scr_CompanyAddEdit";
            Text = "scr_CompanyAddEdit";
            Load += scr_CompanyAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompanyName;
        private Label lblCargoType;
        private Label lblCompanyID;
        private Label lblPaymentType;
        private Label lblCity;
        private Label lblDistrict;
        private Label lblAdress;
        private TextBox txtAddress;
        private TextBox txtCompanyID;
        private TextBox txtCompanyName;
        private ComboBox cmbCargoType;
        private ComboBox cmbPaymentType;
        private ComboBox cmbCity;
        private ComboBox cmbDistrict;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}