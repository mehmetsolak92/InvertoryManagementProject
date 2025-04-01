namespace InvertoryManagementProject
{
    partial class scr_Customers
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
            dgvCompanies = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).BeginInit();
            SuspendLayout();
            // 
            // dgvCompanies
            // 
            dgvCompanies.AllowUserToAddRows = false;
            dgvCompanies.AllowUserToDeleteRows = false;
            dgvCompanies.AllowUserToResizeColumns = false;
            dgvCompanies.AllowUserToResizeRows = false;
            dgvCompanies.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvCompanies.BorderStyle = BorderStyle.Fixed3D;
            dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompanies.Location = new Point(12, 77);
            dgvCompanies.MultiSelect = false;
            dgvCompanies.Name = "dgvCompanies";
            dgvCompanies.ReadOnly = true;
            dgvCompanies.RowHeadersVisible = false;
            dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompanies.Size = new Size(817, 668);
            dgvCompanies.TabIndex = 0;
            dgvCompanies.CellDoubleClick += dgvCompanies_CellDoubleClick;
            dgvCompanies.CellFormatting += dgvCompanies_CellFormatting;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdd.Image = Properties.Resources.Fasticon_Database_Data_add_32;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(841, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 62);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "YENİ KAYIT";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEdit.Image = Properties.Resources.Fasticon_Database_Data_edit_32;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(841, 145);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 62);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "DÜZENLE";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDelete.Image = Properties.Resources.Fasticon_Database_Data_delete_32;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(841, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // scr_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(978, 757);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCompanies);
            FormBorderStyle = FormBorderStyle.None;
            Name = "scr_Customers";
            Text = "scr_Customers";
            Load += scr_Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompanies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompanies;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}