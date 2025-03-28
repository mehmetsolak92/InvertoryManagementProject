namespace InvertoryManagementProject
{
    partial class scr_Main
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
            pnlSide1 = new Panel();
            pnlNav = new Panel();
            btnSettings = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            btnHomePage = new Button();
            pnlSide2 = new Panel();
            lblActiveUser = new Label();
            lblUser = new Label();
            pbUser = new PictureBox();
            pnlFormLoader = new Panel();
            pnlSide1.SuspendLayout();
            pnlSide2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // pnlSide1
            // 
            pnlSide1.BackColor = Color.FromArgb(24, 30, 54);
            pnlSide1.Controls.Add(pnlNav);
            pnlSide1.Controls.Add(btnSettings);
            pnlSide1.Controls.Add(btnCustomers);
            pnlSide1.Controls.Add(btnOrders);
            pnlSide1.Controls.Add(btnProducts);
            pnlSide1.Controls.Add(btnHomePage);
            pnlSide1.Controls.Add(pnlSide2);
            pnlSide1.Dock = DockStyle.Left;
            pnlSide1.Location = new Point(0, 0);
            pnlSide1.Name = "pnlSide1";
            pnlSide1.Size = new Size(203, 757);
            pnlSide1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(3, 468);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 65);
            pnlNav.TabIndex = 6;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.Graphicloads_100_Flat_2_Settings_3_32;
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(3, 696);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(197, 58);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Ayarlar";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCustomers.ForeColor = Color.FromArgb(0, 126, 249);
            btnCustomers.Image = Properties.Resources.Graphicloads_100_Flat_Home_32;
            btnCustomers.ImageAlign = ContentAlignment.MiddleRight;
            btnCustomers.Location = new Point(3, 355);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(197, 58);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            btnCustomers.Leave += btnCustomers_Leave;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOrders.ForeColor = Color.FromArgb(0, 126, 249);
            btnOrders.Image = Properties.Resources.Graphicloads_100_Flat_Bucket_32;
            btnOrders.ImageAlign = ContentAlignment.MiddleRight;
            btnOrders.Location = new Point(3, 227);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(197, 58);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Siparişler";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            btnOrders.Leave += btnOrders_Leave;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnProducts.ForeColor = Color.FromArgb(0, 126, 249);
            btnProducts.Image = Properties.Resources.Graphicloads_100_Flat_2_File_folder_32;
            btnProducts.ImageAlign = ContentAlignment.MiddleRight;
            btnProducts.Location = new Point(3, 291);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(197, 58);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Ürünler";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            btnProducts.Leave += btnProducts_Leave;
            // 
            // btnHomePage
            // 
            btnHomePage.FlatAppearance.BorderSize = 0;
            btnHomePage.FlatStyle = FlatStyle.Flat;
            btnHomePage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHomePage.ForeColor = Color.FromArgb(0, 126, 249);
            btnHomePage.Image = Properties.Resources.Graphicloads_100_Flat_Home_32;
            btnHomePage.ImageAlign = ContentAlignment.MiddleRight;
            btnHomePage.Location = new Point(3, 163);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(197, 58);
            btnHomePage.TabIndex = 1;
            btnHomePage.Text = "Ana Sayfa";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            btnHomePage.Leave += btnHomePage_Leave;
            // 
            // pnlSide2
            // 
            pnlSide2.Controls.Add(lblActiveUser);
            pnlSide2.Controls.Add(lblUser);
            pnlSide2.Controls.Add(pbUser);
            pnlSide2.Location = new Point(0, 0);
            pnlSide2.Name = "pnlSide2";
            pnlSide2.Size = new Size(203, 157);
            pnlSide2.TabIndex = 0;
            // 
            // lblActiveUser
            // 
            lblActiveUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblActiveUser.ForeColor = SystemColors.ControlLight;
            lblActiveUser.Location = new Point(3, 122);
            lblActiveUser.Name = "lblActiveUser";
            lblActiveUser.Size = new Size(197, 23);
            lblActiveUser.TabIndex = 2;
            lblActiveUser.Text = "Aktif Kullanıcı";
            lblActiveUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUser.ForeColor = Color.FromArgb(0, 126, 249);
            lblUser.Location = new Point(38, 95);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(133, 27);
            lblUser.TabIndex = 1;
            lblUser.Text = "Kullanıcı Adı";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.Graphicloads_Flat_Finance_Person_48;
            pbUser.Location = new Point(68, 12);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(71, 71);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.BackColor = Color.FromArgb(46, 51, 73);
            pnlFormLoader.Location = new Point(203, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(978, 757);
            pnlFormLoader.TabIndex = 1;
            // 
            // scr_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 757);
            Controls.Add(pnlFormLoader);
            Controls.Add(pnlSide1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "scr_Main";
            Text = "Invertory Management System";
            Load += scr_Main_Load;
            pnlSide1.ResumeLayout(false);
            pnlSide2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide1;
        private Panel pnlFormLoader;
        private Panel pnlSide2;
        private PictureBox pbUser;
        private Label lblUser;
        private Label lblActiveUser;
        private Button btnHomePage;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnProducts;
        private Button btnSettings;
        private Panel pnlNav;
    }
}
