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
    public partial class scr_ProductsAddEdit : Form
    {
        int _productID = 0;
        public scr_ProductsAddEdit(int productID)
        {
            InitializeComponent();
            _productID = productID;
        }

        private void scr_ProductsAddEdit_Load(object sender, EventArgs e)
        {
            cmbSellingCurrency.DataSource = GlobalVariables.CurrencyUnits;
            cmbBuyingCurrency.DataSource = GlobalVariables.CurrencyUnits;
            cmbProductBrand.DataSource = GlobalVariables.Brands;
            cmbProductSupplier.DataSource = GlobalVariables.Suppliers;
            cmbProductUnit.DataSource = GlobalVariables.ProductUnits;
            cmbProductType.DataSource = GlobalVariables.ProductTypes;

            cmbProductCategory.DataSource = GlobalVariables.Categories;
            cmbProductCategory.DisplayMember = "Name";
            cmbProductCategory.ValueMember = "ID";
            cmbProductCategory.SelectedIndex = 0;

            cmbProductSubCategory.Enabled = false;
            cmbProductSubCategory.DataSource = GlobalVariables.Districts;
            cmbProductSubCategory.DisplayMember = "Name";
            cmbProductSubCategory.ValueMember = "ID";
            cmbProductSubCategory.SelectedIndex = 0;

            txtSellingPrice.Text = "0";
            txtBuyingPrice.Text = "0";

            if (_productID == 0)
            {
                txtProductID.Text = "Yeni Kayıt";
            }
            else
            {
                ReadProductData(_productID);
            }
        }

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductCategory.SelectedIndex > 0)
            {
                Category selectedCategory = (Category)cmbProductCategory.SelectedItem;

                var filteredSubCategories = GlobalVariables.SubCategories
                    .Where(d => d.CategoryID == selectedCategory.ID)
                    .ToList();
                cmbProductSubCategory.DataSource = filteredSubCategories;
                cmbProductSubCategory.DisplayMember = "Name";
                cmbProductSubCategory.ValueMember = "ID";
                cmbProductSubCategory.SelectedIndex = 0;
                cmbProductSubCategory.Enabled = true;
            }
            else
            {
                cmbProductSubCategory.Enabled = false;
                cmbProductSubCategory.DataSource = new List<SubCategory> { new SubCategory { Name = "Seçiniz", ID = -1 } };
                cmbProductSubCategory.SelectedIndex = 0;
            }
        }

        void ReadProductData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM product WHERE ID = {ID}";

                using SqlConnection con = new SqlConnection(GlobalVariables.SQLPath);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProductID.Text = Convert.ToString(reader["ID"]);
                            txtProductName.Text = Convert.ToString(reader["name"]);
                            txtProductCode.Text = Convert.ToString(reader["code"]);
                            txtSellingPrice.Text = Convert.ToString(reader["sellingprice"]);
                            cmbSellingCurrency.Text = Convert.ToString(reader["sellingcurrency"]);
                            txtBuyingPrice.Text = Convert.ToString(reader["buyingprice"]);
                            cmbBuyingCurrency.Text = Convert.ToString(reader["buyingcurrency"]);
                            cmbProductUnit.Text = Convert.ToString(reader["productunit"]);
                            cmbProductBrand.Text = Convert.ToString(reader["brand"]);
                            cmbProductSupplier.Text = Convert.ToString(reader["supplier"]);
                            cmbProductCategory.Text = Convert.ToString(reader["category"]);
                            cmbProductSubCategory.Text = Convert.ToString(reader["subcategory"]);
                            cmbProductType.Text = Convert.ToString(reader["producttype"]);
                            txtNote.Text = Convert.ToString(reader["note"]);

                        }
                        else
                        {
                            return;
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

        private void btnCodeRefresh_Click(object sender, EventArgs e)
        {
            GenerateProductCode();
        }

        private bool GenerateProductCode()
        {
            if (ValidateFields())
            {
                string str1 = cmbProductCategory.Text.Substring(0, 1);
                string str2 = cmbProductSubCategory.Text.Substring(0, 1);
                string str3 = cmbProductBrand.Text.Substring(0, 1);
                string str4 = cmbProductSupplier.Text.Substring(0, 1);

                if (str1 == " ") str1 = "0";
                if (str2 == " ") str2 = "0";
                if (str3 == " ") str3 = "0";
                if (str4 == " ") str4 = "0";
                string codeStr = "";
                if (_productID == 0)
                {
                    codeStr = str1 + str2 + str3 + str4 + "-" + SQL.FindMaxID("product").ToString("D4");
                }
                else
                {
                    codeStr = str1 + str2 + str3 + str4 + "-" + _productID.ToString("D4");
                }

                    txtProductCode.Text = codeStr;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Ürün adı boş bırakılamaz!");
                isValid = false;
            }

            if (cmbSellingCurrency.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbSellingCurrency, "Para birimi seçiniz!");
                isValid = false;
            }

            if (cmbBuyingCurrency.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbBuyingCurrency, "Para birimi seçiniz!");
                isValid = false;
            }

            if (cmbProductUnit.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductUnit, "Birim seçiniz!");
                isValid = false;
            }

            if (cmbProductBrand.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductBrand, "Marka seçiniz!");
                isValid = false;
            }

            if (cmbProductSupplier.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductUnit, "Tedarikçi seçiniz!");
                isValid = false;
            }

            if (cmbProductCategory.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductCategory, "Kategori seçiniz!");
                isValid = false;
            }

            if (cmbProductSubCategory.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductSubCategory, "Alt kategori seçiniz!");
                isValid = false;
            }

            if (cmbProductType.Text == "Seçiniz..")
            {
                errorProvider1.SetError(cmbProductType, "Ürün tipi seçiniz!");
                isValid = false;
            }

            return isValid;
        }


        void InsertDataToDB()
        {
            try
            {
                string query = $"INSERT INTO product (name, code, sellingprice, sellingcurrency, buyingprice, buyingcurrency, productunit, brand, supplier, category, subcategory, producttype, note)" +
                               $" VALUES ('{txtProductName.Text}', '{txtProductCode.Text}', '{txtSellingPrice.Text}', '{cmbSellingCurrency.Text}', '{txtBuyingPrice.Text}', '{cmbBuyingCurrency.Text}', " +
                               $"'{cmbProductUnit.Text}', '{cmbProductBrand.Text}', '{cmbProductSupplier.Text}', '{cmbProductCategory.Text}', '{cmbProductSubCategory.Text}', '{cmbProductType.Text}', " +
                               $"{txtNote.Text})";

                using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                HelperMethods.WriteLog(trace, ex);
            }
        }

        void UpdateProductData()
        {
            try
            {
                string query = $"UPDATE product SET name = '{txtProductName.Text}', code = '{txtProductCode.Text}', sellingprice = '{txtSellingPrice.Text}', " +
                               $"sellingcurrency = '{cmbSellingCurrency.Text}', buyingprice = '{txtBuyingPrice.Text}', buyingcurrency = '{cmbBuyingCurrency.Text}', " +
                               $"productunit = '{cmbProductUnit.Text}', brand = '{cmbProductBrand.Text}', supplier = '{cmbProductSupplier.Text}', " +
                               $"category = '{cmbProductCategory.Text}', subcategory = '{cmbProductSubCategory.Text}', producttype = '{cmbProductType.Text}', note = '{txtNote.Text}' " +
                               $"WHERE ID = {_productID} ";

                using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                HelperMethods.WriteLog(trace, ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msgStr = string.Empty;
            if (_productID == 0) msgStr = "Ürün eklenecek. Emin misiniz?"; else msgStr = "Ürün güncellenecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (GenerateProductCode())
                {
                    if (_productID == 0) InsertDataToDB(); else UpdateProductData();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }


            }
        }
    }
}
