namespace InvertoryManagementProject
{
    partial class scr_CustomerStaffs
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
            dgvStaffs = new DataGridView();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).BeginInit();
            SuspendLayout();
            // 
            // dgvStaffs
            // 
            dgvStaffs.AllowUserToAddRows = false;
            dgvStaffs.AllowUserToDeleteRows = false;
            dgvStaffs.AllowUserToResizeColumns = false;
            dgvStaffs.AllowUserToResizeRows = false;
            dgvStaffs.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvStaffs.BorderStyle = BorderStyle.Fixed3D;
            dgvStaffs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffs.Location = new Point(12, 77);
            dgvStaffs.MultiSelect = false;
            dgvStaffs.Name = "dgvStaffs";
            dgvStaffs.ReadOnly = true;
            dgvStaffs.RowHeadersVisible = false;
            dgvStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.Size = new Size(795, 431);
            dgvStaffs.TabIndex = 1;
            dgvStaffs.CellFormatting += dgvStaffs_CellFormatting;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCancel.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(471, 536);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "ÇIKIŞ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(326, 536);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 46);
            btnSave.TabIndex = 16;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDelete.Image = Properties.Resources.Fasticon_Database_Data_delete_32;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(813, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 62);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEdit.Image = Properties.Resources.Fasticon_Database_Data_edit_32;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(813, 145);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 62);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "DÜZENLE";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdd.Image = Properties.Resources.Fasticon_Database_Data_add_32;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(813, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 62);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // scr_CustomerStaffs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 35, 45);
            ClientSize = new Size(950, 594);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvStaffs);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "scr_CustomerStaffs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "scr_CustomerStaffs";
            Load += scr_CustomerStaffs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStaffs;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}