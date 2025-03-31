using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class scr_Customers : Form
    {
        public scr_Customers()
        {
            InitializeComponent();
        }

        private void scr_Customers_Load(object sender, EventArgs e)
        {
            createCompanyDGV();
            fillCustomersDGV();
        }

        void createCompanyDGV()
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();

            col0.Name = "rowIndex";
            col0.HeaderText = "Sıra";
            col0.DataPropertyName = "rowIndex";
            col0.Width = 50;
            dgvCompanies.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "companyID";
            col1.HeaderText = "Firma ID";
            col1.DataPropertyName = "companyID";
            col1.Width = 60;
            dgvCompanies.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "companyName";
            col2.HeaderText = "Firma Adı";
            col2.DataPropertyName = "companyName";
            col2.Width = 135;
            dgvCompanies.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            col3.Name = "companyCity";
            col3.HeaderText = "Şehir";
            col3.DataPropertyName = "companyCity";
            col3.Width = 70;
            dgvCompanies.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col4.Name = "companyDistrict";
            col4.HeaderText = "İlçe";
            col4.DataPropertyName = "companyDistrict";
            col4.Width = 70;
            dgvCompanies.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();

            col5.Name = "companyCargoType";
            col5.HeaderText = "Kargo Şekli";
            col5.DataPropertyName = "companyCargoType";
            col5.Width = 90;
            dgvCompanies.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

            col6.Name = "companyPaymentType";
            col6.HeaderText = "Ödeme Şekli";
            col6.DataPropertyName = "Flotte";
            col6.Width = 100;
            dgvCompanies.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();

            col7.Name = "companyAddress";
            col7.HeaderText = "Adres";
            col7.DataPropertyName = "companyAddress";
            col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompanies.Columns.Add(col7);

            dgvCompanies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void fillCustomersDGV()
        {
            dgvCompanies.Rows.Clear();
            string query = SQL.SelectAllQueryGenerator("company");
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        object[] companyData = new object[7];
                        companyData[0] = reader["ID"];
                        companyData[1] = reader["name"];
                        companyData[2] = reader["city"];
                        companyData[3] = reader["district"];
                        companyData[4] = reader["cargotype"];
                        companyData[5] = reader["paymenttype"];
                        companyData[6] = reader["address"];
                        dgvCompanies.Rows.Add("", companyData[0], companyData[1], companyData[2], companyData[3], companyData[4], companyData[5], companyData[6]);

                    }
                }
            }
        }

        private void dgvCompanies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = new scr_CompanyAddEdit(0).ShowDialog();

            if (result == DialogResult.OK)
            {
                fillCustomersDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
