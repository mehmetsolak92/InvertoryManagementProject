namespace InvertoryManagementProject
{
    partial class scr_CustomerStaffsAddEdit
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
            txtCompanyID = new TextBox();
            txtStaffID = new TextBox();
            lblStaffID = new Label();
            lblCompanyID = new Label();
            txtStaffName = new TextBox();
            lblStaffName = new Label();
            txtStaffMail = new TextBox();
            lblStaffMail = new Label();
            txtStaffPhone = new TextBox();
            lblStaffPhone = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCompanyID
            // 
            txtCompanyID.Enabled = false;
            txtCompanyID.Font = new Font("Calibri", 9F);
            txtCompanyID.Location = new Point(179, 58);
            txtCompanyID.Name = "txtCompanyID";
            txtCompanyID.Size = new Size(233, 22);
            txtCompanyID.TabIndex = 13;
            txtCompanyID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStaffID
            // 
            txtStaffID.Enabled = false;
            txtStaffID.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtStaffID.Location = new Point(179, 18);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(233, 23);
            txtStaffID.TabIndex = 12;
            txtStaffID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStaffID
            // 
            lblStaffID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStaffID.ForeColor = Color.White;
            lblStaffID.Location = new Point(52, 18);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(121, 31);
            lblStaffID.TabIndex = 11;
            lblStaffID.Text = "Personel ID:";
            lblStaffID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCompanyID
            // 
            lblCompanyID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCompanyID.ForeColor = Color.White;
            lblCompanyID.Location = new Point(52, 58);
            lblCompanyID.Name = "lblCompanyID";
            lblCompanyID.Size = new Size(121, 31);
            lblCompanyID.TabIndex = 10;
            lblCompanyID.Text = "Firma ID:";
            lblCompanyID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Calibri", 9F);
            txtStaffName.Location = new Point(179, 98);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(231, 22);
            txtStaffName.TabIndex = 15;
            // 
            // lblStaffName
            // 
            lblStaffName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStaffName.ForeColor = Color.White;
            lblStaffName.Location = new Point(52, 98);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(119, 31);
            lblStaffName.TabIndex = 14;
            lblStaffName.Text = "Ad Soyad:";
            lblStaffName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffMail
            // 
            txtStaffMail.Font = new Font("Calibri", 9F);
            txtStaffMail.Location = new Point(179, 138);
            txtStaffMail.Name = "txtStaffMail";
            txtStaffMail.Size = new Size(231, 22);
            txtStaffMail.TabIndex = 17;
            // 
            // lblStaffMail
            // 
            lblStaffMail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStaffMail.ForeColor = Color.White;
            lblStaffMail.Location = new Point(52, 138);
            lblStaffMail.Name = "lblStaffMail";
            lblStaffMail.Size = new Size(119, 31);
            lblStaffMail.TabIndex = 16;
            lblStaffMail.Text = "Mail:";
            lblStaffMail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Font = new Font("Calibri", 9F);
            txtStaffPhone.Location = new Point(179, 178);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(231, 22);
            txtStaffPhone.TabIndex = 19;
            // 
            // lblStaffPhone
            // 
            lblStaffPhone.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStaffPhone.ForeColor = Color.White;
            lblStaffPhone.Location = new Point(52, 178);
            lblStaffPhone.Name = "lblStaffPhone";
            lblStaffPhone.Size = new Size(119, 31);
            lblStaffPhone.TabIndex = 18;
            lblStaffPhone.Text = "Telefon:";
            lblStaffPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(257, 221);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "ÇIKIŞ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(112, 221);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 46);
            btnSave.TabIndex = 20;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // scr_CustomerStaffsAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 35, 45);
            ClientSize = new Size(492, 279);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtStaffPhone);
            Controls.Add(lblStaffPhone);
            Controls.Add(txtStaffMail);
            Controls.Add(lblStaffMail);
            Controls.Add(txtStaffName);
            Controls.Add(lblStaffName);
            Controls.Add(txtCompanyID);
            Controls.Add(txtStaffID);
            Controls.Add(lblStaffID);
            Controls.Add(lblCompanyID);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "scr_CustomerStaffsAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "scr_CustomerStaffsAddEdit";
            Load += scr_CustomerStaffsAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyID;
        private TextBox txtStaffID;
        private Label lblStaffID;
        private Label lblCompanyID;
        private TextBox txtStaffName;
        private Label lblStaffName;
        private TextBox txtStaffMail;
        private Label lblStaffMail;
        private TextBox txtStaffPhone;
        private Label lblStaffPhone;
        private Button btnCancel;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}