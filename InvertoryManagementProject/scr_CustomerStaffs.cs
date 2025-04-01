using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvertoryManagementProject
{
    public partial class scr_CustomerStaffs : Form
    {
        int _companyID = 0;
        public scr_CustomerStaffs(int companyID)
        {
            InitializeComponent();
            _companyID = companyID;
        }


        void createStaffDGV()
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();

            col0.Name = "rowIndex";
            col0.HeaderText = "Sıra";
            col0.DataPropertyName = "rowIndex";
            col0.Width = 50;
            dgvStaffs.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "staffID";
            col1.HeaderText = "ID";
            col1.DataPropertyName = "staffID";
            col1.Width = 60;
            dgvStaffs.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "companyID";
            col2.HeaderText = "Firma ID";
            col2.DataPropertyName = "companyID";
            col2.Width = 60;
            col2.Visible = false;
            dgvStaffs.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            col3.Name = "companyName";
            col3.HeaderText = "Firma Adı";
            col3.DataPropertyName = "companyName";
            col3.Width = 150;
            dgvStaffs.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col4.Name = "staffName";
            col4.HeaderText = "Ad Soyad";
            col4.DataPropertyName = "staffName";
            col4.Width = 150;
            dgvStaffs.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();

            col5.Name = "staffMail";
            col5.HeaderText = "Mail";
            col5.DataPropertyName = "staffMail";
            col5.Width = 150;
            dgvStaffs.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

            col6.Name = "staffPhone";
            col6.HeaderText = "Telefon";
            col6.DataPropertyName = "staffPhone";
            col6.Width = 50;
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStaffs.Columns.Add(col6);

            dgvStaffs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvStaffs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void scr_CustomerStaffs_Load(object sender, EventArgs e)
        {
            createStaffDGV();
            fillCustomerStaffDGV();
        }

        void fillCustomerStaffDGV()
        {
            try
            {
                dgvStaffs.Rows.Clear();
                string query = $"SELECT companyStaff.ID, companyStaff.companyID, company.name AS companyName, companyStaff.name, companyStaff.mail, companyStaff.phone FROM companyStaff JOIN company ON company.ID = companyStaff.companyID WHERE companyID = {_companyID}";
                using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            object[] staffData = new object[6];
                            staffData[0] = reader["ID"];
                            staffData[1] = reader["companyID"];
                            staffData[2] = reader["companyName"];
                            staffData[3] = reader["name"];
                            staffData[4] = reader["mail"];
                            staffData[5] = reader["phone"];
                            dgvStaffs.Rows.Add("", staffData[0], staffData[1], staffData[2], staffData[3], staffData[4], staffData[5]);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                HelperMethods.WriteLog(trace, ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = new scr_CustomerStaffsAddEdit(0, _companyID).ShowDialog();

            if (result == DialogResult.OK)
            {
                fillCustomerStaffDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int _currentID = Convert.ToInt32(HelperMethods.getintvalue(dgvStaffs.CurrentRow.Cells["staffID"].Value));
            DialogResult result = new scr_CustomerStaffsAddEdit(_currentID, _companyID).ShowDialog();

            if (result == DialogResult.OK)
            {
                fillCustomerStaffDGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _currentID = Convert.ToInt32(HelperMethods.getintvalue(dgvStaffs.CurrentRow.Cells["staffID"].Value));
            SQL.DeleteFromDB("companyStaff", _currentID);
            fillCustomerStaffDGV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
