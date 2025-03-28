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
            // 
            // scr_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(978, 757);
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
    }
}