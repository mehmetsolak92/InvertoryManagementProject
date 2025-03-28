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

            col4.Name = "companyCargoType";
            col4.HeaderText = "Kargo Şekli";
            col4.DataPropertyName = "companyCargoType";
            col4.Width = 90;
            dgvCompanies.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();

            col5.Name = "companyPaymentType";
            col5.HeaderText = "Ödeme Şekli";
            col5.DataPropertyName = "Flotte";
            col5.Width = 100;
            dgvCompanies.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

            col6.Name = "companyAddress";
            col6.HeaderText = "Adres";
            col6.DataPropertyName = "companyAddress";
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompanies.Columns.Add(col6);

            dgvCompanies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void fillCustomersDGV()
        {
            dgvCompanies.Rows.Clear();
            int rowIndex = 1;
            string sqlQuery = SQL.SelectAllQueryGenerator("company"); 
            using (SqlConnection sqlCon = new SqlConnection(GlobalVariables.SQLPath))
            {
                sqlCon.Open();
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlCon))
                {
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        object[] companyData = new object[6];
                        companyData[0] = sqlReader["ID"];
                        companyData[1] = sqlReader["name"];
                        companyData[2] = sqlReader["city"];
                        companyData[3] = sqlReader["cargotype"];
                        companyData[4] = sqlReader["paymenttype"];
                        companyData[5] = sqlReader["address"];
                        dgvCompanies.Rows.Add(rowIndex, companyData[0], companyData[1], companyData[2], companyData[3], companyData[4], companyData[5]);
                        rowIndex++;
                    }
                }
            }
        }
    }
}
