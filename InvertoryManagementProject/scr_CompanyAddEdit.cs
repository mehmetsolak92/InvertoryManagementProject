using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace InvertoryManagementProject
{
    public partial class scr_CompanyAddEdit : Form
    {
        int _companyID = 0;
        public scr_CompanyAddEdit(int companyID)
        {
            _companyID = companyID;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msgStr = string.Empty;
            if (_companyID == 0) msgStr = "Firma eklenecek. Emin misiniz?"; else msgStr = "Firma güncellenecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (ValidateFields())
                {
                    if (_companyID == 0) InsertDataToDB(); else UpdateCompanyData();

                    if (this.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void scr_CompanyAddEdit_Load(object sender, EventArgs e)
        {
            cmbCargoType.DataSource = GlobalVariables.cargoTypes;

            cmbPaymentType.DataSource = GlobalVariables.paymentTypes;

            cmbCity.DataSource = GlobalVariables.Cities;
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "PlateNumber";
            cmbCity.SelectedIndex = 0;

            cmbDistrict.Enabled = false;
            cmbDistrict.DataSource = GlobalVariables.Districts;
            cmbDistrict.DisplayMember = "Name";
            cmbDistrict.ValueMember = "ID";
            cmbDistrict.SelectedIndex = 0;

            if (_companyID == 0) txtCompanyID.Text = "Yeni Kayıt"; else ReadCompanyData(_companyID);

        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                errorProvider1.SetError(txtCompanyName, "Firma adı boş bırakılamaz!");
                isValid = false;
            }
            if (cmbCargoType.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbCargoType, "Kargo tipi seçiniz!");
                isValid = false;
            }
            if (cmbPaymentType.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbPaymentType, "Ödeme tipi seçiniz!");
                isValid = false;
            }

            if (cmbCity.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbCity, "Şehir seçiniz!");
                isValid = false;
            }

            if (cmbDistrict.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbDistrict, "İlçe seçiniz!");
                isValid = false;
            }

            return isValid;
        }

        void InsertDataToDB()
        {
            try
            {
                string query = $"INSERT INTO company (name, address, city, district, cargotype, paymenttype) VALUES ('{txtCompanyName.Text}', '{txtAddress.Text}', '{cmbCity.Text}', '{cmbDistrict.Text}', '{cmbCargoType.Text}', '{cmbPaymentType.Text}')";

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

        void UpdateCompanyData()
        {
            try
            {
                string query = $"UPDATE company SET name = '{txtCompanyName.Text}', address = '{txtAddress.Text}', city = '{cmbCity.Text}'" +
                $", district = '{cmbDistrict.Text}', cargotype = '{cmbCargoType.Text}', paymenttype = '{cmbPaymentType.Text}'" +
                $"  WHERE ID = {_companyID}";

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

        void ReadCompanyData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM company WHERE ID = {ID}";

                using SqlConnection con = new SqlConnection(GlobalVariables.SQLPath);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCompanyID.Text = Convert.ToString(reader["ID"]);
                            txtCompanyName.Text = Convert.ToString(reader["name"]);
                            txtAddress.Text = Convert.ToString(reader["address"]);
                            cmbCity.Text = Convert.ToString(reader["city"]);
                            cmbDistrict.Text = Convert.ToString(reader["district"]);
                            cmbCargoType.Text = Convert.ToString(reader["cargotype"]);
                            cmbPaymentType.Text = Convert.ToString(reader["paymenttype"]);
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
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex > 0)
            {
                City selectedCity = (City)cmbCity.SelectedItem;

                var filteredDistricts = GlobalVariables.Districts
                    .Where(d => d.CityPlateNumber == selectedCity.PlateNumber)
                    .ToList();
                cmbDistrict.DataSource = filteredDistricts;
                cmbDistrict.DisplayMember = "Name";
                cmbDistrict.ValueMember = "Id";
                cmbDistrict.SelectedIndex = 0;
                cmbDistrict.Enabled = true;
            }
            else
            {
                cmbDistrict.Enabled = false;
                cmbDistrict.DataSource = new List<District> { new District { Name = "Seçiniz", ID = -1 } };
                cmbDistrict.SelectedIndex = 0;
            }
        }
    }
}
