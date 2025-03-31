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
            if (_companyID == 0) msgStr = "Kullanıcı eklenecek. Emin misiniz?"; else msgStr = "Kullanıcı güncellenecek. Emin misiniz?";
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

            txtCompanyID.Text = SQL.FindMaxID("company").ToString();
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


            this.DialogResult = DialogResult.OK;
        }

        void UpdateCompanyData()
        {

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
