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

namespace InvertoryManagementProject
{
    public partial class scr_CompanyAddEdit : Form
    {
        public scr_CompanyAddEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void scr_CompanyAddEdit_Load(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                InsertDataToDB();
            }
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

        }
    }
}
