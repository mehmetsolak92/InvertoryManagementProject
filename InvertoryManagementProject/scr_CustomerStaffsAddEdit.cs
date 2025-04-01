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
    public partial class scr_CustomerStaffsAddEdit : Form
    {
        int _staffID = 0;
        int _companyID = 0;
        public scr_CustomerStaffsAddEdit(int staffID, int companyID)
        {
            InitializeComponent();
            _staffID = staffID;
            _companyID = companyID;
        }

        private void scr_CustomerStaffsAddEdit_Load(object sender, EventArgs e)
        {
            if (_staffID == 0) txtStaffID.Text = "Yeni Kayıt"; else ReadStaffData(_staffID);
            txtCompanyID.Text = _companyID.ToString();
        }
        void ReadStaffData(int ID)
        {
            try
            {
                string query = $"SELECT * FROM companyStaff WHERE ID = {ID}";

                using SqlConnection con = new SqlConnection(GlobalVariables.SQLPath);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtStaffID.Text = Convert.ToString(reader["ID"]);
                            txtCompanyID.Text = Convert.ToString(reader["companyID"]);
                            txtStaffName.Text = Convert.ToString(reader["name"]);
                            txtStaffMail.Text = Convert.ToString(reader["mail"]);
                            txtStaffPhone.Text = Convert.ToString(reader["phone"]);
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
        void InsertDataToDB()
        {


            string query = $"INSERT INTO companyStaff (companyID, name, mail, phone) VALUES ('{txtCompanyID.Text}', '{txtStaffName.Text}', '{txtStaffMail.Text}', '{txtStaffPhone.Text}')";

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
        void UpdateStaffData()
        {
            try
            {
                string query = $"UPDATE companyStaff SET companyID = '{txtCompanyID.Text}', name = '{txtStaffName.Text}', mail = '{txtStaffMail.Text}'" +
                $", phone = '{txtStaffPhone.Text}' WHERE ID = {_staffID}";

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
            if (_staffID == 0) msgStr = "Kullanıcı eklenecek. Emin misiniz?"; else msgStr = "Kullanıcı güncellenecek. Emin misiniz?";
            DialogResult dialogResult = MessageBox.Show(msgStr, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (ValidateFields())
                {
                    if (_staffID == 0) InsertDataToDB(); else UpdateStaffData();

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

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                errorProvider1.SetError(txtStaffName, "Ad Soyad boş bırakılamaz!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtStaffMail.Text))
            {
                errorProvider1.SetError(txtStaffMail, "Geçerli bir mail adresi giriniz!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtStaffPhone.Text))
            {
                errorProvider1.SetError(txtStaffPhone, "Geçerli bir telefon numarası giriniz!");
                isValid = false;
            }

            return isValid;
        }
    }
}
