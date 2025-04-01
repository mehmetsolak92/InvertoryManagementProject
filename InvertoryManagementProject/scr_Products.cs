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
    public partial class scr_Products : Form
    {
        public scr_Products()
        {
            InitializeComponent();
        }

        private void scr_Products_Load(object sender, EventArgs e)
        {
            createProductsDGV();
            fillProductsDGV();
        }

        void createProductsDGV()
        {
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();

            col0.Name = "rowIndex";
            col0.HeaderText = "Sıra";
            col0.DataPropertyName = "rowIndex";
            col0.Width = 50;
            dgvProducts.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "productID";
            col1.HeaderText = "ID";
            col1.DataPropertyName = "productID";
            col1.Width = 60;
            dgvProducts.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "productName";
            col2.HeaderText = "Ürün Adı";
            col2.DataPropertyName = "productName";
            col2.Width = 135;
            dgvProducts.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            col3.Name = "productCode";
            col3.HeaderText = "Ürün Kodu";
            col3.DataPropertyName = "productCode";
            col3.Width = 135;
            dgvProducts.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col4.Name = "sellingPrice";
            col4.HeaderText = "Satış Fiyatı";
            col4.DataPropertyName = "sellingPrice";
            col4.Width = 100;
            dgvProducts.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();

            col5.Name = "sellingCurrency";
            col5.HeaderText = "Birim";
            col5.DataPropertyName = "sellingCurrency";
            col5.Width = 70;
            dgvProducts.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

            col6.Name = "buyingPrice";
            col6.HeaderText = "Alış Fiyatı";
            col6.DataPropertyName = "Flotte";
            col6.Width = 100;
            dgvProducts.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();

            col7.Name = "buyingCurrency";
            col7.HeaderText = "Birim";
            col7.DataPropertyName = "buyingCurrency";
            col7.Width = 100;
            dgvProducts.Columns.Add(col7);

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();

            col8.Name = "buyingCurrency";
            col8.HeaderText = "Birim";
            col8.DataPropertyName = "buyingCurrency";
            col8.Width = 100;
            dgvProducts.Columns.Add(col8);

            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();

            col9.Name = "brand";
            col9.HeaderText = "Marka";
            col9.DataPropertyName = "brand";
            col9.Width = 100;
            dgvProducts.Columns.Add(col9);

            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();

            col10.Name = "supplier";
            col10.HeaderText = "Tedarikçi";
            col10.DataPropertyName = "supplier";
            col10.Width = 100;
            dgvProducts.Columns.Add(col10);


            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();

            col11.Name = "category";
            col11.HeaderText = "Kategori";
            col11.DataPropertyName = "category";
            col11.Width = 100;
            dgvProducts.Columns.Add(col11);

            DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();

            col12.Name = "subCategory";
            col12.HeaderText = "Alt Kategori";
            col12.DataPropertyName = "subCategory";
            col12.Width = 100;
            dgvProducts.Columns.Add(col12);

            DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();

            col13.Name = "productType";
            col13.HeaderText = "Ürün Tipi";
            col13.DataPropertyName = "productType";
            col13.Width = 100;
            dgvProducts.Columns.Add(col13);

            DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();

            col14.Name = "note";
            col14.HeaderText = "Not";
            col14.DataPropertyName = "note";
            col14.Width = 100;
            dgvProducts.Columns.Add(col14);

            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void fillProductsDGV()
        {
            dgvProducts.Rows.Clear();
            string query = SQL.SelectAllQueryGenerator("product");
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        object[] productData = new object[14];
                        productData[0] = reader["ID"];
                        productData[1] = reader["name"];
                        productData[2] = reader["code"];
                        productData[3] = reader["sellingprice"];
                        productData[4] = reader["sellingcurrency"];
                        productData[5] = reader["buyingprice"];
                        productData[6] = reader["buyingcurrency"];
                        productData[7] = reader["productunit"];
                        productData[8] = reader["brand"];
                        productData[9] = reader["supplier"];
                        productData[10] = reader["category"];
                        productData[11] = reader["subcategory"];
                        productData[12] = reader["producttype"];
                        productData[13] = reader["note"];
                        dgvProducts.Rows.Add("", productData[0], productData[1], productData[2], productData[3], productData[4], productData[5],
                                                 productData[6], productData[7], productData[8], productData[9], productData[10], productData[11],
                                                 productData[12], productData[13]);

                    }
                }
            }
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = new scr_ProductsAddEdit(0).ShowDialog();

            if (result == DialogResult.OK)
            {
                fillProductsDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int _currentID = Convert.ToInt32(HelperMethods.getintvalue(dgvProducts.CurrentRow.Cells["productID"].Value));
            DialogResult result = new scr_ProductsAddEdit(_currentID).ShowDialog();

            if (result == DialogResult.OK)
            {
                fillProductsDGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _currentID = Convert.ToInt32(HelperMethods.getintvalue(dgvProducts.CurrentRow.Cells["productID"].Value));
            SQL.DeleteFromDB("product", _currentID);
            fillProductsDGV();
        }
    }
}
